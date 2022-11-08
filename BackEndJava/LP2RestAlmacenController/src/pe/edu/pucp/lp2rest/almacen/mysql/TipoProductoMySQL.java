package pe.edu.pucp.lp2rest.almacen.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.almacen.dao.TipoProductoDAO;
import pe.edu.pucp.lp2rest.almacen.model.TipoProducto;
import pe.edu.pucp.lp2rest.config.DBManager;

public class TipoProductoMySQL implements TipoProductoDAO{
     private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public int insertar(TipoProducto tipo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int modificar(TipoProducto tipo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idTipo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<TipoProducto> listarTodos() {
        ArrayList<TipoProducto> tipoProductos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TIPOPRODUCTOS()");
            rs = cs.executeQuery();
            while (rs.next()) {
                TipoProducto tipoProducto = new TipoProducto();
                tipoProducto.setIdTipoProducto(rs.getInt("id_tipoProducto"));
                tipoProducto.setNombre(rs.getString("nombre"));
                tipoProducto.setDescripcion(rs.getString("descripcion"));
                tipoProductos.add(tipoProducto);
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
        return tipoProductos;
    }
}