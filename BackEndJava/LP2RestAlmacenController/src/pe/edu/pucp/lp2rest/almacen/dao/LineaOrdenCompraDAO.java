/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2rest.almacen.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.almacen.model.LineaOrdenCompra;

/**
 *
 * @author Usuario
 */
public interface LineaOrdenCompraDAO {
    int insertar(LineaOrdenCompra loc);
    int modificar (LineaOrdenCompra loc);
    int eliminar(int idLineaOrdenCompra);
    ArrayList<LineaOrdenCompra> listarTodos();
    ArrayList<LineaOrdenCompra> listarLineasOrdenCompraPorId(int idOrden);
}
