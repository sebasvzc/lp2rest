package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Administrador;

public interface AdministradorDAO {
    int insertar(Administrador administrador);
    int modificar(Administrador administrador);
    int eliminar(int idAdministrador);
    ArrayList<Administrador> listarTodas();
}
