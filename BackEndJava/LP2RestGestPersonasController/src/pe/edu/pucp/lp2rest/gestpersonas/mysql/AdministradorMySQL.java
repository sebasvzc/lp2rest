package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.AdministradorDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Administrador;

public class AdministradorMySQL implements AdministradorDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Administrador administrador) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ADMINISTRADOR(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_administrador", java.sql.Types.INTEGER);
            cs.setString("_email", administrador.getEmail());
            cs.setString("_direccion", administrador.getDireccion());
            cs.setString("_telefono", administrador.getTelefono());
            cs.setString("_nombres", administrador.getNombre());
            cs.setString("_apellidos", administrador.getApellidoPaterno());
            cs.setString("_DNI", administrador.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(administrador.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", administrador.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(administrador.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", administrador.getNumeroHorasMensuales());
            //
            if (administrador.getFoto() != null) {
                cs.setBytes("_foto", administrador.getFoto());
            } else {
                cs.setBytes("_foto", null);
            }
            if (administrador.getArchivoCv() != null) {
                cs.setBytes("_archivo_cv", administrador.getArchivoCv());
            } else {
                cs.setBytes("_archivo_cv", null);
            }
            //
            cs.executeUpdate();
            administrador.setIdPersona(cs.getInt("_id_administrador"));
            resultado = administrador.getIdPersona();
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
    public int modificar(Administrador administrador) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ADMINISTRADOR(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_administrador", administrador.getIdPersona());
            cs.setString("_email", administrador.getEmail());
            cs.setString("_direccion", administrador.getDireccion());
            cs.setString("_telefono", administrador.getTelefono());
            cs.setString("_nombres", administrador.getNombre());
            cs.setString("_apellidos", administrador.getApellidoPaterno());
            cs.setString("_DNI", administrador.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(administrador.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", administrador.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(administrador.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", administrador.getNumeroHorasMensuales());
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
    public int eliminar(int idAdministrador) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ADMINISTRADOR(?)}");
            cs.setInt("_id_administrador", idAdministrador);
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
    public ArrayList<Administrador> listarTodas() {
        ArrayList<Administrador> administradores = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_ADMINISTRADORES()");
            rs = cs.executeQuery();
            while (rs.next()) {
                Administrador administrador = new Administrador();
                administrador.setIdPersona(rs.getInt("id_persona"));
                administrador.setNombre(rs.getString("nombres"));
                administrador.setApellidoPaterno(rs.getString("apellidos"));
                administrador.setDNI(rs.getString("DNI"));
                administrador.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                administrador.setEmail(rs.getString("email"));
                administrador.setDireccion(rs.getString("direccion"));
                administrador.setTelefono(rs.getString("telefono"));
                administrador.setSueldo(rs.getDouble("sueldo"));
                administrador.setFechaContratacion(rs.getDate("fecha_contratacion"));
                administrador.setNumeroHorasMensuales(rs.getInt("numero_horas_mensuales"));
                administradores.add(administrador);
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
        return administradores;
    }

}
