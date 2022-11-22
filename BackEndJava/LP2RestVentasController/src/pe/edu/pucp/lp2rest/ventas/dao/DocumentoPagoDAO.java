package pe.edu.pucp.lp2rest.ventas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.ventas.model.DocumentoPago;

/**
 *
 * @author Gerard
 */
public interface DocumentoPagoDAO {
    int insertar(DocumentoPago documentoPago);
    int modificar (DocumentoPago documentoPago);
    int eliminar(int idDocumentoPago);
    ArrayList<DocumentoPago> listarTodos();
    DocumentoPago obtener(int idDoc);
}
