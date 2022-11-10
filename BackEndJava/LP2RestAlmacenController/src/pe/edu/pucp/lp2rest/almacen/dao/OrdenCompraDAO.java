/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2rest.almacen.dao;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2rest.almacen.model.OrdenCompra;

/**
 *
 * @author Usuario
 */
public interface OrdenCompraDAO {
    int insertar(OrdenCompra oc);
    int modificar (OrdenCompra oc);
    int eliminar(int idOrdenCompra);
    int actualizarEstadoOrdenCompra (int idOrdenCompra);
    ArrayList<OrdenCompra> listarTodos();
    ArrayList<OrdenCompra> filtrarOrdenCompras(int id_solicitudOrdenDeCompra,Date fecha_registro_max,Date fecha_registro_min,double monto_total_max,double monto_total_min,int idInsumo);
}
