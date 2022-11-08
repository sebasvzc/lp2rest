/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2rest.menu.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.menu.model.ItemVenta;
        

public interface ItemVentaDAO {
    int insertar(ItemVenta itemVenta);
    int modificar (ItemVenta itemVenta);
    int eliminar(int idItemVenta);
    ArrayList<ItemVenta> listarTodos();
    ArrayList<ItemVenta> filtrarItemsVenta(String nombrePlato, int id_tipoItem, 
            double precio_min, double precio_max, int disponible);
    int insertarCombo(ItemVenta itemVenta);
}