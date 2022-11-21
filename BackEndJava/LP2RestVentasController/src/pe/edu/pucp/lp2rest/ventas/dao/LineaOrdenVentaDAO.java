package pe.edu.pucp.lp2rest.ventas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.ventas.model.LineaOrdenVenta;

/**
 *
 * @author Gerard
 */
public interface LineaOrdenVentaDAO {
    int insertar(LineaOrdenVenta lineaOrdenVenta);
    int modificar (LineaOrdenVenta lineaOrdenVenta);
    int eliminar(int idLineaOrdenVenta);
    ArrayList<LineaOrdenVenta> listarTodos();
    ArrayList<LineaOrdenVenta> listarLineasPorId(int idOrdenVenta);
    ArrayList<LineaOrdenVenta> listarBusqueda(int idOrdenVenta);
}
