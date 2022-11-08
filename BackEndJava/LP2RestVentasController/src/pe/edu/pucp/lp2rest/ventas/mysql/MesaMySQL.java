package pe.edu.pucp.lp2rest.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.ventas.dao.MesaDAO;
import pe.edu.pucp.lp2rest.ventas.model.Mesa;

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

}
