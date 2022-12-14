package pe.edu.pucp.lp2rest.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.menu.model.ItemVenta;
import pe.edu.pucp.lp2rest.ventas.dao.LineaOrdenVentaDAO;
import pe.edu.pucp.lp2rest.ventas.model.LineaOrdenVenta;
import pe.edu.pucp.lp2rest.ventas.model.OrdenVenta;

/**
 *
 * @author Gerard
 */
public class LineaOrdenVentaMySQL implements LineaOrdenVentaDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(LineaOrdenVenta lineaOrdenVenta) {
        int resultado = 0;
        try {
            // _subtotal
            // _fecha_registro
            // _descuento
            // _monto_descontado
            // _cantidadVenta
            // _fid_itemVenta
            // _fid_ordenVenta
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_LINEA_ORDEN_VENTA(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_lineaOrdenVenta", java.sql.Types.INTEGER);
            cs.setDouble("_subtotal", lineaOrdenVenta.getSubtotal());
            cs.setDate("_fecha_registro", new java.sql.Date(lineaOrdenVenta.getFechaRegistro().getTime()));
            cs.setDouble("_descuento", lineaOrdenVenta.getDescuento());
            cs.setDouble("_monto_descontado", lineaOrdenVenta.getMontoDescontado());
            cs.setInt("_cantidadVenta", lineaOrdenVenta.getCantidadVendida());
            cs.setInt("_fid_itemVenta", lineaOrdenVenta.getItemVenta().getIdItemVenta());
            cs.setInt("_fid_ordenVenta", lineaOrdenVenta.getOrdenVenta().getIdOrdenVenta());
            cs.executeUpdate();
            resultado = cs.getInt("_id_lineaOrdenVenta");
            lineaOrdenVenta.setIdLineaOrdenVenta(resultado);
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
    public int modificar(LineaOrdenVenta lineaOrdenVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_LINEA_ORDEN_VENTA(?,?,?,?,?,?,?)}");
            cs.setInt("_id_lineaOrdenVenta", lineaOrdenVenta.getIdLineaOrdenVenta());
            cs.setDouble("_subtotal", lineaOrdenVenta.getSubtotal());
            cs.setDate("_fecha_registro", new java.sql.Date(lineaOrdenVenta.getFechaRegistro().getTime()));
            cs.setDouble("_descuento", lineaOrdenVenta.getDescuento());
            cs.setDouble("_monto_descontado", lineaOrdenVenta.getMontoDescontado());
            cs.setInt("_cantidadVenta", lineaOrdenVenta.getCantidadVendida());
            cs.setInt("_fid_itemVenta", lineaOrdenVenta.getItemVenta().getIdItemVenta());
            cs.setInt("_fid_ordenVenta", lineaOrdenVenta.getOrdenVenta().getIdOrdenVenta());
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
    public int eliminar(int idLineaOrdenVenta) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_LINEA_ORDEN_VENTA(?)}");
            cs.setInt("_id_lineaOrdenVenta", idLineaOrdenVenta);
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
    public ArrayList<LineaOrdenVenta> listarTodos() {
        ArrayList<LineaOrdenVenta> lineasOrdenVenta = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TODOS_LINEA_ORDEN_VENTA()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                LineaOrdenVenta lineaOrdenVenta = new LineaOrdenVenta();
                lineaOrdenVenta.setIdLineaOrdenVenta(rs.getInt("id_lineaOrdenVenta"));
                lineaOrdenVenta.setSubtotal(rs.getDouble("subtotal"));
                lineaOrdenVenta.setFechaRegistro(rs.getDate("fecha_registro"));
                lineaOrdenVenta.setDescuento(rs.getDouble("descuento"));
                lineaOrdenVenta.setMontoDescontado(rs.getDouble("monto_descontado"));
                lineaOrdenVenta.setCantidadVendida(rs.getInt("cantidadVenta"));
                lineaOrdenVenta.setItemVenta(new ItemVenta());
                lineaOrdenVenta.setOrdenVenta(new OrdenVenta());
                lineaOrdenVenta.getItemVenta().setIdItemVenta(rs.getInt("fid_itemVenta"));
                lineaOrdenVenta.getOrdenVenta().setIdOrdenVenta(rs.getInt("fid_ordenVenta"));
                lineasOrdenVenta.add(lineaOrdenVenta);
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
        return lineasOrdenVenta;
    }

    @Override
    public ArrayList<LineaOrdenVenta> listarLineasPorId(int idOrdenVenta) {
        ArrayList<LineaOrdenVenta> lineasOrdenVenta = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LINEA_ORDEN_VENTA_POR_ID(?)}");
            cs.setInt("_id_ordenVenta",idOrdenVenta);
            rs = cs.executeQuery();
            while (rs.next()) {
                LineaOrdenVenta lineaOrdenVenta = new LineaOrdenVenta();
                lineaOrdenVenta.setIdLineaOrdenVenta(rs.getInt("id_lineaOrdenVenta"));
                lineaOrdenVenta.setSubtotal(rs.getDouble("subtotal"));
                lineaOrdenVenta.setFechaRegistro(rs.getDate("fecha_registro"));
                lineaOrdenVenta.setDescuento(rs.getDouble("descuento"));
                lineaOrdenVenta.setMontoDescontado(rs.getDouble("monto_descontado"));
                lineaOrdenVenta.setCantidadVendida(rs.getInt("cantidadVenta"));

                lineaOrdenVenta.setItemVenta(new ItemVenta());
                lineaOrdenVenta.getItemVenta().setIdItemVenta(rs.getInt("idItem"));
                lineaOrdenVenta.getItemVenta().setNombre(rs.getString("nombreItem"));
                lineaOrdenVenta.getItemVenta().setPrecio( rs.getDouble("precioItem") );

                lineaOrdenVenta.setOrdenVenta(new OrdenVenta());
                lineaOrdenVenta.getOrdenVenta().setIdOrdenVenta(rs.getInt("fid_ordenVenta"));
                lineasOrdenVenta.add(lineaOrdenVenta);
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
        return lineasOrdenVenta;
    }

    @Override
    public ArrayList<LineaOrdenVenta> listarBusqueda(int idOrdenVenta) {
        ArrayList<LineaOrdenVenta> lineasOrdenVenta = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LINEA_ORDEN_VENTA_BUSQUEDA(?)}");
            cs.setInt("_id_ordenVenta",idOrdenVenta);
            rs = cs.executeQuery();
            while (rs.next()) {
                LineaOrdenVenta lineaOrdenVenta = new LineaOrdenVenta();
                lineaOrdenVenta.setIdLineaOrdenVenta(rs.getInt("id_lineaOrdenVenta"));
                lineaOrdenVenta.setSubtotal(rs.getDouble("subtotal"));
                lineaOrdenVenta.setFechaRegistro(rs.getDate("fecha_registro"));
                lineaOrdenVenta.setDescuento(rs.getDouble("descuento"));
                lineaOrdenVenta.setMontoDescontado(rs.getDouble("monto_descontado"));
                lineaOrdenVenta.setCantidadVendida(rs.getInt("cantidadVenta"));

                lineaOrdenVenta.setItemVenta(new ItemVenta());
                lineaOrdenVenta.getItemVenta().setIdItemVenta(rs.getInt("idItem"));
                lineaOrdenVenta.getItemVenta().setNombre(rs.getString("nombreItem"));
                lineaOrdenVenta.getItemVenta().setPrecio( rs.getDouble("precioItem") );

                lineaOrdenVenta.setOrdenVenta(new OrdenVenta());
                lineaOrdenVenta.getOrdenVenta().setIdOrdenVenta(rs.getInt("fid_ordenVenta"));
                lineasOrdenVenta.add(lineaOrdenVenta);
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
        return lineasOrdenVenta;
    }

}
