/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2rest.menu.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.menu.dao.ItemVentaDAO;
import pe.edu.pucp.lp2rest.menu.model.ItemVenta;
import pe.edu.pucp.lp2rest.menu.model.LineaDetalleCombo;
import pe.edu.pucp.lp2rest.menu.model.Receta;
import pe.edu.pucp.lp2rest.menu.model.TipoItem;

public class ItemVentaMySQL implements ItemVentaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(ItemVenta itemVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ITEM_VENTA(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_itemVenta", java.sql.Types.INTEGER);
            cs.setString("_nombre", itemVenta.getNombre());
            cs.setDouble("_precio", itemVenta.getPrecio());
            cs.setInt("_stock", itemVenta.getStock());
            cs.setInt("_fid_tipoItem", itemVenta.getTipoItem().getIdTipoItem());
            cs.setInt("_disponible", itemVenta.getDisponible());
            cs.executeUpdate();
            
            itemVenta.setIdItemVenta(cs.getInt("_id_itemVenta"));
            
            for(Receta receta : itemVenta.getRecetas()){
                cs = con.prepareCall("{call INSERTAR_RECETA_ITEMVENTA_INSUMO(?,?,?,?)}");
                cs.registerOutParameter("_id_receta", java.sql.Types.INTEGER);
                cs.setDouble("_cantidad", receta.getCantidad());
                cs.setInt("_fid_itemVenta", itemVenta.getIdItemVenta());
                cs.setInt("_fid_insumo", receta.getInsumo().getIdInsumo());
                cs.executeUpdate();
            }
            
            resultado = itemVenta.getIdItemVenta();
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
    public int modificar(ItemVenta itemVenta) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idItemVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ITEM_VENTA(?)}");
            cs.setInt("_id_itemVenta", idItemVenta);
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
    public ArrayList<ItemVenta> listarTodos() {
        ArrayList<ItemVenta> itemventas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_ITEM_VENTA()");
            rs = cs.executeQuery();
            while (rs.next()) {
                ItemVenta itv = new ItemVenta();
                itv.setIdItemVenta(rs.getInt("id_itemVenta"));
                itv.setNombre(rs.getString("nombre"));
                itv.setPrecio(rs.getDouble("precio"));
                itv.setStock(rs.getInt("stock"));
                itv.setDisponible(rs.getInt("disponible"));
                itemventas.add(itv);
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
        return itemventas;
    }

    @Override
    public ArrayList<ItemVenta> filtrarItemsVenta(String nombrePlato, int id_tipoItem, 
            double precio_min, double precio_max, int disponible) {
        
        ArrayList<ItemVenta> itemsVenta = new ArrayList<>();
        
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call FILTRAR_PLATOS(?,?,?,?,?)");
            cs.setString("_nombre_plato", nombrePlato);
            cs.setInt("_fid_tipoItem", id_tipoItem);
            cs.setDouble("_precio_min", precio_min);            
            cs.setDouble("_precio_max", precio_max);
            cs.setInt("_disponible", disponible);
            rs = cs.executeQuery();
            while(rs.next()){
                ItemVenta itemVenta = new ItemVenta();
                itemVenta.setIdItemVenta(rs.getInt("id_itemVenta"));                
                itemVenta.setNombre(rs.getString("nombre"));                
                itemVenta.setTipoItem(new TipoItem());
                itemVenta.getTipoItem().setIdTipoItem(id_tipoItem);  
                itemVenta.getTipoItem().setDescripcion(rs.getString("descripcion"));
                itemVenta.setPrecio(rs.getDouble("precio"));
                itemVenta.setStock(rs.getInt("stock"));
                itemsVenta.add(itemVenta);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return itemsVenta;
    }

    @Override
    public int insertarCombo(ItemVenta itemVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ITEM_VENTA(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_itemVenta", java.sql.Types.INTEGER);
            cs.setString("_nombre", itemVenta.getNombre());
            cs.setDouble("_precio", itemVenta.getPrecio());
            cs.setInt("_stock", itemVenta.getStock());
            cs.setInt("_fid_tipoItem", itemVenta.getTipoItem().getIdTipoItem());
            cs.setInt("_disponible", itemVenta.getDisponible());
            cs.executeUpdate();
            
            itemVenta.setIdItemVenta(cs.getInt("_id_itemVenta"));
            
            for(LineaDetalleCombo ldc : itemVenta.getLineasCombo()){
                cs = con.prepareCall("{call INSERTAR_LINEA_DETALLE_COMBO(?,?,?,?)}");
                cs.registerOutParameter("_id_linea_detalle_combo", java.sql.Types.INTEGER);
                cs.setDouble("_cantidad", ldc.getCantidad());
                cs.setInt("_fid_combo", itemVenta.getIdItemVenta());
                cs.setInt("_fid_producto", ldc.getFid_producto());
                cs.executeUpdate();
            }
            
            resultado = itemVenta.getIdItemVenta();
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
}