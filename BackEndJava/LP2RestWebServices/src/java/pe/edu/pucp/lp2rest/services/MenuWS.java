package pe.edu.pucp.lp2rest.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2rest.menu.dao.ItemVentaDAO;
import pe.edu.pucp.lp2rest.menu.dao.RecetaDAO;
import pe.edu.pucp.lp2rest.menu.dao.TipoItemDAO;
import pe.edu.pucp.lp2rest.menu.model.ItemVenta;
import pe.edu.pucp.lp2rest.menu.model.Receta;
import pe.edu.pucp.lp2rest.menu.model.TipoItem;
import pe.edu.pucp.lp2rest.menu.mysql.ItemVentaMySQL;
import pe.edu.pucp.lp2rest.menu.mysql.RecetaMySQL;
import pe.edu.pucp.lp2rest.menu.mysql.TipoItemMySQL;

@WebService(serviceName = "MenuWS")
public class MenuWS {

    private ItemVentaDAO daoItemVenta =  new ItemVentaMySQL();
    private RecetaDAO daoReceta = new RecetaMySQL(); 
    private TipoItemDAO daoTipoItem = new TipoItemMySQL();
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodasItemVentas")
    public ArrayList<ItemVenta> listarTodasItemVentas() {
        ArrayList<ItemVenta> itemVentas = null;
        try{
            itemVentas = daoItemVenta.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return itemVentas;
    }
    
    @WebMethod(operationName = "filtrarItemsVenta")
    public ArrayList<ItemVenta> filtrarItemsVenta(@WebParam(name = "nombrePlato") String nombrePlato, 
            @WebParam(name = "idTipoItem") int idTipoItem, @WebParam(name = "precio_min") double precio_min,
            @WebParam(name = "precio_max") double precio_max, @WebParam(name = "disponible") int disponible) {
        
        ArrayList<ItemVenta> itemVentas = null;
        try{
            itemVentas = daoItemVenta.filtrarItemsVenta(nombrePlato, idTipoItem, precio_min, precio_max, disponible);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return itemVentas;
    }
    
    @WebMethod(operationName = "InsertarItemVenta")
    public int InsertarItemVenta(@WebParam(name = "itemVenta") ItemVenta itemVenta) {
        int resultado = 0;
        try{
            resultado = daoItemVenta.insertar(itemVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarItemVenta")
    public int ModificarItemVenta(@WebParam(name = "itemVenta") ItemVenta itemVenta) {
        int resultado = 0;
        try{
            resultado = daoItemVenta.modificar(itemVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarItemVenta")
    public int EliminarItemVenta(@WebParam(name = "idItemVenta") int idItemVenta) {
        int resultado = 0;
        try{
            resultado = daoItemVenta.eliminar(idItemVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarCombo")
    public int insertarCombo(@WebParam(name = "itemVenta") ItemVenta itemVenta) {
        int resultado = 0;
        try{
            resultado = daoItemVenta.insertarCombo(itemVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodasRecetas")
    public ArrayList<Receta> listarTodasRecetas() {
        ArrayList<Receta> recetas = null;
        try{
            recetas = daoReceta.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return recetas;
    }
    
    @WebMethod(operationName = "InsertarReceta")
    public int InsertarReceta(@WebParam(name = "receta") Receta receta) {
        int resultado = 0;
        try{
            resultado = daoReceta.insertar(receta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarReceta")
    public int ModificarReceta(@WebParam(name = "receta") Receta receta) {
        int resultado = 0;
        try{
            resultado = daoReceta.modificar(receta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarReceta")
    public int EliminarReceta(@WebParam(name = "idReceta") int idReceta) {
        int resultado = 0;
        try{
            resultado = daoReceta.eliminar(idReceta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodasTiposDeItem")
    public ArrayList<TipoItem> listarTodasTiposDeItem() {
        ArrayList<TipoItem> tiposDeItem = null;
        try{
            tiposDeItem = daoTipoItem.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return tiposDeItem;
    }
    
    @WebMethod(operationName = "InsertarTipoItem")
    public int InsertarTipoItem(@WebParam(name = "tipoItem") TipoItem tipoItem) {
        int resultado = 0;
        try{
            resultado = daoTipoItem.insertar(tipoItem);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
//    @WebMethod(operationName = "ModificarTipoItem")
//    public int ModificarTipoItem(@WebParam(name = "receta") TipoItem tipoItem) {
//        int resultado = 0;
//        try{
//            resultado = daoTipoItem.modificar(tipoItem);
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        return resultado;
//    }
    
    @WebMethod(operationName = "EliminarTipoItem")
    public int EliminarTipoItem(@WebParam(name = "idTipoItem") int idTipoItem) {
        int resultado = 0;
        try{
            resultado = daoTipoItem.eliminar(idTipoItem);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}