/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2rest.menu.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.menu.model.Receta;

/**
 *
 * @author sebas
 */
public interface RecetaDAO {
    int insertar(Receta receta);
    int modificar (Receta receta);
    int eliminar(int idReceta);
    ArrayList<Receta> listarTodos();
}
