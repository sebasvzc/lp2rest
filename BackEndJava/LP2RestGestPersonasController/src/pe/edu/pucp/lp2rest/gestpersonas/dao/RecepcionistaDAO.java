package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Recepcionista;


public interface RecepcionistaDAO {
    int insertar(Recepcionista recepcionista);
    int modificar(Recepcionista recepcionista);
    int eliminar(int idRecepcionista);
    ArrayList<Recepcionista> listarTodas();
}
