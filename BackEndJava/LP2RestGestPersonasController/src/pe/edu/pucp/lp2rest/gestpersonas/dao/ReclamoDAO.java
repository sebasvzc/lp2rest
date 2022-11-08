/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.Date;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Reclamo;

/**
 *
 * @author Usuario
 */
public interface ReclamoDAO {
    int insertar(Reclamo reclamo);
    int modificar(Reclamo reclamo);
    int eliminar(Reclamo reclamo);

    ArrayList<Reclamo> listarTodas();
    ArrayList<Reclamo> listarBusqueda(  String cliNombre, String cliApellido, 
                                        String empNombre, String empApellido,
                                        String adminNombre, String adminApellido,
                                        Date fechaIni, Date fechaFin,
                                        int estadoBuscado );
}
