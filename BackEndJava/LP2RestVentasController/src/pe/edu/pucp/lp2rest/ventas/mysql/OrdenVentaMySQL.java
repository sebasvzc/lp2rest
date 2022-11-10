package pe.edu.pucp.lp2rest.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.ventas.dao.OrdenVentaDAO;
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
            cs = con.prepareCall("{call INSERTAR_ORDEN_VENTA(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_ordenVenta", java.sql.Types.INTEGER);
            cs.setDouble("_total", ordenVenta.getTotal());
            cs.setBoolean("_pagado", ordenVenta.isPagado());
            cs.setDate("_fecha", new java.sql.Date(ordenVenta.getFecha().getTime()));
            cs.setInt("_fid_documentoDePago", ordenVenta.getDocumentoPago().getIdDocumentoPago());
            cs.setInt("_fid_mesa", ordenVenta.getMesa().getIdMesa());
            cs.setInt("_fid_mesero", ordenVenta.getMesero().getIdPersona());
            cs.setInt("_fid_cajero", ordenVenta.getCajero().getIdPersona());
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
    public int modificar(OrdenVenta ordenVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ORDEN_VENTA(?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_ordenVenta", ordenVenta.getIdOrdenVenta());
            cs.setDouble("_total", ordenVenta.getTotal());
            cs.setBoolean("_pagado", ordenVenta.isPagado());
            cs.setDate("_fecha", new java.sql.Date(ordenVenta.getFecha().getTime()));
            cs.setInt("_fid_documentoDePago", ordenVenta.getDocumentoPago().getIdDocumentoPago());
            cs.setInt("_fid_mesa", ordenVenta.getMesa().getIdMesa());
            cs.setInt("_fid_mesero", ordenVenta.getMesero().getIdPersona());
            cs.setInt("_fid_cajero", ordenVenta.getCajero().getIdPersona());
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
                ordenVenta.setIdOrdenVenta(rs.getInt("id_ordenVenta"));
                ordenVenta.setTotal(rs.getDouble("total"));
                ordenVenta.setPagado(rs.getBoolean("pagado"));
                ordenVenta.setFecha(rs.getDate("fecha"));
                ordenVenta.getDocumentoPago().setIdDocumentoPago(rs.getInt("fid_documentoDePago"));
                ordenVenta.getMesa().setIdMesa(rs.getInt("fid_mesa"));
                ordenVenta.getMesero().setIdPersona(rs.getInt("fid_mesero"));
                ordenVenta.getCajero().setIdPersona(rs.getInt("fid_cajero"));
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
