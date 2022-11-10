
package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;
import pe.edu.pucp.lp2rest.gestpersonas.model.CuentaUsuario;


public interface CuentaUsuarioDAO {
    int insertar(CuentaUsuario cuentaUsuario);
    int modificar(CuentaUsuario cuentaUsuario);
    int eliminar(int idCuentaUsuario);
    ArrayList<CuentaUsuario> listarTodas();
    CuentaUsuario verificar(CuentaUsuario cuentaUsuario);
    int enviarCorreoRecuperacion(String correo);
    int verificarCodigoVerificacion(int idCuentaUsuario, String codigo);
    int actualizarContrasenia(int idCuentaUsuario, String contrasenia);
}
