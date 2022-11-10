/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.lang.ProcessBuilder.Redirect.Type;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;

import java.sql.ResultSet;
import java.sql.Types;
import java.util.ArrayList;
//import java.util.Date;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ReclamoDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Administrador;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;
import pe.edu.pucp.lp2rest.gestpersonas.model.Empleado;

import pe.edu.pucp.lp2rest.gestpersonas.model.Reclamo;

/**
 *
 * @author Usuario
 */
public class ReclamoMySQL implements ReclamoDAO{
    
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Reclamo reclamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            
            cs = con.prepareCall("{call INSERTAR_RECLAMO(?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_id_reclamo", java.sql.Types.INTEGER);
            
            if(reclamo.getCliente() == null)
                cs.setNull("_cliente", Types.NULL);
            else
                cs.setInt("_cliente", reclamo.getCliente().getIdPersona());
            
            if(reclamo.getAdministrador()== null)
                cs.setNull("_admin", Types.NULL);
            else
                cs.setInt("_admin", reclamo.getAdministrador().getIdPersona());
            
            if(reclamo.getEmpleado()== null)
                cs.setNull("_empleado", Types.NULL);
            else
                cs.setInt("_empleado", reclamo.getEmpleado().getIdPersona());
            
            cs.setString("_descripcion", reclamo.getDescripcion());
            cs.setDate("_fechaRegistro", new java.sql.Date(reclamo.getFechaRegistro().getTime()));
            
            cs.executeUpdate();
            
