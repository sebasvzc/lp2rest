
package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;
import pe.edu.pucp.lp2rest.gestpersonas.model.CuentaUsuario;


public interface CuentaUsuarioDAO {
    int insertar(CuentaUsuario cuentaUsuario);
    int modificar(CuentaUsuario cuentaUsuario);
    int eliminar(int idCuentaUsuario);
    ArrayList<CuentaUsuario> listarTodas();
}
