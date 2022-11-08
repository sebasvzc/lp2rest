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
import pe.edu.pucp.lp2rest.menu.dao.TipoItemDAO;
import pe.edu.pucp.lp2rest.menu.model.TipoItem;

public class TipoItemMySQL implements TipoItemDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(TipoItem tipoItem) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_TIPO_ITEM(?,?,?)}");
            cs.registerOutParameter("_id_tipoItem", java.sql.Types.INTEGER);
            cs.setString("_codigo", tipoItem.getCodigo());
            cs.setString("_descripcion", tipoItem.getDescripcion());
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
    public int modificar(TipoItem tipoItem) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idTipoItem) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_TIPO_ITEM(?)}");
            cs.setInt("_id_tipoItem", idTipoItem);
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
    public ArrayList<TipoItem> listarTodos() {
        ArrayList<TipoItem> tiposItem = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TIPO_ITEM()");
            rs = cs.executeQuery();
            while(rs.next()){
                TipoItem tipoItem = new TipoItem();
                tipoItem.setIdTipoItem(rs.getInt("id_tipoItem"));
                tipoItem.setCodigo(rs.getString("codigo"));
                tipoItem.setDescripcion(rs.getString("descripcion"));    
                tiposItem.add(tipoItem);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return tiposItem;
    }

}
