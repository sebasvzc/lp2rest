package pe.edu.pucp.lp2rest.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLType;
import java.util.ArrayList;
import java.util.Set;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cajero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Reserva;
import pe.edu.pucp.lp2rest.ventas.dao.MesaDAO;
import pe.edu.pucp.lp2rest.ventas.model.DocumentoPago;
import pe.edu.pucp.lp2rest.ventas.model.Mesa;
import pe.edu.pucp.lp2rest.ventas.model.OrdenVenta;

/**
 *
 * @author Gerard
 */
public class MesaMySQL implements MesaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Mesa mesa) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_MESA(?,?,?)}");
            cs.registerOutParameter("_id_mesa", java.sql.Types.INTEGER);
            cs.setInt("_capacidad_maxima", mesa.getCapacidadMaxima());
            cs.setBoolean("_disponible", mesa.isDisponible());
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Mesa mesa) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_MESA(?,?,?)}");
            cs.setInt("_id_mesa", mesa.getIdMesa());
            cs.setInt("_capacidad_maxima", mesa.getCapacidadMaxima());
            cs.setBoolean("_disponible", mesa.isDisponible());

            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idMesa) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_MESA(?)}");
            cs.setInt("_id_mesa", idMesa);
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Mesa> listarTodos() {
        ArrayList<Mesa> mesas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_MESAS()");
            rs = cs.executeQuery();
            while (rs.next()) {
                Mesa mesa = new Mesa();
                mesa.setReserva(new Reserva());
                mesa.setOrdVen(new OrdenVenta());
                
                
                mesa.setIdMesa(rs.getInt("id_mesa"));
                mesa.setCapacidadMaxima(rs.getInt("capacidad_maxima"));
                mesa.setDisponible(rs.getBoolean("disponible"));
                
                
                mesas.add(mesa);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return mesas;
    }

    @Override
    public int modificarOrdenVenta(Mesa mesa) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_MESA_2(?,?,?,?)}");
            cs.setInt("_id_mesa", mesa.getIdMesa());
            cs.setBoolean("_disponible", mesa.isDisponible());
            if(mesa.getOrdVen() == null){
                cs.setNull("_fid_ordenVenta", java.sql.Types.INTEGER );
            }else{
                cs.setInt("_fid_ordenVenta", mesa.getOrdVen().getIdOrdenVenta());
            }
            

            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Mesa> listarTodos2() {
        ArrayList<Mesa> mesas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_MESAS_VERSION2()");
            rs = cs.executeQuery();
            while (rs.next()) {
                Mesa mesa = new Mesa();
                mesa.setReserva(new Reserva());
                mesa.setOrdVen(new OrdenVenta());
                
                mesa.getOrdVen().setMesa( new Mesa() );
                mesa.getOrdVen().setMesero(new Mesero() );
                
                
                
                mesa.setIdMesa(rs.getInt("id_mesa"));
                mesa.setCapacidadMaxima(rs.getInt("capacidad_maxima"));
                mesa.setDisponible(rs.getBoolean("disponible"));
                
                int ordenVentaMesa = rs.getInt("id_ordenVenta");
                if( ordenVentaMesa != 0){
                    mesa.getOrdVen().setIdOrdenVenta( ordenVentaMesa );
                    mesa.getOrdVen().setTotal( rs.getDouble("total") );
                    mesa.getOrdVen().setPagado(rs.getBoolean("pagado") );
                    mesa.getOrdVen().setFecha( rs.getDate("fecha") );
                    
                    mesa.getOrdVen().setDocumentoPago(new DocumentoPago() );
                    mesa.getOrdVen().getDocumentoPago().setIdDocumentoPago( rs.getInt("fid_documentoDePago") );
                    
                    mesa.getOrdVen().getMesa().setIdMesa( rs.getInt("fid_mesa") );
                    
                    mesa.getOrdVen().getMesero().setIdPersona( rs.getInt("fid_mesero") );
                    
                    int idCajero = rs.getInt("fid_cajero");
                    if(idCajero != 0){
                        mesa.getOrdVen().setCajero( new Cajero() );                    
                        mesa.getOrdVen().getCajero().setIdPersona( idCajero );
                    }else{
                        mesa.getOrdVen().setCajero( null );     
                    }                    
                    
                    mesa.getOrdVen().setCliente( new Cliente() );
                    mesa.getOrdVen().getCliente().setIdPersona( rs.getInt("fid_cliente") );
                    mesa.getOrdVen().getCliente().setDNI( rs.getString("DNI") );
                    mesa.getOrdVen().getCliente().setNombre( rs.getString("nombres") );
                    mesa.getOrdVen().getCliente().setApellidoPaterno(rs.getString("apellidos") );     
                    
                    
                }
                
                mesas.add(mesa);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return mesas;
    }

}
