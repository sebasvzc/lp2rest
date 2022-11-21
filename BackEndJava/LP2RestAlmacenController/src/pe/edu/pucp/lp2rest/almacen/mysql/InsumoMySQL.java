package pe.edu.pucp.lp2rest.almacen.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.almacen.dao.InsumoDAO;
import pe.edu.pucp.lp2rest.almacen.model.Insumo;
import pe.edu.pucp.lp2rest.almacen.model.TipoProducto;
import pe.edu.pucp.lp2rest.almacen.model.UnidadMedida;
import pe.edu.pucp.lp2rest.config.DBManager;

public class InsumoMySQL implements InsumoDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Insumo ins) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_INSUMO(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_insumo", java.sql.Types.INTEGER);
            cs.setString("_sku", ins.getSKU());
            cs.setDouble("_stock", ins.getStock());
            cs.setString("_descripcion", ins.getDescripcion());
            cs.setString("_nombre", ins.getNombre());
            cs.setDouble("_precio_compra", ins.getPrecioCompra());
            cs.setString("_unidad_medida", ins.getUnidadMedida().toString());
            cs.setInt("_fid_tipo_producto", ins.getTipoProducto().getIdTipoProducto());
            //System.out.println("La unidad de medida es : "+ins.getUnidadMedida().toString());
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
        int resultado = 0;
	try {
		con = DBManager.getInstance().getConnection();
		cs = con.prepareCall("{call MODIFICAR_INSUMO(?,?,?,?,?,?,?,?)}");
		cs.setInt("_id_insumo", ins.getIdInsumo());
		cs.setString("_sku", ins.getSKU());
		cs.setDouble("_stock", ins.getStock());
		cs.setString("_descripcion", ins.getDescripcion());
		cs.setString("_nombre", ins.getNombre());
		cs.setDouble("_precio_compra", ins.getPrecioCompra());
		cs.setString("_unidad_medida", ins.getUnidadMedida().toString());
		cs.setInt("_fid_tipo_producto", ins.getTipoProducto().getIdTipoProducto());
		//System.out.println("La unidad de medida es : "+ins.getUnidadMedida().toString());
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
    public int eliminar(int idInsumo) {
        int resultado = 0;
	try{
		con = DBManager.getInstance().getConnection();
		cs = con.prepareCall("{call ELIMINAR_INSUMO(?)}");
		cs.setInt("_id_insumo", idInsumo);            
		resultado = cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
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

    @Override
    public ArrayList<Insumo> buscarInsumosXNombre(String nombre) {
        ArrayList<Insumo> insumos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call BUSCAR_INSUMOS_POR_NOMBRE(?)");
            cs.setString("_nombre_insumo",nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Insumo insumo = new Insumo();
                insumo.setIdInsumo(rs.getInt("id_insumo"));
                insumo.setSKU(rs.getString("sku"));                
                insumo.setNombre(rs.getString("nombre"));
                insumo.setPrecioCompra(rs.getDouble("precio_compra"));
                insumos.add(insumo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return insumos;
    }
    
    @Override
    public ArrayList<Insumo> filtrarInsumos(String nombre,String SKU, int idPlato,double precioMin,double precioMax,double stockMin, double stockMax,int idTipoProducto) {
        ArrayList<Insumo> insumos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call FILTRAR_INSUMOS(?,?,?,?,?,?,?,?)");
            cs.setString("_nombre_insumo", nombre);
            cs.setString("_sku", SKU);

            if(idPlato!=-1) cs.setInt("_fid_plato", idPlato);
            else cs.setNull("_fid_plato", java.sql.Types.INTEGER);

            if(precioMin!=-1) cs.setDouble("_precio_compra_min", precioMin);
            else cs.setNull("_precio_compra_min", java.sql.Types.DECIMAL);

            if(precioMax!=-1) cs.setDouble("_precio_compra_max", precioMax);
            else cs.setNull("_precio_compra_max", java.sql.Types.DECIMAL);

            if(stockMin!=-1) cs.setDouble("_stock_min", stockMin);
            else cs.setNull("_stock_min", java.sql.Types.DECIMAL);

            if(stockMax!=-1) cs.setDouble("_stock_max", stockMax);
            else cs.setNull("_stock_max", java.sql.Types.DECIMAL);

            if(idTipoProducto!=-1) cs.setInt("_fid_tipo_producto", idTipoProducto);
            else cs.setNull("_fid_tipo_producto", java.sql.Types.INTEGER);

            rs = cs.executeQuery();
            while(rs.next()){
                    Insumo insumo = new Insumo();
                    insumo.setIdInsumo(rs.getInt("id_insumo")); 
                    insumo.setSKU(rs.getString("sku"));
                    insumo.setDescripcion(rs.getString("descripcion")); 
                    insumo.setStock(rs.getDouble("stock")); 
                    insumo.setNombre(rs.getString("nombre")); 
                    insumo.setPrecioCompra(rs.getDouble("precio_compra")); 
                    UnidadMedida um= UnidadMedida.valueOf(rs.getString("unidad_medida"));
                    insumo.setUnidadMedida(um);
                    //System.out.println(" El id es"+rs.getInt("fid_tipo_producto"));
                    insumo.setTipoProducto(new TipoProducto()); 
                    insumo.getTipoProducto().setIdTipoProducto(rs.getInt("fid_tipoProducto"));
                    insumo.getTipoProducto().setNombre(rs.getString("nombre_tipo"));
                    insumos.add(insumo);
            }
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }finally{
                try{con.close();}catch(Exception ex){
                        System.out.println(ex.getMessage());
                }
        }
        return insumos;

    }

    @Override
    public ArrayList<Insumo> listarRecetasPorIdItemVenta(int idItemVenta) {
        ArrayList<Insumo> insumos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_RECETAS_X_IDITEMVENTA(?)");
            cs.setInt("_id_itemVenta", idItemVenta);
            rs = cs.executeQuery();
            while(rs.next()){
                Insumo insumo = new Insumo();
                insumo.setIdInsumo(rs.getInt("id_insumo"));
                insumo.setSKU(rs.getString("sku"));
                insumo.setNombre(rs.getString("nombre"));
                insumo.setStock(rs.getDouble("cantidad"));
                insumo.setPrecioCompra(rs.getDouble("precio_compra"));
                insumos.add(insumo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return insumos;
    }
    
}