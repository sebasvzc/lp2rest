/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Asistencia;

/**
 *
 * @author Gonzalo
 */
public interface AsistenciaDAO {
    int insertarAsistencia(Asistencia asistencia);
    int modificarAsistencia(int id_asistencia, String fecha_fin,
            String hora_fin);
    int eliminarAsistencia(int idArtista);
    ArrayList<Asistencia> listarTodasAsistencias();
}
