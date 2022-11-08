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
    public int modificar(ItemVenta itemVenta) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idItemVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_DOCUMENTO_PAGO(?)}");
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
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

}
