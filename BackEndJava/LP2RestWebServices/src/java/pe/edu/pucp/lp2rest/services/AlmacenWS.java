package pe.edu.pucp.lp2rest.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2rest.almacen.dao.InsumoDAO;
import pe.edu.pucp.lp2rest.almacen.dao.LineaOrdenCompraDAO;
import pe.edu.pucp.lp2rest.almacen.dao.OrdenCompraDAO;
import pe.edu.pucp.lp2rest.almacen.model.Insumo;
import pe.edu.pucp.lp2rest.almacen.model.OrdenCompra;
import pe.edu.pucp.lp2rest.almacen.model.LineaOrdenCompra;
import pe.edu.pucp.lp2rest.almacen.mysql.InsumoMySQL;
import pe.edu.pucp.lp2rest.almacen.mysql.LineaOrdenCompraMySQL;
import pe.edu.pucp.lp2rest.almacen.mysql.OrdenCompraMySQL;


@WebService(serviceName = "AlmacenWS")
public class AlmacenWS {

    private InsumoDAO daoInsumo = new InsumoMySQL();
    private OrdenCompraDAO  daoOrdenCompra = new OrdenCompraMySQL();
    private LineaOrdenCompraDAO daoLineaOrdenCompra = new LineaOrdenCompraMySQL();
    
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
    
    ///////////////////////////////////////////////////////////////////////////
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
}
