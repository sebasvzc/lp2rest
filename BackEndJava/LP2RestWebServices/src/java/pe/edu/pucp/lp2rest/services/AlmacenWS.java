package pe.edu.pucp.lp2rest.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2rest.almacen.dao.InsumoDAO;
import pe.edu.pucp.lp2rest.almacen.dao.LineaOrdenCompraDAO;
import pe.edu.pucp.lp2rest.almacen.dao.OrdenCompraDAO;
import pe.edu.pucp.lp2rest.almacen.dao.TipoProductoDAO;
import pe.edu.pucp.lp2rest.almacen.model.Insumo;
import pe.edu.pucp.lp2rest.almacen.model.OrdenCompra;
import pe.edu.pucp.lp2rest.almacen.model.LineaOrdenCompra;
import pe.edu.pucp.lp2rest.almacen.model.TipoProducto;
import pe.edu.pucp.lp2rest.almacen.mysql.InsumoMySQL;
import pe.edu.pucp.lp2rest.almacen.mysql.LineaOrdenCompraMySQL;
import pe.edu.pucp.lp2rest.almacen.mysql.OrdenCompraMySQL;
import pe.edu.pucp.lp2rest.almacen.mysql.TipoProductoMySQL;


@WebService(serviceName = "AlmacenWS")
public class AlmacenWS {

