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
import pe.edu.pucp.lp2rest.almacen.dao.LineaOrdenCompraDAO;
import pe.edu.pucp.lp2rest.almacen.model.LineaOrdenCompra;
import pe.edu.pucp.lp2rest.almacen.model.OrdenCompra;
import pe.edu.pucp.lp2rest.almacen.model.Insumo;

import pe.edu.pucp.lp2rest.config.DBManager;

/**
 *
 * @author Usuario
 */
public class LineaOrdenCompraMySQL implements LineaOrdenCompraDAO{
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public int insertar(LineaOrdenCompra loc) {
        int resultado = 0;
        try {
            
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_LINEA_ORDEN_COMPRA(?,?,?,?,?)}");
            cs.setInt("_fid_insumo", loc.getInsumo().getIdInsumo());
            cs.setInt("_fid_solicitud_orden_compra", loc.getOrdenCompra().getIdOrdenCompra());
            cs.setDouble("_cantidad", loc.getCantidad());
            cs.setDouble("_precio_unitario", loc.getPrecioUnitario());
            cs.setDate("_fecha_vencimiento", new java.sql.Date(loc.getFechaVencimiento().getTime()));
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
    public int modificar(LineaOrdenCompra loc) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idLineaOrdenCompra) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<LineaOrdenCompra> listarTodos() {
         ArrayList<LineaOrdenCompra> lcompras = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_LINEAS_SOLICITUDES_ORDENES_COMPRA()");
            rs = cs.executeQuery();
            while (rs.next()) {
                LineaOrdenCompra lcompra = new LineaOrdenCompra();
                lcompra.setIdLineaOrdenCompra(rs.getInt("id_lineaOrdenDeCompra"));
                
                Insumo ins= new Insumo();
                ins.setIdInsumo(rs.getInt("fid_insumo"));
                lcompra.setInsumo(ins);
                
                OrdenCompra ocaux= new OrdenCompra();
                ocaux.setIdOrdenCompra(rs.getInt("fid_ordenDeCompra"));
                lcompra.setOrdenCompra(ocaux);
                
                lcompra.setFechaVencimiento(rs.getDate("fecha_vencimiento"));
                lcompra.setCantidad(rs.getDouble("cantidad"));
                lcompra.setPrecioUnitario(rs.getDouble("precio_unitario"));
                lcompras.add(lcompra);
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
        return lcompras;
    }
    
}
