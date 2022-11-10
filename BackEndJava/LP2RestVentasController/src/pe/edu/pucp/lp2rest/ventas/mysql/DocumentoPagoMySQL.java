package pe.edu.pucp.lp2rest.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;

import pe.edu.pucp.lp2rest.ventas.dao.DocumentoPagoDAO;
import pe.edu.pucp.lp2rest.ventas.model.DocumentoPago;

/**
 *
 * @author Gerard
 */
public class DocumentoPagoMySQL implements DocumentoPagoDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(DocumentoPago documentoPago) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_DOCUMENTO_PAGO(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_documentoDePago", java.sql.Types.INTEGER);
            cs.setDouble("_total", documentoPago.getTotal());
            cs.setDouble("_igv", documentoPago.getIgv());
            cs.setString("_tipo_pago", documentoPago.getTipoPago());
            cs.setDate("fecha_emision", new java.sql.Date(documentoPago.getFechaEmision().getTime()));
            cs.setDate("_fecha_pago", new java.sql.Date(documentoPago.getFechaPago().getTime()));
            cs.setString("_ruc", documentoPago.getRuc());
            cs.setString("_razon_social", documentoPago.getRazonSocial());
            cs.setString("_serie", documentoPago.getSerie());
            cs.setInt("_numero", documentoPago.getNumero());
            cs.setDouble("_monto_recibido", documentoPago.getMontoRecibido());
            cs.setString("_metodo_pago", documentoPago.getMetodoPago());
            cs.setString("_direccion_fiscal", documentoPago.getDireccionFiscal());
            
            cs.executeUpdate();
            
            documentoPago.setIdDocumentoPago(cs.getInt("_id_documentoDePago"));
            resultado = documentoPago.getIdDocumentoPago();
            
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
    public int modificar(DocumentoPago documentoPago) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_DOCUMENTO_PAGO(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_documentoDePago", documentoPago.getIdDocumentoPago());
            cs.setDouble("_total", documentoPago.getTotal());
            cs.setDouble("_igv", documentoPago.getIgv());
            cs.setString("_tipo_pago", documentoPago.getTipoPago());
            cs.setDate("fecha_emision", new java.sql.Date(documentoPago.getFechaEmision().getTime()));
            cs.setDate("_fecha_pago", new java.sql.Date(documentoPago.getFechaPago().getTime()));
            cs.setString("_ruc", documentoPago.getRuc());
            cs.setString("_razon_social", documentoPago.getRazonSocial());
            cs.setString("_serie", documentoPago.getSerie());
            cs.setInt("_numero", documentoPago.getNumero());
            cs.setDouble("_monto_recibido", documentoPago.getMontoRecibido());
            cs.setString("_metodo_pago", documentoPago.getMetodoPago());
            cs.setString("_direccion_fiscal", documentoPago.getDireccionFiscal());
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
    public int eliminar(int idDocumentoPago) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_DOCUMENTO_PAGO(?)}");
            cs.setInt("_id_documentoDePago", idDocumentoPago);
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
    public ArrayList<DocumentoPago> listarTodos() {
        ArrayList<DocumentoPago> documentosPago = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_DOCUMENTO_PAGO()");
            rs = cs.executeQuery();
            while (rs.next()) {
                DocumentoPago documentoPago = new DocumentoPago();
                documentoPago.setIdDocumentoPago(rs.getInt("id_documentoDePago"));
                documentoPago.setTotal(rs.getDouble("total"));
                documentoPago.setIgv(rs.getDouble("igv"));
                documentoPago.setTipoPago(rs.getString("tipo_pago"));
                documentoPago.setFechaEmision(rs.getDate("fecha_emision"));
                documentoPago.setFechaPago(rs.getDate("fecha_pago"));
                documentoPago.setRuc(rs.getString("ruc"));
                documentoPago.setRazonSocial(rs.getString("razon_social"));
                documentoPago.setSerie(rs.getString("serie"));
                documentoPago.setNumero(rs.getInt("numero"));
                documentoPago.setMontoRecibido(rs.getDouble("monto_recibido"));
                documentoPago.setMetodoPago(rs.getString("metodo_pago"));
                documentoPago.setDireccionFiscal(rs.getString("direccion_fiscal"));
                documentosPago.add(documentoPago);
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
        return documentosPago;
    }
}
