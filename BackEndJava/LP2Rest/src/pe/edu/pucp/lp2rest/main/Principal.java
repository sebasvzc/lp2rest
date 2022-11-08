package pe.edu.pucp.lp2rest.main;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2rest.eventos.dao.EventoDAO;
import pe.edu.pucp.lp2rest.eventos.model.Evento;
import pe.edu.pucp.lp2rest.eventos.mysql.EventoMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.dao.AdministradorDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ArtistaDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.AsistenciaDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ChefDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ClienteDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.MeseroDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Administrador;
import pe.edu.pucp.lp2rest.gestpersonas.model.Artista;
import pe.edu.pucp.lp2rest.gestpersonas.model.Asistencia;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cajero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Chef;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Persona;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.AdministradorMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.ArtistaMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.AsistenciaMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.ChefMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.ClienteMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.MeseroMySQL;
import pe.edu.pucp.lp2rest.ventas.dao.DocumentoPagoDAO;
import pe.edu.pucp.lp2rest.ventas.dao.MesaDAO;
import pe.edu.pucp.lp2rest.ventas.dao.OrdenVentaDAO;
import pe.edu.pucp.lp2rest.ventas.model.DocumentoPago;
import pe.edu.pucp.lp2rest.ventas.model.Mesa;
import pe.edu.pucp.lp2rest.ventas.model.OrdenVenta;
import pe.edu.pucp.lp2rest.ventas.mysql.DocumentoPagoMySQL;
import pe.edu.pucp.lp2rest.ventas.mysql.MesaMySQL;
import pe.edu.pucp.lp2rest.ventas.mysql.OrdenVentaMySQL;



public class Principal {

