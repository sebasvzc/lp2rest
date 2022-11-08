package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Chef;

public interface ChefDAO {
    int insertar(Chef chef);
    int modificar(Chef chef);
    int eliminar(int idChef);
    ArrayList<Chef> listarTodas();
}
