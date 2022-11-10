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
import java.util.Date;
import pe.edu.pucp.lp2rest.almacen.dao.OrdenCompraDAO;
import pe.edu.pucp.lp2rest.almacen.model.Insumo;
import pe.edu.pucp.lp2rest.almacen.model.LineaOrdenCompra;
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
            cs = con.prepareCall("{call INSERTAR_SOLICITUD_ORDEN_COMPRA(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_ordenCompra", java.sql.Types.INTEGER);
            cs.setInt("_fid_id_proveedor", oc.getProveedor().getIdPersona());
            cs.setString("_descripcion", oc.getDescripcion());
            cs.setDate("_fecha_registro", new java.sql.Date(oc.getFechaHoraCreacion().getTime()));
            cs.setDate("_fecha_cumplimiento", new java.sql.Date(oc.getFechaHoraCumplimiento().getTime()));
            cs.setDouble("_monto_total", oc.getTotal());
            cs.executeUpdate();
            oc.setIdOrdenCompra(cs.getInt("_id_ordenCompra"));
            
            for(LineaOrdenCompra linea : oc.getLineasOrdenCompra()){
                cs = con.prepareCall("{call INSERTAR_LINEA_ORDEN_COMPRA(?,?,?,?,?,?)}");
                cs.registerOutParameter("_id_linea_orden_compra", java.sql.Types.INTEGER);
                cs.setInt("_fid_solicitud_orden_compra", oc.getIdOrdenCompra());
                cs.setInt("_fid_insumo", linea.getInsumo().getIdInsumo());
                cs.setDouble("_cantidad", linea.getCantidad());
                cs.setDouble("_precio_unitario", linea.getPrecioUnitario());
                cs.setDate("_fecha_vencimiento", new java.sql.Date(linea.getFechaVencimiento().getTime()));
                cs.executeUpdate();
            }
            resultado = oc.getIdOrdenCompra();
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
       int resultado = 0;
       try {
                System.out.println("Por ahora inicia la modifiacion de orden de compra "+oc.getIdOrdenCompra());
		con = DBManager.getInstance().getConnection();
		cs = con.prepareCall("{call MODIFICAR_SOLICITUD_ORDEN_COMPRA(?,?,?,?,?,?)}");
		cs.setInt("_id_solicitudOrdenDeCompra", oc.getIdOrdenCompra());
		cs.setInt("_fid_id_proveedor", oc.getProveedor().getIdPersona());
		cs.setString("_descripcion", oc.getDescripcion());
		cs.setDate("_fecha_registro", new java.sql.Date(oc.getFechaHoraCreacion().getTime()));
		cs.setDate("_fecha_cumplimiento", new java.sql.Date(oc.getFechaHoraCumplimiento().getTime()));
		cs.setDouble("_monto_total", oc.getTotal());
		//System.out.println("La unidad de medida es : "+ins.getUnidadMedida().toString());
                cs.executeUpdate();
                
                
                System.out.println("Por ahora bien la modifiacion de orden de compra "+oc.getIdOrdenCompra());
                
                cs = con.prepareCall("call LISTAR_SOLICITUD_ORDEN_COMPRA(?)");
                cs.setInt("_fid_solicitud_orden_compra", oc.getIdOrdenCompra());
                rs = cs.executeQuery();
                while (rs.next()) {
                    LineaOrdenCompra lcompra = new LineaOrdenCompra();

                    lcompra.setIdLineaOrdenCompra(rs.getInt("id_lineaOrdenDeCompra"));
                    
                    cs = con.prepareCall("call ELIMINAR_LINEA_ORDEN_COMPRA(?)");
                    cs.setInt("_id_lineaOrdenDeCompra", lcompra.getIdLineaOrdenCompra());
                    cs.executeUpdate();
                }
                System.out.println("Por ahora bien la elimacion de la lista de orden de compra"+oc.getIdOrdenCompra());
                for(LineaOrdenCompra linea : oc.getLineasOrdenCompra()){
                    cs = con.prepareCall("{call INSERTAR_LINEA_ORDEN_COMPRA(?,?,?,?,?,?)}");
                    System.out.println("Se insertara lo siguiente: "+ oc.getIdOrdenCompra()+" "+linea.getInsumo().getIdInsumo());
                    cs.registerOutParameter("_id_linea_orden_compra", java.sql.Types.INTEGER);
                    cs.setInt("_fid_solicitud_orden_compra", oc.getIdOrdenCompra());
                    cs.setInt("_fid_insumo", linea.getInsumo().getIdInsumo());
                    cs.setDouble("_cantidad", linea.getCantidad());
                    cs.setDouble("_precio_unitario", linea.getPrecioUnitario());
                    cs.setDate("_fecha_vencimiento", new java.sql.Date(linea.getFechaVencimiento().getTime()));
                    System.out.println("Insert de insumo "+linea.getInsumo().getIdInsumo());
                    cs.executeUpdate();
                }
                
		resultado = oc.getIdOrdenCompra();
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
    public int eliminar(int idOrdenCompra) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call `ELIMINAR_SOLICITUD_ORDENES_COMPRA`(?)}");
            cs.setInt("_id_solicitudOrdenDeCompra", idOrdenCompra);
            resultado=cs.executeUpdate();
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
    

    @Override
    public ArrayList<OrdenCompra> filtrarOrdenCompras(int id_solicitudOrdenDeCompra, Date fecha_registro_max, Date fecha_registro_min, double monto_total_max, double monto_total_min, int idInsumo) {
        ArrayList<OrdenCompra> compras = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call FILTRAR_ORDEN_COMPRA(?,?,?,?,?,?)");
            if(idInsumo!=-1) cs.setInt("_fid_insumo", idInsumo);
            else cs.setNull("_fid_insumo", java.sql.Types.INTEGER);
            
            if(monto_total_min!=-1) cs.setDouble("_monto_total_min", monto_total_min);    
            else cs.setNull("_monto_total_min", java.sql.Types.DECIMAL);
            
            if(monto_total_max!=-1) cs.setDouble("_monto_total_max", monto_total_max);
            else cs.setNull("_monto_total_max", java.sql.Types.DECIMAL);
            
            if(id_solicitudOrdenDeCompra!=-1) cs.setInt("_id_orden", id_solicitudOrdenDeCompra);
            else cs.setNull("_id_orden", java.sql.Types.INTEGER);
            
            cs.setDate("_fecha_registro_min", new java.sql.Date(fecha_registro_min.getTime()));
            cs.setDate("_fecha_registro_max", new java.sql.Date(fecha_registro_max.getTime()));
            
            rs = cs.executeQuery();
            while (rs.next()) {
                OrdenCompra compra = new OrdenCompra();
                compra.setIdOrdenCompra(rs.getInt("id_solicitudOrdenDeCompra"));
                //Proveedor paux= new Proveedor();
                compra.setProveedor(new Proveedor());
                compra.getProveedor().setIdPersona(rs.getInt("fid_id_proveedor"));
                compra.getProveedor().setRazonSocial(rs.getString("razon_social"));
                compra.setDescripcion(rs.getString("descripcion"));
                compra.setFechaHoraCreacion(rs.getDate("fecha_registro"));
                compra.setFechaHoraCumplimiento(rs.getDate("fecha_cumplimiento"));
                compra.setTotal(rs.getDouble("monto_total"));
                compra.setEstado(rs.getString("estado"));
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

    @Override
    public int actualizarEstadoOrdenCompra(int idOrdenCompra) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ACTUALIZAR_ESTADO_ORDEN_COMPRA(?)}");
            cs.setInt("_id_ordenCompra", idOrdenCompra);
            resultado=cs.executeUpdate();
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
