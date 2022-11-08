package pe.edu.pucp.lp2rest.gestpersonas.model;

import pe.edu.pucp.lp2rest.eventos.model.Evento;
import java.util.ArrayList;

public class Administrador extends Empleado {

    //atributos
    private ArrayList<Evento> eventos;

    //constructor
    public Administrador() {
    }

    //getters y setters
    public ArrayList<Evento> getEventos() {
        return eventos;
    }

    public void setEventos(ArrayList<Evento> eventos) {
        this.eventos = eventos;
    }
    
    //metodos
    public void registrarUsuario(){}
    public void actualizarUsuario(){}
    public void eliminarUsuario(){}
    public void listarUsuario(){}
    public void visualizarUsuario(){}

    public void listarSolicitud(){}
    public void aprobarSolicitud(){}

    public void registrarEvento(){}
    public void actualizarEvento(){}
    public void eliminarEvento(){}
    public void listarEventos(){}
    public void visualizarEvento(){}

    public void crearOrdenCompra(){}
    public void actualizarOrdenCompra(){}
    public void eliminarOrdenCompra(){}
    public void listarOrdenCompra(){}
    public void visualizarOrdenCompra(){}
    
    public void crearGuiaRemision(){}
    public void actualizarGuiaRemision(){}
    public void eliminarGuiaRemision(){}
    public void listarGuiaRemision(){}
    public void visualizarGuiaRemision(){}
    
    public void agregarDescuento(){}

    public void registrarCombo(){}
    public void actualizarCombo(){}
    public void eliminarrCombo(){}
    public void listarCombo(){}
    public void visualizarCombo(){}

    public void generarReporteOrdenVenta(){}
    public void generarReporteAsistencia(){}
    public void generarReportePlatos(){}
}
