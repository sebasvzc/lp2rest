package pe.edu.pucp.lp2rest.almacen.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.almacen.model.TipoProducto;


public interface TipoProductoDAO {
    int insertar(TipoProducto tipo);
    int modificar (TipoProducto tipo);
    int eliminar(int idTipo);
    ArrayList<TipoProducto> listarTodos();
}