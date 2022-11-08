/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2rest.menu.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.menu.model.ItemVenta;
        
/**
 *
 * @author sebas
 */
public interface ItemVentaDAO {
    int insertar(ItemVenta itemVenta);
    int modificar (ItemVenta itemVenta);
    int eliminar(int idItemVenta);
    ArrayList<ItemVenta> listarTodos();
}