    private InsumoDAO daoInsumo = new InsumoMySQL();
    private OrdenCompraDAO  daoOrdenCompra = new OrdenCompraMySQL();
    private LineaOrdenCompraDAO daoLineaOrdenCompra = new LineaOrdenCompraMySQL();
    private TipoProductoDAO daoTipoProducto= new TipoProductoMySQL();
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodosInsumos")
    public ArrayList<Insumo> listarTodosInsumos() {
        ArrayList<Insumo> insumos = null;
        try{
            insumos = daoInsumo.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return insumos;
    }
    
    @WebMethod(operationName = "BuscarInsumosPorNombre")
    public ArrayList<Insumo> BuscarInsumosPorNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Insumo> insumos = null;
        try{
            insumos = daoInsumo.buscarInsumosXNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return insumos;
    }
    
    @WebMethod(operationName = "InsertarInsumo")
    public int InsertarInsumo(@WebParam(name = "insumo") Insumo insumo) {
        int resultado = 0;
        try{
            resultado = daoInsumo.insertar(insumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarInsumo")
    public int ModificarInsumo(@WebParam(name = "insumo") Insumo insumo) {
        int resultado = 0;
        try{
            resultado = daoInsumo.modificar(insumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarInsumo")
    public int EliminarInsumo(@WebParam(name = "idInsumo") int idInsumo) {
        int resultado = 0;
        try{
            resultado = daoInsumo.eliminar(idInsumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "FiltrarInsumos")
    public  ArrayList<Insumo> FiltrarInsumos(
            @WebParam(name = "nombre_insumo") String nombre_insumo,
            @WebParam(name = "sku") String sku,
            @WebParam(name = "idPlato") int idPlato,
            @WebParam(name = "precioMin") double precioMin,
            @WebParam(name = "precioMax") double precioMax,
            @WebParam(name = "stockMin") double stockMin,
            @WebParam(name = "stockMax") double stockMax,
            @WebParam(name = "idTipoProducto") int idTipoProducto) {
            ArrayList<Insumo> insumos = null;
            try{
                    insumos = daoInsumo.filtrarInsumos(nombre_insumo,sku,idPlato,precioMin,precioMax,stockMin,stockMax,idTipoProducto);
            }catch(Exception ex){
                    System.out.println(ex.getMessage());
            }
            return insumos;
    }
    
    @WebMethod(operationName = "listarInsumosPorIdItemVenta")
    public ArrayList<Insumo> listarInsumosPorIdItemVenta(@WebParam(name = "idPlato") int idPlato) {
        ArrayList<Insumo> insumos = null;
        try{
            insumos = daoInsumo.listarRecetasPorIdItemVenta(idPlato);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return insumos;
    }
    
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "FiltrarOrdenCompra")
    public  ArrayList<OrdenCompra> FiltrarOrdenCompra(
        @WebParam(name = "id_solicitudOrdenDeCompra") int id_solicitudOrdenDeCompra,
        @WebParam(name = "fecha_registro_max") Date fecha_registro_max,
        @WebParam(name = "fecha_registro_min") Date fecha_registro_min,
        @WebParam(name = "monto_total_max") double monto_total_max,
        @WebParam(name = "monto_total_min") double monto_total_min,
        @WebParam(name = "idInsumo") int idInsumo) {
        ArrayList<OrdenCompra> ordenCompras = null;
        try{
            ordenCompras = daoOrdenCompra.filtrarOrdenCompras(id_solicitudOrdenDeCompra,fecha_registro_max,fecha_registro_min,monto_total_max,monto_total_min,idInsumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenCompras;
    }
    
    @WebMethod(operationName = "listarTodosOrdenCompra")
    public ArrayList<OrdenCompra> listarTodosOrdenCompra() {
        ArrayList<OrdenCompra> OrdenesCompra = null;
        try{
            OrdenesCompra = daoOrdenCompra.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return OrdenesCompra;
    }
    
    @WebMethod(operationName = "InsertarOrdenCompra")
    public int InsertarOrdenCompra(@WebParam(name = "ordenCompra") OrdenCompra ordenCompra) {
        int resultado = 0;
        try{
            resultado = daoOrdenCompra.insertar(ordenCompra);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarOrdenCompra")
    public int ModificarOrdenCompra(@WebParam(name = "ordenCompra") OrdenCompra ordenCompra) {
        int resultado = 0;
        try{
            resultado = daoOrdenCompra.modificar(ordenCompra);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarOrdenCompra")
    public int EliminarOrdenCompra(@WebParam(name = "idOrdenCompra") int idOrdenCompra) {
        int resultado = 0;
        try{
            resultado = daoOrdenCompra.eliminar(idOrdenCompra);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodosLineasOrdenCompra")
    public ArrayList<LineaOrdenCompra> listarTodosLineasOrdenCompra() {
        ArrayList<LineaOrdenCompra> lineasOrdenCompra = null;
        try{
            lineasOrdenCompra = daoLineaOrdenCompra.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineasOrdenCompra;
    }
    
    @WebMethod(operationName = "InsertarLineaOrdenCompra")
    public int InsertarLineaOrdenCompra(@WebParam(name = "lineaOrdenCompra") LineaOrdenCompra lineaOrdenCompra) {
        int resultado = 0;
        try{
            resultado = daoLineaOrdenCompra.insertar(lineaOrdenCompra);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarLineaOrdenCompra")
    public int ModificarLineaOrdenCompra(@WebParam(name = "lineaOrdenCompra") LineaOrdenCompra lineaOrdenCompra) {
        int resultado = 0;
        try{
            resultado = daoLineaOrdenCompra.modificar(lineaOrdenCompra);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarLineaOrdenCompra")
    public int EliminarLineaOrdenCompra(@WebParam(name = "idLineaOrdenCompra") int idLineaOrdenCompra) {
        int resultado = 0;
        try{
            resultado = daoLineaOrdenCompra.eliminar(idLineaOrdenCompra);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "ListarTipoProducto")
    public  ArrayList<TipoProducto> ListarTipoProducto() {
            ArrayList<TipoProducto> tipoProductos = null;
            try{
                    tipoProductos = daoTipoProducto.listarTodos();
            }catch(Exception ex){
                    System.out.println(ex.getMessage());
            }
            return tipoProductos;
    }
    @WebMethod(operationName = "ListarLineasOrdenCompra")
    public  ArrayList<LineaOrdenCompra> ListarLineasOrdenCompra(@WebParam(name = "idOrdenCompra") int idOrdenCompra) {
        ArrayList<LineaOrdenCompra> lineaCompra = null;
        try{
            lineaCompra = daoLineaOrdenCompra.listarLineasOrdenCompraPorId(idOrdenCompra);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineaCompra;
    }
}