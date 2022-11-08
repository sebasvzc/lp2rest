/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2rest.almacen.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.almacen.dao.OrdenCompraDAO;
import pe.edu.pucp.lp2rest.almacen.model.OrdenCompra;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.model.Proveedor;

/**
 *
 * @author Usuario
 */
public class OrdenCompraMySQL implements OrdenCompraDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public int insertar(OrdenCompra oc) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_SOLICITUD_ORDEN_COMPRA(?,?,?,?,?)}");
            cs.setInt("_fid_id_proveedor", oc.getProveedor().getIdPersona());
            cs.setString("_descripcion", oc.getDescripcion());
            cs.setDate("_fecha_registro", new java.sql.Date(oc.getFechaHoraCreacion().getTime()));
            cs.setDate("_fecha_cumplimiento", new java.sql.Date(oc.getFechaHoraCumplimiento().getTime()));
            cs.setDouble("_monto_total", oc.getTotal());
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
    public int modificar(OrdenCompra oc) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idOrdenCompra) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<OrdenCompra> listarTodos() {
        ArrayList<OrdenCompra> compras = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_SOLICITUDES_ORDENES_COMPRA()");
            rs = cs.executeQuery();
            while (rs.next()) {
                OrdenCompra compra = new OrdenCompra();
                compra.setIdOrdenCompra(rs.getInt("id_solicitudOrdenDeCompra"));
                Proveedor paux= new Proveedor();
                paux.setIdPersona(rs.getInt("fid_id_proveedor"));
                compra.setProveedor(paux);
                compra.setDescripcion(rs.getString("descripcion"));
                compra.setFechaHoraCreacion(rs.getDate("fecha_registro"));
                compra.setFechaHoraCumplimiento(rs.getDate("fecha_cumplimiento"));
                compra.setTotal(rs.getDouble("monto_total"));
                compras.add(compra);
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
        return compras;
    }
    
}
