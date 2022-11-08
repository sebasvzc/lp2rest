package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.MeseroDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;


public class MeseroMySQL implements MeseroDAO{
    
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Mesero mesero) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_MESERO(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_mesero", java.sql.Types.INTEGER);
            cs.setString("_email", mesero.getEmail());
            cs.setString("_direccion", mesero.getDireccion());
            cs.setString("_telefono", mesero.getTelefono());
            cs.setString("_nombres", mesero.getNombre());
            cs.setString("_apellidos", mesero.getApellidoPaterno());
            cs.setString("_DNI", mesero.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(mesero.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", mesero.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(mesero.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", mesero.getNumeroHorasMensuales());
            cs.executeUpdate(); 
            mesero.setIdPersona(cs.getInt("_id_mesero"));
            resultado = mesero.getIdPersona();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Mesero mesero) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_MESERO(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_mesero", mesero.getIdPersona());
            cs.setString("_email", mesero.getEmail());
            cs.setString("_direccion", mesero.getDireccion());
            cs.setString("_telefono", mesero.getTelefono());
            cs.setString("_nombres", mesero.getNombre());
            cs.setString("_apellidos", mesero.getApellidoPaterno());
            cs.setString("_DNI", mesero.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(mesero.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", mesero.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(mesero.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", mesero.getNumeroHorasMensuales());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idMesero) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_MESERO(?)}");
            cs.setInt("_id_mesero", idMesero);            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Mesero> listarTodas() {
        ArrayList<Mesero> meseros = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_MESEROS()");
            rs = cs.executeQuery();
            while(rs.next()){
                Mesero mesero = new Mesero();
                mesero.setIdPersona(rs.getInt("id_persona"));
                mesero.setNombre(rs.getString("nombres"));
                mesero.setApellidoPaterno(rs.getString("apellidos"));
                mesero.setDNI(rs.getString("DNI"));
                mesero.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                mesero.setEmail(rs.getString("email"));
                mesero.setDireccion(rs.getString("direccion"));
                mesero.setTelefono(rs.getString("telefono"));
                mesero.setSueldo(rs.getDouble("sueldo"));
                mesero.setFechaContratacion(rs.getDate("fecha_contratacion"));
                mesero.setNumeroHorasMensuales(rs.getInt("numero_horas_mensuales"));
                meseros.add(mesero);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return meseros;
    }
}
