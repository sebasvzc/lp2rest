package pe.edu.pucp.lp2rest.services;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2rest.ventas.dao.DocumentoPagoDAO;
import pe.edu.pucp.lp2rest.ventas.dao.LineaOrdenVentaDAO;
import pe.edu.pucp.lp2rest.ventas.dao.MesaDAO;
import pe.edu.pucp.lp2rest.ventas.dao.OrdenVentaDAO;
import pe.edu.pucp.lp2rest.ventas.model.DocumentoPago;
import pe.edu.pucp.lp2rest.ventas.model.LineaOrdenVenta;
import pe.edu.pucp.lp2rest.ventas.model.Mesa;
import pe.edu.pucp.lp2rest.ventas.model.OrdenVenta;
import pe.edu.pucp.lp2rest.ventas.mysql.DocumentoPagoMySQL;
import pe.edu.pucp.lp2rest.ventas.mysql.LineaOrdenVentaMySQL;
import pe.edu.pucp.lp2rest.ventas.mysql.MesaMySQL;
import pe.edu.pucp.lp2rest.ventas.mysql.OrdenVentaMySQL;

@WebService(serviceName = "VentasWS")
public class VentasWS {

    private DocumentoPagoDAO daoDocumentoPago = new DocumentoPagoMySQL();
    private OrdenVentaDAO daoOrdenVenta = new OrdenVentaMySQL();
    private MesaDAO daoMesa = new MesaMySQL();
    private LineaOrdenVentaDAO daoLineaOrdenVenta = new LineaOrdenVentaMySQL();
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodosDocumentosDePago")
    public ArrayList<DocumentoPago> listarTodosDocumentosDePago() {
        ArrayList<DocumentoPago> documentosDePago = null;
        try{
            documentosDePago = daoDocumentoPago.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return documentosDePago;
    }
    
    @WebMethod(operationName = "InsertarDocumentoDePago")
    public int InsertarDocumentoDePago(@WebParam(name = "documentoDePago") DocumentoPago documentoDePago) {
        int resultado = 0;
        try{
            resultado = daoDocumentoPago.insertar(documentoDePago);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarDocumentoDePago")
    public int ModificarDocumentoDePago(@WebParam(name = "documentoDePago") DocumentoPago documentoDePago) {
        int resultado = 0;
        try{
            resultado = daoDocumentoPago.modificar(documentoDePago);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarDocumentoDePago")
    public int EliminarDocumentoDePago(@WebParam(name = "idDocumentoDePago") int idDocumentoDePago) {
        int resultado = 0;
        try{
            resultado = daoDocumentoPago.eliminar(idDocumentoDePago);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ObtenerDocumentoDePago")
    public DocumentoPago ObtenerDocumentoDePago(@WebParam(name = "idDocumentoDePago") int idDocumentoDePago) {
        DocumentoPago resultado = null;
        try{
            resultado = daoDocumentoPago.obtener(idDocumentoDePago);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodosOrdenesVenta")
    public ArrayList<OrdenVenta> listarTodosOrdenesVenta() {
        ArrayList<OrdenVenta> ordenesVenta = null;
        try{
            ordenesVenta = daoOrdenVenta.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenesVenta;
    }
    
    @WebMethod(operationName = "listarBusquedaOrdenesVenta")
    public ArrayList<OrdenVenta> listarBusquedaOrdenesVenta(@WebParam(name = "nombre") String nombre, 
                                                            @WebParam(name = "apellido")String apellido, 
                                                            @WebParam(name = "fechaIni")String fechaIni, 
                                                            @WebParam(name = "fechaFin")String fechaFin, 
                                                            @WebParam(name = "sueldoIni")double sueldoIni, 
                                                            @WebParam(name = "sueldoFin")double sueldoFin) {
        ArrayList<OrdenVenta> ordenesVenta = null;
        try{
            SimpleDateFormat formateador = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
            Date fechaI = formateador.parse(fechaIni);
            Date fechaF = formateador.parse(fechaFin);
            ordenesVenta = daoOrdenVenta.listarBusqueda(nombre, apellido, fechaI, fechaF, sueldoIni, sueldoFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenesVenta;
    }
    
    @WebMethod(operationName = "listarBusquedaOrdenesVentaMesero")
    public ArrayList<OrdenVenta> listarBusquedaOrdenesVentaMesero(  @WebParam(name = "idMesero") int idMesero, 
                                                                    @WebParam(name = "nombre") String nombre, 
                                                                    @WebParam(name = "apellido")String apellido, 
                                                                    @WebParam(name = "fechaIni")String fechaIni, 
                                                                    @WebParam(name = "fechaFin")String fechaFin, 
                                                                    @WebParam(name = "sueldoIni")double sueldoIni, 
                                                                    @WebParam(name = "sueldoFin")double sueldoFin) {
        ArrayList<OrdenVenta> ordenesVenta = null;
        try{
            SimpleDateFormat formateador = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
            Date fechaI = formateador.parse(fechaIni);
            Date fechaF = formateador.parse(fechaFin);
            ordenesVenta = daoOrdenVenta.listarBusquedaMesero(idMesero,nombre, apellido, fechaI, fechaF, sueldoIni, sueldoFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenesVenta;
    }
    
    @WebMethod(operationName = "listarBusquedaOrdenesVentaAdministrador")
    public ArrayList<OrdenVenta> listarBusquedaOrdenesVentaAdministrador(   @WebParam(name = "nombre") String nombre, 
                                                                            @WebParam(name = "apellido")String apellido, 
                                                                            @WebParam(name = "fechaIni")String fechaIni, 
                                                                            @WebParam(name = "fechaFin")String fechaFin, 
                                                                            @WebParam(name = "sueldoIni")double sueldoIni, 
                                                                            @WebParam(name = "sueldoFin")double sueldoFin) {
        ArrayList<OrdenVenta> ordenesVenta = null;
        try{
            SimpleDateFormat formateador = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
            Date fechaI = formateador.parse(fechaIni);
            Date fechaF = formateador.parse(fechaFin);
            ordenesVenta = daoOrdenVenta.listarBusquedaAdministrador(nombre, apellido, fechaI, fechaF, sueldoIni, sueldoFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenesVenta;
    }
    
    
    
    @WebMethod(operationName = "InsertarOrdenVenta")
    public int InsertarOrdenDeVenta(@WebParam(name = "ordenDeVenta") OrdenVenta ordenVenta) {
        int resultado = 0;
        try{
            resultado = daoOrdenVenta.insertar(ordenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarOrdenVenta")
    public int ModificarOrdenVenta(@WebParam(name = "ordenVenta") OrdenVenta ordenVenta) {
        int resultado = 0;
        try{
            resultado = daoOrdenVenta.modificar(ordenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarOrdenVenta")
    public int EliminarOrdenVenta(@WebParam(name = "idOrdenVenta") int idOrdenVenta) {
        int resultado = 0;
        try{
            resultado = daoOrdenVenta.eliminar(idOrdenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ActualizarOrdenVenta")
    public int ActualizarOrdenVenta(@WebParam(name = "idOrdenVenta") int idOrdenVenta) {
        int resultado = 0;
        try{
            resultado = daoOrdenVenta.actualizar(idOrdenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "ActualizarOrdenVentaPreparado")
    public int ActualizarOrdenVentaPreparado(@WebParam(name = "idOrdenVenta") int idOrdenVenta) {
        int resultado = 0;
        try{
            resultado = daoOrdenVenta.actualizarOrdenVentaPrep(idOrdenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
     
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodosMesas")
    public ArrayList<Mesa> listarTodosMesas() {
        ArrayList<Mesa> mesas = null;
        try{
            mesas = daoMesa.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return mesas;
    }
    
    @WebMethod(operationName = "listarTodosMesas2")
    public ArrayList<Mesa> listarTodosMesas2() {
        ArrayList<Mesa> mesas = null;
        try{
            mesas = daoMesa.listarTodos2();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return mesas;
    }
    
    @WebMethod(operationName = "InsertarMesa")
    public int InsertarMesa(@WebParam(name = "mesa") Mesa mesa) {
        int resultado = 0;
        try{
            resultado = daoMesa.insertar(mesa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarMesa")
    public int ModificarMesa(@WebParam(name = "mesa") Mesa mesa) {
        int resultado = 0;
        try{
            resultado = daoMesa.modificar(mesa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarMesaOrdenVenta")
    public int ModificarMesaOrdenVenta(@WebParam(name = "mesa") Mesa mesa) {
        int resultado = 0;
        try{
            resultado = daoMesa.modificarOrdenVenta(mesa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarMesa")
    public int EliminarMesa(@WebParam(name = "idMesa") int idMesa) {
        int resultado = 0;
        try{
            resultado = daoMesa.eliminar(idMesa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    ///////////////////////////////////////////////////////////////////////////
    @WebMethod(operationName = "listarTodosLineasOrdenVenta")
    public ArrayList<LineaOrdenVenta> listarTodosLineasOrdenVenta() {
        ArrayList<LineaOrdenVenta> lineasOrdenVenta = null;
        try{
            lineasOrdenVenta = daoLineaOrdenVenta.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineasOrdenVenta;
    }
    
    @WebMethod(operationName = "listarLineasOrdenVentaPorId")
    public ArrayList<LineaOrdenVenta> listarLineasOrdenVentaPorId(@WebParam(name = "idLineaOrdenVenta") int idOrdenVenta) {
        ArrayList<LineaOrdenVenta> lineasOrdenVenta = null;
        try{
            lineasOrdenVenta = daoLineaOrdenVenta.listarLineasPorId(idOrdenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineasOrdenVenta;
    }
    
    @WebMethod(operationName = "InsertarLineaOrdenVenta")
    public int InsertarLineaOrdenVenta(@WebParam(name = "lineaOrdenVenta") LineaOrdenVenta lineaOrdenVenta) {
        int resultado = 0;
        try{
            resultado = daoLineaOrdenVenta.insertar(lineaOrdenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ModificarLineaOrdenVenta")
    public int ModificarLineaOrdenVenta(@WebParam(name = "mesa") LineaOrdenVenta lineaOrdenVenta) {
        int resultado = 0;
        try{
            resultado = daoLineaOrdenVenta.modificar(lineaOrdenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "EliminarLineaOrdenVenta")
    public int EliminarLineaOrdenVenta(@WebParam(name = "idLineaOrdenVenta") int idLineaOrdenVenta) {
        int resultado = 0;
        try{
            resultado = daoLineaOrdenVenta.eliminar(idLineaOrdenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "ListarBusquedaLineasOrdenVenta")
    public ArrayList<LineaOrdenVenta> ListarBusquedaLineasOrdenVenta(@WebParam(name = "idLineaOrdenVenta") int idLineaOrdenVenta) {
        ArrayList<LineaOrdenVenta> lineasOrdenVenta = null;
        try{
            lineasOrdenVenta = daoLineaOrdenVenta.listarBusqueda(idLineaOrdenVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineasOrdenVenta;
    }
    
    
}
