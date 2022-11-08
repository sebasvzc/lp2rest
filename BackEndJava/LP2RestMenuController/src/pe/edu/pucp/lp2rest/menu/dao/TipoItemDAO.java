/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2rest.menu.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.menu.model.TipoItem;

/**
 *
 * @author sebas
 */
public interface TipoItemDAO {
    int insertar(TipoItem tipoItem);
    int modificar (TipoItem tipoItem);
    int eliminar(int idTipoItem);
    ArrayList<TipoItem> listarTodos();
}