            reclamo.setId(cs.getInt("_id_reclamo"));
            resultado = reclamo.getId();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Reclamo reclamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_RECLAMO(?,?,?,?,?,?,?,?,?,?)}");
                        
            cs.setInt("_idReclamo", reclamo.getId());
            
            if(reclamo.getCliente() == null) cs.setNull("_cliente", Types.NULL);
            else cs.setInt("_cliente", reclamo.getCliente().getIdPersona());
            
            if(reclamo.getAdministrador()== null) cs.setNull("_admin", Types.NULL);
            else cs.setInt("_admin", reclamo.getAdministrador().getIdPersona());
            
            if(reclamo.getEmpleado()== null) cs.setNull("_empleado", Types.NULL);
            else cs.setInt("_empleado", reclamo.getEmpleado().getIdPersona());
            

            cs.setString("_descripcion", reclamo.getDescripcion());
            cs.setBoolean("_estado", reclamo.isEstado());
            cs.setDate("_fechaRegistro", new java.sql.Date(reclamo.getFechaRegistro().getTime()));
            cs.setDate("_fechaAtencion", new java.sql.Date(reclamo.getFechaAtencion().getTime()));
            cs.setString("_observacion", reclamo.getObservacion());
            cs.setBoolean("_activo", true);
            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(Reclamo reclamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_RECLAMO(?)}");
            cs.setInt("_idReclamo", reclamo.getId());            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Reclamo> listarTodas() {
        ArrayList<Reclamo> listaReclamos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_RECLAMOS()");
            rs = cs.executeQuery();
            while(rs.next()){
                
                Reclamo nuReclamo = new Reclamo();
                
                nuReclamo.setCliente(new Cliente());
                nuReclamo.setAdministrador(new Administrador());
                nuReclamo.setEmpleado(new Empleado());
                
                nuReclamo.setId(rs.getInt("id_reclamo"));
                
                nuReclamo.getAdministrador().setIdPersona(rs.getInt("fid_admin"));
                nuReclamo.getAdministrador().setNombre(rs.getString("nombresAdmin"));
                nuReclamo.getAdministrador().setApellidoPaterno(rs.getString("apellidosAdmin"));
                
                nuReclamo.getCliente().setIdPersona(rs.getInt("fid_cliente"));
                nuReclamo.getCliente().setNombre(rs.getString("nombresAdmin"));
                nuReclamo.getCliente().setApellidoPaterno(rs.getString("apellidosAdmin"));
                nuReclamo.getCliente().setDNI(rs.getString("dniCliente"));
                nuReclamo.getCliente().setTelefono(rs.getString("telefonoCliente"));
                
                nuReclamo.getEmpleado().setIdPersona(rs.getInt("fid_empleado"));
                nuReclamo.getEmpleado().setNombre(rs.getString("nombresEmpleado"));
                nuReclamo.getEmpleado().setApellidoPaterno(rs.getString("apellidosEmpleado"));
                nuReclamo.getEmpleado().setDNI(rs.getString("dniEmpleado"));
                nuReclamo.getEmpleado().setTelefono(rs.getString("telefonoEmpleado"));
                
                nuReclamo.setDescripcion(rs.getString("descripcion"));
                nuReclamo.setEstado(rs.getBoolean("estado"));
                nuReclamo.setFechaRegistro(rs.getDate("fecha_registro"));
                nuReclamo.setFechaAtencion(rs.getDate("fecha_registro"));
                nuReclamo.setObservacion(rs.getString("observacion"));
                
                listaReclamos.add(nuReclamo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return listaReclamos;
    }

    @Override
    public ArrayList<Reclamo> listarBusqueda(String cliNombre, String cliApellido, String empNombre, String empApellido, String adminNombre, String adminApellido, java.util.Date fechaIni, java.util.Date fechaFin, int estadoBuscado) {
        ArrayList<Reclamo> listaReclamos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BUSQUEDA_RECLAMOS(?,?,?,?,?,?,?,?,?)}");
            
            cs.setString("_cliNom", cliNombre);
            cs.setString("_cliApe", cliApellido);
            
            cs.setString("_empNom", empNombre);
            cs.setString("_empApe", empApellido);
            
            cs.setString("_adminNom", cliNombre);
            cs.setString("_adminApe", cliApellido);
            
            
            cs.setDate("_fechaIni", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_fechaFin", new java.sql.Date(fechaFin.getTime()));
            
            
            
            if(estadoBuscado == 0) cs.setBoolean("_estado", false);
            if(estadoBuscado == 1) cs.setBoolean("_estado", true);
            if(estadoBuscado == 3) cs.setNull("_estado", Types.NULL); 
                      
            
            
            rs = cs.executeQuery();
            while(rs.next()){
                
                Reclamo nuReclamo = new Reclamo();
                
                nuReclamo.setCliente(new Cliente());
                nuReclamo.setAdministrador(new Administrador());
                nuReclamo.setEmpleado(new Empleado());
                
                nuReclamo.setId(rs.getInt("id_reclamo"));
                
                nuReclamo.getAdministrador().setIdPersona(rs.getInt("fid_admin"));
                nuReclamo.getAdministrador().setNombre(rs.getString("nombresAdmin"));
                nuReclamo.getAdministrador().setApellidoPaterno(rs.getString("apellidosAdmin"));
                
                nuReclamo.getCliente().setIdPersona(rs.getInt("fid_cliente"));
                nuReclamo.getCliente().setNombre(rs.getString("nombresAdmin"));
                nuReclamo.getCliente().setApellidoPaterno(rs.getString("apellidosAdmin"));
                nuReclamo.getCliente().setDNI(rs.getString("dniCliente"));
                nuReclamo.getCliente().setTelefono(rs.getString("telefonoCliente"));
                
                nuReclamo.getEmpleado().setIdPersona(rs.getInt("fid_empleado"));
                nuReclamo.getEmpleado().setNombre(rs.getString("nombresEmpleado"));
                nuReclamo.getEmpleado().setApellidoPaterno(rs.getString("apellidosEmpleado"));
                nuReclamo.getEmpleado().setDNI(rs.getString("dniEmpleado"));
                nuReclamo.getEmpleado().setTelefono(rs.getString("telefonoEmpleado"));
                
                nuReclamo.setDescripcion(rs.getString("descripcion"));
                nuReclamo.setEstado(rs.getBoolean("estado"));
                nuReclamo.setFechaRegistro(rs.getDate("fecha_registro"));
                nuReclamo.setFechaAtencion(rs.getDate("fecha_registro"));
                nuReclamo.setObservacion(rs.getString("observacion"));
                
                listaReclamos.add(nuReclamo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return listaReclamos;
    }
    
}
