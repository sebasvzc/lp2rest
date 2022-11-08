package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;


public interface MeseroDAO {
    int insertar(Mesero mesero);
    int modificar(Mesero mesero);
    int eliminar(int idMesero);
    ArrayList<Mesero> listarTodas();
}
