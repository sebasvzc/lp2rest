/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2rest.gestpersonas.model.Empleado;

/**
 *
 * @author Usuario
 */
public interface EmpleadoDAO {
    
    ArrayList<Empleado> listarTodos();  
    ArrayList<Empleado> listarPorNombre(String nombre);  
    ArrayList<Empleado> listarBusqueda( String nombre, 
                                        String apellido, 
                                        String dni, 
                                        String cargo, 
                                        Date fechaIni, 
                                        Date fechaFin,
                                        double sueldoIni, 
                                        double sueldoFin );
    Empleado obtener(int idCuenta);
    Empleado buscarXidCuentaUsuario(int  idCuentaUsuario);
}
