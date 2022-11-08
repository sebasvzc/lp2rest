package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cajero;


public interface CajeroDAO {
    int insertar(Cajero cajero);
    int modificar(Cajero cajero);
    int eliminar(int idCajero);
    ArrayList<Cajero> listarTodas();
}
