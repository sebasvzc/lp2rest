/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.AsistenciaDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Asistencia;

/**
 *
 * @author Gonzalo
 */
public class AsistenciaMySQL implements AsistenciaDAO{
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public int insertarAsistencia(Asistencia asistencia) {
        int resultado = 0;
        
        // Cambiar de las fechas y horas a un solo formato
        
        
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ASISTENCIA(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_asistencia", java.sql.Types.INTEGER);
            cs.setInt("_fid_cuentaUsuario", asistencia.getIdCuentaUsuario());
            cs.setString("_fecha_ingreso", asistencia.getFechaIngreso());
            cs.setString("_hora_ingreso", asistencia.getHoraIngreso());
            cs.setString("_fecha_salida", asistencia.getFechaSalida());
            cs.setString("_hora_salida", asistencia.getHoraSalida());
                
            cs.executeUpdate();
            
            resultado = cs.getInt("_id_asistencia");
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    
    @Override
    public int modificarAsistencia(int id_asistencia, String fecha_fin,
            String hora_fin) {
       int resultado = 0; 
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ASISTENCIA_SALIDA(?,?,?)}");
            cs.setInt("_id_asistencia", id_asistencia);
            cs.setString("_fecha_salida", fecha_fin);
            cs.setString("_hora_salida", hora_fin);
            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
        
    }

    @Override
    public int eliminarAsistencia(int idArtista) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public ArrayList<Asistencia> listarTodasAsistencias() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
}
