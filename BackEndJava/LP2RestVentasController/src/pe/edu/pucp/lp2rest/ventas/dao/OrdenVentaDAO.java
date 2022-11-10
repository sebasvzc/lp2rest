package pe.edu.pucp.lp2rest.ventas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.ventas.model.OrdenVenta;

/**
 *
 * @author Gerard
 */
public interface OrdenVentaDAO {
    int insertar(OrdenVenta ordenVenta);
    int modificar (OrdenVenta ordenVenta);
    int eliminar(int idOrdenVenta);
    ArrayList<OrdenVenta> listarTodos();
}
