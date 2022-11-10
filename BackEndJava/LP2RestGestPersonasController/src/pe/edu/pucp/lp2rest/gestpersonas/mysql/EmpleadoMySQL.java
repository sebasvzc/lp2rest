/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.EmpleadoDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Administrador;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cajero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Chef;
import pe.edu.pucp.lp2rest.gestpersonas.model.Empleado;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Recepcionista;

/**
 *
 * @author Usuario
 */
public class EmpleadoMySQL implements EmpleadoDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public ArrayList<Empleado> listarTodos() {
        ArrayList<Empleado> lsEmpleados = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_EMPLEADOS()");
            rs = cs.executeQuery();
            String cargoEmp;
            while(rs.next()){
                Empleado auxEmp;
                cargoEmp = rs.getString("cargoEmpleado");
                switch(cargoEmp){
                    case "Administrador":
                        auxEmp = new Administrador();
                        Administrador auxAdmin = (Administrador)auxEmp;
                        auxAdmin.setActivo(true);
                        break;
                    case "Recepcionista":
                        auxEmp = new Recepcionista();
                        break;
                    case "Chef":
                        auxEmp = new Chef();
                        break;
                    case "Cajero":
                        auxEmp = new Cajero();
                        break;
                    case "Mesero":
                        auxEmp = new Mesero();
                        break;                     
                    default:
                        auxEmp = new Empleado();
                        break;
                }
                
                auxEmp.setIdPersona(rs.getInt("idEmpleado"));
                auxEmp.setEmail(rs.getString("emailEmpleado"));
                auxEmp.setDireccion(rs.getString("direccionEmpleado"));
                auxEmp.setTelefono(rs.getString("telefonoEmpleado"));
                auxEmp.setNombre(rs.getString("nombreEmpleado"));
                auxEmp.setApellidoPaterno(rs.getString("apellidosEmpleado"));
                auxEmp.setDNI(rs.getString("DNI"));
                auxEmp.setFechaNacimiento(rs.getDate("fechanempleado"));
                auxEmp.setSueldo(rs.getDouble("sueldoEmpleado"));
                auxEmp.setFechaContratacion(rs.getDate("fechacempleado"));
                auxEmp.setNumeroHorasMensuales(rs.getInt("horasmensualesEmpleado"));
              
                
                lsEmpleados.add(auxEmp);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lsEmpleados;
        //throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public ArrayList<Empleado> listarBusqueda(String nombre, String apellido, String dni, String cargo, Date fechaIni, Date fechaFin, double sueldoIni, double sueldoFin) {
        ArrayList<Empleado> lsEmpleados = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_BUSQUEDA_EMPLEADOS(?,?,?,?,?,?,?,?)");
            
            cs.setString("_nombres", nombre);
            cs.setString("_apellidos", apellido);
            
            cs.setString("_dni", dni);
            cs.setString("_cargo", cargo);
            
            cs.setDate("_fechaIni", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_fechaFin", new java.sql.Date(fechaFin.getTime()));
            
            cs.setDouble("_sueldoIni", sueldoIni);
            cs.setDouble("_sueldoFin", sueldoFin);
            
            rs = cs.executeQuery();
            String cargoEmp;
            while(rs.next()){
                Empleado auxEmp;
                cargoEmp = rs.getString("cargoEmpleado");
                switch(cargoEmp){
                    case "Administrador":
                        auxEmp = new Administrador();
                        break;
                    case "Recepcionista":
                        auxEmp = new Recepcionista();
                        break;
                    case "Chef":
                        auxEmp = new Chef();
                        break;
                    case "Cajero":
                        auxEmp = new Cajero();
                        break;
                    case "Mesero":
                        auxEmp = new Mesero();
                        break;                     
                    default:
                        auxEmp = new Empleado();
                        break;
                }
                
                auxEmp.setIdPersona(rs.getInt("idEmpleado"));
                auxEmp.setEmail(rs.getString("emailEmpleado"));
                auxEmp.setDireccion(rs.getString("direccionEmpleado"));
                auxEmp.setTelefono(rs.getString("telefonoEmpleado"));
                auxEmp.setNombre(rs.getString("nombreEmpleado"));
                auxEmp.setApellidoPaterno(rs.getString("apellidosEmpleado"));
                auxEmp.setDNI(rs.getString("DNI"));
                auxEmp.setFechaNacimiento(rs.getDate("fechanempleado"));
                auxEmp.setSueldo(rs.getDouble("sueldoEmpleado"));
                auxEmp.setFechaContratacion(rs.getDate("fechacempleado"));
                auxEmp.setNumeroHorasMensuales(rs.getInt("horasmensualesEmpleado"));
              
                
                lsEmpleados.add(auxEmp);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lsEmpleados;
        //throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
}
