package pe.edu.pucp.lp2rest.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cajero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;
import pe.edu.pucp.lp2rest.ventas.dao.OrdenVentaDAO;
import pe.edu.pucp.lp2rest.ventas.model.DocumentoPago;
import pe.edu.pucp.lp2rest.ventas.model.Mesa;
import pe.edu.pucp.lp2rest.ventas.model.OrdenVenta;

/**
 *
 * @author Gerard
 */
public class OrdenVentaMySQL implements OrdenVentaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(OrdenVenta ordenVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ORDEN_VENTA(?,?,?,?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_id_ordenVenta", java.sql.Types.INTEGER);
            
            cs.setDouble("_total", ordenVenta.getTotal());
            cs.setBoolean("_pagado", ordenVenta.isPagado());
            cs.setDate("_fecha", new java.sql.Date(ordenVenta.getFecha().getTime()));
            if(ordenVenta.getDocumentoPago() == null){
                cs.setNull("_fid_documentoDePago", java.sql.Types.INTEGER);
            }else{
                cs.setInt("_fid_documentoDePago", ordenVenta.getDocumentoPago().getIdDocumentoPago());
            }
            
            cs.setInt("_fid_mesa", ordenVenta.getMesa().getIdMesa());
            cs.setInt("_fid_mesero", ordenVenta.getMesero().getIdPersona());
            if(ordenVenta.getCajero() == null){
                cs.setNull("_fid_cajero", java.sql.Types.INTEGER);
            }else{                
                cs.setInt("_fid_cajero", ordenVenta.getCajero().getIdPersona());
            }
            if(ordenVenta.getCliente() == null){
                cs.setNull("_fid_cliente", java.sql.Types.INTEGER);
            }else{
                cs.setInt("_fid_cliente", ordenVenta.getCliente().getIdPersona());
            }
            
            
            
            cs.executeUpdate();
            
            ordenVenta.setIdOrdenVenta(cs.getInt("_id_ordenVenta"));
            
            resultado = ordenVenta.getIdOrdenVenta();
            
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
    public int modificar(OrdenVenta ordenVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ORDEN_VENTA(?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_ordenVenta", ordenVenta.getIdOrdenVenta());
            cs.setDouble("_total", ordenVenta.getTotal());
            cs.setBoolean("_pagado", ordenVenta.isPagado());
            cs.setDate("_fecha", new java.sql.Date(ordenVenta.getFecha().getTime()));
            if(ordenVenta.getDocumentoPago() == null){
                cs.setNull("_fid_documentoDePago", java.sql.Types.INTEGER);
            }else{
                cs.setInt("_fid_documentoDePago", ordenVenta.getDocumentoPago().getIdDocumentoPago());
            }
            cs.setInt("_fid_mesa", ordenVenta.getMesa().getIdMesa());
            cs.setInt("_fid_mesero", ordenVenta.getMesero().getIdPersona());
            
            if(ordenVenta.getCajero() == null){
                cs.setNull("_fid_cajero", java.sql.Types.INTEGER);
            }else{                
                cs.setInt("_fid_cajero", ordenVenta.getCajero().getIdPersona());
            }
            
            if(ordenVenta.getCliente() == null){
                cs.setNull("_fid_cliente", java.sql.Types.INTEGER);
            }else{
                cs.setInt("_fid_cliente", ordenVenta.getCliente().getIdPersona());
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
    public int eliminar(int idOrdenVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ORDEN_VENTA(?)}");
            cs.setInt("_id_ordenVenta", idOrdenVenta);
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
    public ArrayList<OrdenVenta> listarTodos() {
        ArrayList<OrdenVenta> ordenesVenta = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TODOS_ORDEN_VENTA()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                OrdenVenta ordenVenta = new OrdenVenta();
                ordenVenta.setDocumentoPago(new DocumentoPago());
                ordenVenta.setCajero(new Cajero());
                ordenVenta.setMesero(new Mesero());
                ordenVenta.setMesa(new Mesa());
                ordenVenta.setCliente(new Cliente());                
                
                ordenVenta.setIdOrdenVenta(rs.getInt("id_ordenVenta"));
                ordenVenta.setTotal(rs.getDouble("total"));
                ordenVenta.setPagado(rs.getBoolean("pagado"));
                ordenVenta.setFecha(rs.getDate("fecha"));
                ordenVenta.getDocumentoPago().setIdDocumentoPago(rs.getInt("fid_documentoDePago"));
                ordenVenta.getMesa().setIdMesa(rs.getInt("fid_mesa"));
                ordenVenta.getMesero().setIdPersona(rs.getInt("fid_mesero"));
                ordenVenta.getCajero().setIdPersona(rs.getInt("fid_cajero"));
                ordenVenta.getCliente().setIdPersona(rs.getInt("fid_cliente"));
                ordenVenta.getCliente().setNombre(rs.getString("nombres"));
                ordenVenta.getCliente().setApellidoPaterno(rs.getString("apellidos"));
                ordenesVenta.add(ordenVenta);
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
        return ordenesVenta;
    }

    @Override
    public ArrayList<OrdenVenta> listarBusqueda(String nombre, String apellido, Date fechaIni, Date fechaFin, double sueldoIni, double sueldoFin) {
        ArrayList<OrdenVenta> ordenesVenta = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BUSQUEDA_ORDEN_VENTA(?,?,?,?,?,?)}");
            
            cs.setString("_cliNom", nombre);
            cs.setString("_cliApe", apellido);
            
            cs.setDate("_fechaIni", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_fechaFin", new java.sql.Date(fechaFin.getTime()));
            
            cs.setDouble("_sueldoIni", sueldoIni);
            cs.setDouble("_sueldoFin", sueldoFin);
            
            rs = cs.executeQuery();
            while (rs.next()) {
                OrdenVenta ordenVenta = new OrdenVenta();
                ordenVenta.setDocumentoPago(new DocumentoPago());
                ordenVenta.setCajero(new Cajero());
                ordenVenta.setMesero(new Mesero());
                ordenVenta.setMesa(new Mesa());
                ordenVenta.setCliente(new Cliente());                
                
                ordenVenta.setIdOrdenVenta(rs.getInt("id_ordenVenta"));
                ordenVenta.setTotal(rs.getDouble("total"));
                ordenVenta.setPagado(rs.getBoolean("pagado"));
                ordenVenta.setFecha(rs.getDate("fecha"));
                ordenVenta.getDocumentoPago().setIdDocumentoPago(rs.getInt("fid_documentoDePago"));
                ordenVenta.getMesa().setIdMesa(rs.getInt("fid_mesa"));
                ordenVenta.getMesero().setIdPersona(rs.getInt("fid_mesero"));
                ordenVenta.getCajero().setIdPersona(rs.getInt("fid_cajero"));
                ordenVenta.getCliente().setDNI(rs.getString("DNI") );
                ordenVenta.getCliente().setNombre(rs.getString("nombres"));
                ordenVenta.getCliente().setApellidoPaterno(rs.getString("apellidos"));
                ordenVenta.setEstado(rs.getString("estado"));
                ordenesVenta.add(ordenVenta);
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
        return ordenesVenta;
    }

    @Override
    public int actualizar(int idOrdenVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ACTUALIZAR_ESTADO_ORDEN_VENTA(?)}");
            cs.setInt("_id_ordenVenta", idOrdenVenta);
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
        //throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public ArrayList<OrdenVenta> listarBusquedaMesero(int idMesero, String nombre, String apellido, Date fechaIni, Date fechaFin, double sueldoIni, double sueldoFin) {
        ArrayList<OrdenVenta> ordenesVenta = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BUSQUEDA_ORDEN_VENTA_MESERO(?,?,?,?,?,?,?)}");
            
            cs.setInt("_idMesero", idMesero);
            
            cs.setString("_cliNom", nombre);
            cs.setString("_cliApe", apellido);
            
            cs.setDate("_fechaIni", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_fechaFin", new java.sql.Date(fechaFin.getTime()));
            
            cs.setDouble("_sueldoIni", sueldoIni);
            cs.setDouble("_sueldoFin", sueldoFin);
            
            rs = cs.executeQuery();
            while (rs.next()) {
                OrdenVenta ordenVenta = new OrdenVenta();
                ordenVenta.setDocumentoPago(new DocumentoPago());
                ordenVenta.setCajero(new Cajero());
                ordenVenta.setMesero(new Mesero());
                ordenVenta.setMesa(new Mesa());
                ordenVenta.setCliente(new Cliente());                
                
                ordenVenta.setIdOrdenVenta(rs.getInt("id_ordenVenta"));
                ordenVenta.setTotal(rs.getDouble("total"));
                ordenVenta.setPagado(rs.getBoolean("pagado"));
                ordenVenta.setFecha(rs.getDate("fecha"));
                ordenVenta.getDocumentoPago().setIdDocumentoPago(rs.getInt("fid_documentoDePago"));
                ordenVenta.getMesa().setIdMesa(rs.getInt("fid_mesa"));
                ordenVenta.getMesero().setIdPersona(rs.getInt("fid_mesero"));
                ordenVenta.getCajero().setIdPersona(rs.getInt("fid_cajero"));
                ordenVenta.getCliente().setDNI(rs.getString("DNI") );
                ordenVenta.getCliente().setNombre(rs.getString("nombres"));
                ordenVenta.getCliente().setApellidoPaterno(rs.getString("apellidos"));
                ordenVenta.setEstado(rs.getString("estado"));
                ordenesVenta.add(ordenVenta);
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
        return ordenesVenta;
    }

    @Override
    public ArrayList<OrdenVenta> listarBusquedaAdministrador(String nombre, String apellido, Date fechaIni, Date fechaFin, double sueldoIni, double sueldoFin) {
        ArrayList<OrdenVenta> ordenesVenta = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BUSQUEDA_ORDEN_VENTA_ADMIN(?,?,?,?,?,?)}");
            
            cs.setString("_cliNom", nombre);
            cs.setString("_cliApe", apellido);
            
            cs.setDate("_fechaIni", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_fechaFin", new java.sql.Date(fechaFin.getTime()));
            
            cs.setDouble("_sueldoIni", sueldoIni);
            cs.setDouble("_sueldoFin", sueldoFin);
            
            rs = cs.executeQuery();
            while (rs.next()) {
                OrdenVenta ordenVenta = new OrdenVenta();
                ordenVenta.setDocumentoPago(new DocumentoPago());
                ordenVenta.setMesa(new Mesa());
                
                ordenVenta.setIdOrdenVenta(rs.getInt("id_ordenVenta"));
                ordenVenta.setTotal(rs.getDouble("total"));
                ordenVenta.setPagado(rs.getBoolean("pagado"));
                ordenVenta.setFecha(rs.getDate("fecha"));
                ordenVenta.getDocumentoPago().setIdDocumentoPago(rs.getInt("fid_documentoDePago"));                
                ordenVenta.getMesa().setIdMesa(rs.getInt("fid_mesa"));
                ordenVenta.setEstado(rs.getString("estado"));
                
                ordenVenta.setMesero(new Mesero());
                ordenVenta.getMesero().setIdPersona(rs.getInt("fid_mesero"));
                ordenVenta.getMesero().setDNI(rs.getString("DNIMesero") );
                ordenVenta.getMesero().setNombre(rs.getString("nombresMesero") );
                ordenVenta.getMesero().setApellidoPaterno(rs.getString("apellidosMesero") );
                
                
                int auxIdCajero = rs.getInt("fid_cajero");
                if(auxIdCajero != 0){
                    ordenVenta.setCajero(new Cajero());
                    ordenVenta.getCajero().setIdPersona(auxIdCajero);
                    ordenVenta.getCajero().setDNI(rs.getString("DNIMesero") );
                    ordenVenta.getCajero().setNombre(rs.getString("nombresMesero") );
                    ordenVenta.getCajero().setApellidoPaterno(rs.getString("apellidosMesero") );
                    
                }else{
                    ordenVenta.setCajero( null );
                }
                
                ordenVenta.setCliente(new Cliente());           
                ordenVenta.getCliente().setIdPersona( rs.getInt("fid_cliente") );
                ordenVenta.getCliente().setDNI(rs.getString("DNICliente") );
                ordenVenta.getCliente().setNombre(rs.getString("nombresCliente"));
                ordenVenta.getCliente().setApellidoPaterno(rs.getString("apellidosCliente"));
                
                ordenesVenta.add(ordenVenta);
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
        return ordenesVenta;
    }
}
