/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Proveedor;

/**
 *
 * @author Usuario
 */
public interface ProveedorDAO {
    int insertar(Proveedor proveedor);
    int modificar(Proveedor proveedor);
    int eliminar(int idProveedor);
    ArrayList<Proveedor> listarTodas();
    ArrayList<Proveedor> listarProveedorePorNombre(String nombre);
}
