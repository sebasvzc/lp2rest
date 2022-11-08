package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.Date;

public class Empleado extends PersonaNatural {

    //atributos
    private Restaurante restaurante;
    private CuentaUsuario cuentaUsuario;
    //private ArrayList<Solicitud> solicitudes;
    //private ArrayList<Reclamo> reclamos;

    private double sueldo;
    private boolean activo;
    private Date fechaContratacion;
    private int numeroHorasMensuales;

    
    //constructor
    public Empleado() {
    }

    //getters y setters 
    public int getNumeroHorasMensuales() {
        return numeroHorasMensuales;
    }

    public void setNumeroHorasMensuales(int numeroHorasMensuales) {
        this.numeroHorasMensuales = numeroHorasMensuales;
    }

    public Restaurante getRestaurante() {
        return restaurante;
    }

    public void setRestaurante(Restaurante restaurante) {
        this.restaurante = restaurante;
    }

    public CuentaUsuario getCuentaUsuario() {
        return cuentaUsuario;
    }

    public void setCuentaUsuario(CuentaUsuario cuentaUsuario) {
        this.cuentaUsuario = cuentaUsuario;
    }

    public double getSueldo() {
        return sueldo;
    }

    public void setSueldo(double sueldo) {
        this.sueldo = sueldo;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public Date getFechaContratacion() {
        return fechaContratacion;
    }

    public void setFechaContratacion(Date fechaContratacion) {
        this.fechaContratacion = fechaContratacion;
    }

}
