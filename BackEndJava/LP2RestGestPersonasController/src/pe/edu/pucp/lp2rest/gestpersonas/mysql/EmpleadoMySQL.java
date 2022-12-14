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
public class EmpleadoMySQL implements EmpleadoDAO {
    
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public ArrayList<Empleado> listarTodos() {
        ArrayList<Empleado> lsEmpleados = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_EMPLEADOS()");
            rs = cs.executeQuery();
            String cargoEmp;
            while (rs.next()) {
                Empleado auxEmp;
                cargoEmp = rs.getString("cargoEmpleado");
                switch (cargoEmp) {
                    case "Administrador":
                        auxEmp = new Administrador();
                        Administrador auxAdmin = (Administrador) auxEmp;
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
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return lsEmpleados;
        //throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
    @Override
    public ArrayList<Empleado> listarBusqueda(String nombre, String apellido, String dni, String cargo, Date fechaIni, Date fechaFin, double sueldoIni, double sueldoFin) {
        ArrayList<Empleado> lsEmpleados = new ArrayList<>();
        try {
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
            while (rs.next()) {
                Empleado auxEmp;
                cargoEmp = rs.getString("cargoEmpleado");
                switch (cargoEmp) {
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

                //Modificacion para agregar retorno de foto y archivoCV 21/11/2022 16:13
                auxEmp.setFoto(rs.getBytes("fotoEmpleado"));
                auxEmp.setArchivoCv(rs.getBytes("archivoCvEmpleado"));
                //
                lsEmpleados.add(auxEmp);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return lsEmpleados;
        //throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
    @Override
    public ArrayList<Empleado> listarPorNombre(String nombre) {
        
        ArrayList<Empleado> lsEmpleados = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_EMPLEADOS_X_NOMBRE(?)");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            String cargoEmp;
            while (rs.next()) {
                Empleado auxEmp;
                cargoEmp = rs.getString("cargoEmpleado");
                switch (cargoEmp) {
                    case "Administrador":
                        auxEmp = new Administrador();
                        Administrador auxAdmin = (Administrador) auxEmp;
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
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return lsEmpleados;
        
    }
    
    @Override
    public Empleado buscarXidCuentaUsuario(int  idCuentaUsuario){
        Empleado empleado = new Empleado();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call BUSCAR_EMPLEADO_X_IDCUENTAUSUARIO(?)");
            cs.setInt("_id_cuentaUsuario", idCuentaUsuario);
            rs = cs.executeQuery();
            while(rs.next()){
                empleado.setIdPersona(rs.getInt("idEmpleado"));
                empleado.setEmail(rs.getString("emailEmpleado"));
                empleado.setDireccion(rs.getString("direccionEmpleado"));
                empleado.setTelefono(rs.getString("telefonoEmpleado"));
                empleado.setNombre(rs.getString("nombres"));
                empleado.setApellidoPaterno(rs.getString("apellidos"));
                empleado.setDNI(rs.getString("DNI"));
                empleado.setFechaNacimiento(rs.getDate("fechanempleado"));
                empleado.setSueldo(rs.getDouble("sueldoEmpleado"));
                empleado.setFechaContratacion(rs.getDate("fechacempleado"));
                empleado.setNumeroHorasMensuales(rs.getInt("horasmensualesEmpleado"));
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return empleado;
    }

    @Override
    public Empleado obtener(int idEmpleado) {
        //throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
        Empleado resultado = null;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call BUSCAR_EMPLEADO_X_IDPERSONA(?)");
            cs.setInt("_id_persona", idEmpleado);
            rs = cs.executeQuery();
            String cargoEmp;
            while(rs.next()){
                Empleado auxEmp;
                cargoEmp = rs.getString("tipoEmpleado");
                switch(cargoEmp){
                    case "A":
                        auxEmp = new Administrador();
                         break;
                    case "R":
                        auxEmp = new Recepcionista();
                        break;
                    case "F":
                        auxEmp = new Chef();
                        break;
                    case "C":
                        auxEmp = new Cajero();
                        break;
                    case "M":
                        auxEmp = new Mesero();
                        break;  
                    default:
                        auxEmp = new Empleado();
                        break;
                }
                
                auxEmp.setIdPersona(rs.getInt("idEmpleado"));
                auxEmp.setNombre(rs.getString("nombres"));
                auxEmp.setApellidoPaterno(rs.getString("apellidos"));
                auxEmp.setDNI(rs.getString("DNI"));
              
                
                resultado = auxEmp;
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
