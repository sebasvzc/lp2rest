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
import pe.edu.pucp.lp2rest.almacen.dao.InsumoDAO;
import pe.edu.pucp.lp2rest.almacen.model.Insumo;
import pe.edu.pucp.lp2rest.almacen.model.UnidadMedida;
import pe.edu.pucp.lp2rest.config.DBManager;

/**
 *
 * @author Usuario
 */
public class InsumoMySQL implements InsumoDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Insumo ins) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_INSUMO(?,?,?,?,?,?)}");
            cs.setString("_sku", ins.getSKU());
            cs.setDouble("_stock", ins.getStock());
            cs.setString("_descripcion", ins.getDescripcion());
            cs.setString("_nombre", ins.getNombre());
            cs.setDouble("_precio_compra", ins.getPrecioCompra());
            cs.setString("_unidad_medida", ins.getUnidadMedida().toString());
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
    public int modificar(Insumo ins) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idInsumo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Insumo> listarTodos() {
        ArrayList<Insumo> insumos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_INSUMOS()");
            rs = cs.executeQuery();
            while (rs.next()) {
                Insumo ins = new Insumo();
                ins.setIdInsumo(rs.getInt("id_insumo"));
                ins.setSKU(rs.getString("sku"));
                ins.setDescripcion(rs.getString("descripcion"));
                ins.setStock(rs.getDouble("stock"));
                ins.setNombre(rs.getString("nombre"));
                ins.setPrecioCompra(rs.getDouble("precio_compra"));
                UnidadMedida um= UnidadMedida.valueOf(rs.getString("unidad_medida"));
                ins.setUnidadMedida(um);
                insumos.add(ins);
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
        return insumos;
    }
    
}
