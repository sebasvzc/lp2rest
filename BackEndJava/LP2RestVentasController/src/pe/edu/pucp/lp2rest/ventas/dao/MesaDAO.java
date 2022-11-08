package pe.edu.pucp.lp2rest.ventas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.ventas.model.Mesa;

/**
 *
 * @author Gerard
 */
public interface MesaDAO {
    int insertar(Mesa mesa);
    int modificar (Mesa mesa);
    int eliminar(int idMesa);
    ArrayList<Mesa> listarTodos();
}
