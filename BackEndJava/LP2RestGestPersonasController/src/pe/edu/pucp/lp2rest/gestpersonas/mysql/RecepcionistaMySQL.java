package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.RecepcionistaDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Recepcionista;

public class RecepcionistaMySQL implements RecepcionistaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Recepcionista recepcionista) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_RECEPCIONISTA(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_recepcionista", java.sql.Types.INTEGER);
            cs.setString("_email", recepcionista.getEmail());
            cs.setString("_direccion", recepcionista.getDireccion());
            cs.setString("_telefono", recepcionista.getTelefono());
            cs.setString("_nombres", recepcionista.getNombre());
            cs.setString("_apellidos", recepcionista.getApellidoPaterno());
            cs.setString("_DNI", recepcionista.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(recepcionista.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", recepcionista.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(recepcionista.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", recepcionista.getNumeroHorasMensuales());
            //
            if (recepcionista.getFoto() != null) {
                cs.setBytes("_foto", recepcionista.getFoto());
            } else {
                cs.setBytes("_foto", null);
            }
            if (recepcionista.getArchivoCv() != null) {
                cs.setBytes("_archivo_cv", recepcionista.getArchivoCv());
            } else {
                cs.setBytes("_archivo_cv", null);
            }
            //
            cs.executeUpdate();
            recepcionista.setIdPersona(cs.getInt("_id_recepcionista"));
            resultado = recepcionista.getIdPersona();
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
    public int modificar(Recepcionista recepcionista) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_RECEPCIONISTA(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_recepcionista", recepcionista.getIdPersona());
            cs.setString("_email", recepcionista.getEmail());
            cs.setString("_direccion", recepcionista.getDireccion());
            cs.setString("_telefono", recepcionista.getTelefono());
            cs.setString("_nombres", recepcionista.getNombre());
            cs.setString("_apellidos", recepcionista.getApellidoPaterno());
            cs.setString("_DNI", recepcionista.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(recepcionista.getFechaNacimiento().getTime()));
            cs.setDouble("_sueldo", recepcionista.getSueldo());
            cs.setDate("_fecha_contratacion", new java.sql.Date(recepcionista.getFechaContratacion().getTime()));
            cs.setInt("_numero_horas_mensuales", recepcionista.getNumeroHorasMensuales());
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
    public int eliminar(int idRecepcionista) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_RECEPCIONISTA(?)}");
            cs.setInt("_id_recepcionista", idRecepcionista);
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
    public ArrayList<Recepcionista> listarTodas() {
        ArrayList<Recepcionista> recepcionistas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_RECEPCIONISTAS()");
            rs = cs.executeQuery();
            while (rs.next()) {
                Recepcionista recepcionista = new Recepcionista();
                recepcionista.setIdPersona(rs.getInt("id_persona"));
                recepcionista.setNombre(rs.getString("nombres"));
                recepcionista.setApellidoPaterno(rs.getString("apellidos"));
                recepcionista.setDNI(rs.getString("DNI"));
                recepcionista.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                recepcionista.setEmail(rs.getString("email"));
                recepcionista.setDireccion(rs.getString("direccion"));
                recepcionista.setTelefono(rs.getString("telefono"));
                recepcionista.setSueldo(rs.getDouble("sueldo"));
                recepcionista.setFechaContratacion(rs.getDate("fecha_contratacion"));
                recepcionista.setNumeroHorasMensuales(rs.getInt("numero_horas_mensuales"));
                recepcionistas.add(recepcionista);
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
        return recepcionistas;
    }

}
