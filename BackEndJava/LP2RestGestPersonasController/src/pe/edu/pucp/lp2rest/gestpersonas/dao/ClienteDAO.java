package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;


public interface ClienteDAO {
    int insertar(Cliente cliente);
    int modificar(Cliente cliente);
    int eliminar(int idCliente);
    ArrayList<Cliente> listarTodas();
    Cliente listarPorDni(String dni);
    ArrayList<Cliente> filtrarClientes(String dni,String email,String nombres,String apellidos,String telefono);
}
