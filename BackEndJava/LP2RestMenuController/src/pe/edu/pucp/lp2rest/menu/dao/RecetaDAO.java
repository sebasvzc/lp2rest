package pe.edu.pucp.lp2rest.menu.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.menu.model.Receta;

public interface RecetaDAO {
    int insertar(Receta receta);
    int modificar (Receta receta);
    int eliminar(int idReceta);
    ArrayList<Receta> listarTodos();
}