    public static void main(String[] args) throws ParseException {
        
    MeseroDAO daoMesero = new MeseroMySQL();
    ArrayList<Mesero> meseros;
    meseros = daoMesero.listarTodas();

    for( Mesero mesero : meseros){
       System.out.println("Nombre: " + mesero.getNombre());
    }
        
        
        
//        String sDate1="31/12/1998";
//        String sHour1="01:00:00";
//        try{
//            java.util.Date date1=new SimpleDateFormat("dd/MM/yyyy hh:mm:ss").parse(sDate1+" "+sHour1);
//            System.out.println(sDate1+"\t"+date1);  
//          
//        }
//        catch(Exception ex){
//             System.out.println(ex.getMessage());
//        }

        
        
        
        ////////////////////////////////////////////////////////////////////////     
        
        
        
//        ArtistaDAO daoArtista = new ArtistaMySQL();
//        ArrayList<Artista> artistas;
//        artistas = daoArtista.listarTodas();
//        
//        for( Artista art : artistas){
//            //System.out.println("Nombre: " + art.getNombre());
//        }
//        
//        
//        
//        ClienteDAO daoCliente = new ClienteMySQL();
//        ArrayList<Cliente> clientes;
//        clientes = daoCliente.listarTodas();
//        
//        for( Cliente cli : clientes){
//            //System.out.println("Nombre: " + cli.getNombre());
//        }
//        
//        EventoDAO daoEvento = new EventoMySQL();
//        ArrayList<Evento> eventos;
//        eventos = daoEvento.listarTodas();
//        
//        for( Evento eve : eventos){
//            //System.out.println("Nombre: " + eve.getArtista().getNombre());
//        }
//        
//        ChefDAO daoChef = new ChefMySQL();
//        ArrayList<Chef> chefs;
//        chefs = daoChef.listarTodas();
//        
//        for( Chef chef : chefs){
//            //System.out.println("Nombre: " + chef.getNombre());
//        }
//        
//        AdministradorDAO daoAdministrador = new AdministradorMySQL();
//        ArrayList<Administrador> administradores;
//        administradores = daoAdministrador.listarTodas();
//        
//        for( Administrador administrador : administradores){
//            System.out.println("Nombre: " + administrador.getNombre());
//        }
        
        ////////////////////////////////////////////////////////////////////////

        // MesaDAO daoMesa = new MesaMySQL();
        // Mesa mesa1 = new Mesa(4, true);
        // Mesa mesa2 = new Mesa(6, true);
        // Mesa mesa3 = new Mesa(2, true);
        // Mesa mesa4 = new Mesa(2, true);
        // Mesa mesa5 = new Mesa(5, false);
        // // daoMesa.insertar(mesa2);
        // daoMesa.insertar(mesa3);
        // daoMesa.insertar(mesa4);
        // daoMesa.insertar(mesa5);
        // // daoMesa.eliminar(1);
        // Mesa mesax = new Mesa();
        // ArrayList<Mesa> mesas = daoMesa.listarTodos();
        // for (Mesa a : mesas) {
        //     System.out.println(a.getIdMesa() + " - " + a.getCapacidadMaxima());
        // }
        // mesax = mesas.get(0);
        // mesax.setCapacidadMaxima(10);
        // mesax.setDisponible(false);
        // System.out.println("Luego de la insercion: ");
        // daoMesa.modificar(mesax);

        // mesas = daoMesa.listarTodos();
        // for (Mesa a : mesas) {
        //     System.out.println(a.getIdMesa() + " - " + a.getCapacidadMaxima());
        // }

        // DocumentoPagoDAO daoDocumentoPago = new DocumentoPagoMySQL();
        // DocumentoPago documentoPago1 = new DocumentoPago("RUC_empresa", "direccionFiscal", "tipoPago", 100,
        //         new java.util.Date(), true, 1, "serie", 100, "numeroAutorizacion", "metodoPago", null, 100,
        //         new java.util.Date(), "ruc", "razonSocial");
        // DocumentoPago documentoPago2 = new DocumentoPago("RUC_empresa", "direccionFiscal", "tipoPago", 100,
        //         new java.util.Date(), true, 1, "serie", 100, "numeroAutorizacion", "metodoPago", null, 100,
        //         new java.util.Date(), "ruc", "razonSocial");
        // DocumentoPago documentoPago3 = new DocumentoPago("RUC_empresa", "direccionFiscal", "tipoPago", 100,
        //         new java.util.Date(), true, 1, "serie", 100, "numeroAutorizacion", "metodoPago", null, 100,
        //         new java.util.Date(), "ruc", "razonSocial");
        // DocumentoPago documentoPago4 = new DocumentoPago("RUC_empresa", "direccionFiscal", "tipoPago", 100,
        //         new java.util.Date(), true, 1, "serie", 100, "numeroAutorizacion", "metodoPago", null, 100,
        //         new java.util.Date(), "ruc", "razonSocial");
        // DocumentoPago documentoPago5 = new DocumentoPago("RUC_empresa", "direccionFiscal", "tipoPago", 100,
        //         new java.util.Date(), true, 1, "serie", 100, "numeroAutorizacion", "metodoPago", null, 100,
        //         new java.util.Date(), "ruc", "razonSocial");
        // DocumentoPago documentoPago6 = new DocumentoPago("RUC_empresa", "direccionFiscal", "tipoPago", 100,
        //         new java.util.Date(), true, 1, "serie", 100, "numeroAutorizacion", "metodoPago", null, 100,
        //         new java.util.Date(), "ruc", "razonSocial");
        // DocumentoPago documentoPago7 = new DocumentoPago("RUC_empresa", "direccionFiscal", "tipoPago", 100,
        //         new java.util.Date(), true, 1, "serie", 100, "numeroAutorizacion", "metodoPago", null, 100,
        //         new java.util.Date(), "ruc", "razonSocial");

        // daoDocumentoPago.insertar(documentoPago1);
        // daoDocumentoPago.insertar(documentoPago2);
        // daoDocumentoPago.insertar(documentoPago3);
        // daoDocumentoPago.insertar(documentoPago4);
        // daoDocumentoPago.insertar(documentoPago5);
        // daoDocumentoPago.insertar(documentoPago6);
        // daoDocumentoPago.insertar(documentoPago7);

        // ArrayList<DocumentoPago> documentosPago = daoDocumentoPago.listarTodos();
        // for (DocumentoPago a : documentosPago) {
        //     System.out.println(a.getIdDocumentoPago() + " - " + a.getDireccionFiscal());
        // }

        // DocumentoPago documentoPagox = new DocumentoPago();
        // documentoPagox = documentosPago.get(0);
        // System.out.println("Luego de la insercion: ");
        // daoDocumentoPago.modificar(documentoPagox);

        // documentosPago = daoDocumentoPago.listarTodos();
        // for (DocumentoPago a : documentosPago) {
        //     System.out.println(a.getIdDocumentoPago() + " - " + a.getDireccionFiscal());
        // }

        // // eliminar
        // daoDocumentoPago.eliminar(1);
        // daoDocumentoPago.eliminar(2);
        // documentosPago = daoDocumentoPago.listarTodos();
        // System.out.println("Despues de eliminar: ");
        // for (DocumentoPago a : documentosPago) {
        //     System.out.println(a.getIdDocumentoPago() + " - " + a.getDireccionFiscal());
        // }

//        OrdenVentaDAO daoOrdenVenta = new OrdenVentaMySQL();
//        OrdenVenta ordenVenta = new OrdenVenta();
//        ordenVenta.setTotal(100);
//        ordenVenta.setPagado(true);
//        ordenVenta.setFecha(new java.util.Date());
//        DocumentoPago documentoPago = new DocumentoPago();
//        documentoPago.setIdDocumentoPago(1);
//        ordenVenta.setDocumentoPago(documentoPago);
//        Mesa mesa = new Mesa();
//        mesa.setIdMesa(1);
//        ordenVenta.setMesa(mesa);
//        Mesero mesero = new Mesero();
//        mesero.setIdPersona(1);
//        ordenVenta.setMesero(mesero);
//        Cajero cajero = new Cajero();
//        cajero.setIdPersona(1);
//        ordenVenta.setCajero(cajero);
//        daoOrdenVenta.insertar(ordenVenta);
//        
//        ArrayList<OrdenVenta> ordenesVenta = daoOrdenVenta.listarTodos();
//        for (OrdenVenta a : ordenesVenta) {
//            System.out.println(a.getIdOrdenVenta() + " - " + a.getTotal());
//        }
//
//        OrdenVenta ordenVentax = new OrdenVenta();
//        ordenVentax = ordenesVenta.get(0);
//        System.out.println("Luego de la insercion: ");
//        daoOrdenVenta.modificar(ordenVentax);
//
//        ordenesVenta = daoOrdenVenta.listarTodos();
//        for (OrdenVenta a : ordenesVenta) {
//            System.out.println(a.getIdOrdenVenta() + " - " + a.getTotal());
//        }
//
//        // eliminar
//        daoOrdenVenta.eliminar(1);
//        daoOrdenVenta.eliminar(2);
//        ordenesVenta = daoOrdenVenta.listarTodos();
//        System.out.println("Despues de eliminar: ");
//        for (OrdenVenta a : ordenesVenta) {
//            System.out.println(a.getIdOrdenVenta() + " - " + a.getTotal());
//        }
          AsistenciaDAO daoAsistencia = new AsistenciaMySQL();
          Asistencia asistenciaNueva = new Asistencia();
//          
          asistenciaNueva.setIdCuentaUsuario(2);
//          
//        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
//        Date dateInicio = formato.parse("24-12-2012");
//        Date dateFin = formato.parse("25-12-2012");
//
//        
//            //Instantiating the SimpleDateFormat class
//            //Parsing the given String to Date object
//        long milli = 123456789999l;
//  
//        // create a object
//        java.sql.Time time1 = new java.sql.Time(milli);
//        java.sql.Time time2 = new java.sql.Time(milli);
//        
        asistenciaNueva.setFechaIngreso("2022-01-01");
        asistenciaNueva.setHoraIngreso("00:00:01");
        asistenciaNueva.setFechaSalida("2022-01-02");
        asistenciaNueva.setHoraSalida("01:01:02");
        int result =  daoAsistencia.insertarAsistencia(asistenciaNueva);
        if(result != 0){
           System.out.println("Se pudo insertar correctamente");
         }
          
          
    }
}