package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ChefDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Chef;

public class ChefMySQL implements ChefDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Chef chef) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CHEF(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_chef", java.sql.Types.INTEGER);
            cs.setString("_email", chef.getEmail());
            cs.setString("_direccion", chef.getDireccion());
            cs.setString("_telefono", chef.getTelefono());
            cs.setString("_nombres", chef.getNombre());
            cs.setString("_apellidos", chef.getApellidoPaterno());
            cs.setString("_DNI", chef.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(chef.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", chef.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(chef.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", chef.getNumeroHorasMensuales());
            cs.setString("_especialidad", chef.getEspecialidad());
            //
            if (chef.getFoto() != null) {
                cs.setBytes("_foto", chef.getFoto());
            } else {
                cs.setBytes("_foto", null);
            }
            if (chef.getArchivoCv() != null) {
                cs.setBytes("_archivo_cv", chef.getArchivoCv());
            } else {
                cs.setBytes("_archivo_cv", null);
            }
            //
            cs.executeUpdate();
            chef.setIdPersona(cs.getInt("_id_chef"));
            resultado = chef.getIdPersona();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Chef chef) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CHEF(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_chef", chef.getIdPersona());
            cs.setString("_email", chef.getEmail());
            cs.setString("_direccion", chef.getDireccion());
            cs.setString("_telefono", chef.getTelefono());
            cs.setString("_nombres", chef.getNombre());
            cs.setString("_apellidos", chef.getApellidoPaterno());
            cs.setString("_DNI", chef.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(chef.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", chef.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(chef.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", chef.getNumeroHorasMensuales());
            cs.setString("_especialidad", chef.getEspecialidad());
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idChef) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CHEF(?)}");
            cs.setInt("_id_chef", idChef);
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Chef> listarTodas() {
        ArrayList<Chef> chefs = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_CHEFS()");
            rs = cs.executeQuery();
            while (rs.next()) {
                Chef chef = new Chef();
                chef.setIdPersona(rs.getInt("id_persona"));
                chef.setNombre(rs.getString("nombres"));
                chef.setApellidoPaterno(rs.getString("apellidos"));
                chef.setDNI(rs.getString("DNI"));
                chef.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                chef.setEmail(rs.getString("email"));
                chef.setDireccion(rs.getString("direccion"));
                chef.setTelefono(rs.getString("telefono"));
                chef.setSueldo(rs.getDouble("sueldo"));
                chef.setFechaContratacion(rs.getDate("fecha_contratacion"));
                chef.setNumeroHorasMensuales(rs.getInt("numero_horas_mensuales"));
                chef.setEspecialidad(rs.getString("especialidad"));
                chefs.add(chef);
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
        return chefs;
    }

}
