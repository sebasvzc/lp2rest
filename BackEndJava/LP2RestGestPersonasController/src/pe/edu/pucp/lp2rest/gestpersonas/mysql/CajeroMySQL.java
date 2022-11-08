package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.CajeroDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cajero;

public class CajeroMySQL implements CajeroDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Cajero cajero) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CAJERO(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_cajero", java.sql.Types.INTEGER);
            cs.setString("_email", cajero.getEmail());
            cs.setString("_direccion", cajero.getDireccion());
            cs.setString("_telefono", cajero.getTelefono());
            cs.setString("_nombres", cajero.getNombre());
            cs.setString("_apellidos", cajero.getApellidoPaterno());
            cs.setString("_DNI", cajero.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(cajero.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", cajero.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(cajero.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", cajero.getNumeroHorasMensuales());
            cs.setInt("_nroCaja", cajero.getNroCaja());
            cs.executeUpdate(); 
            cajero.setIdPersona(cs.getInt("_id_cajero"));
            resultado = cajero.getIdPersona();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Cajero cajero) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CAJERO(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_cajero", cajero.getIdPersona());
            cs.setString("_email", cajero.getEmail());
            cs.setString("_direccion", cajero.getDireccion());
            cs.setString("_telefono", cajero.getTelefono());
            cs.setString("_nombres", cajero.getNombre());
            cs.setString("_apellidos", cajero.getApellidoPaterno());
            cs.setString("_DNI", cajero.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(cajero.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", cajero.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(cajero.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", cajero.getNumeroHorasMensuales());
            cs.setInt("_nroCaja", cajero.getNroCaja());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idCajero) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CAJERO(?)}");
            cs.setInt("_id_cajero", idCajero);            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Cajero> listarTodas() {
        ArrayList<Cajero> cajeros = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_CLIENTES()");
            rs = cs.executeQuery();
            while(rs.next()){
                Cajero cajero = new Cajero();
                cajero.setIdPersona(rs.getInt("id_persona"));
                cajero.setNombre(rs.getString("nombres"));
                cajero.setApellidoPaterno(rs.getString("apellidos"));
                cajero.setDNI(rs.getString("DNI"));
                cajero.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                cajero.setEmail(rs.getString("email"));
                cajero.setDireccion(rs.getString("direccion"));
                cajero.setTelefono(rs.getString("telefono"));
                cajero.setSueldo(rs.getDouble("sueldo"));
                cajero.setFechaContratacion(rs.getDate("fecha_contratacion"));
                cajero.setNumeroHorasMensuales(rs.getInt("numero_horas_mensuales"));
                cajero.setNroCaja(rs.getInt("nroCaja"));
                cajeros.add(cajero);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return cajeros;
    }
    
}
