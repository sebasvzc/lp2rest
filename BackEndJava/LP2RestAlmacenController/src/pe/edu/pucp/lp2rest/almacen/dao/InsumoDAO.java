package pe.edu.pucp.lp2rest.almacen.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.almacen.model.Insumo;

public interface InsumoDAO {
    int insertar(Insumo ins);
    int modificar (Insumo ins);
    int eliminar(int idInsumo);
    ArrayList<Insumo> listarTodos(); 
    ArrayList<Insumo> buscarInsumosXNombre(String nombre);
    ArrayList<Insumo> filtrarInsumos(String nombre,String SKU, int idPlato,double precioMin,double precioMax,double stockMin, double stockMax,int idTipoProducto); 
    
    ArrayList<Insumo> listarRecetasPorIdItemVenta(int idItemVenta);
}