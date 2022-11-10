package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.Date;

public class Reclamo {

    
    
    //atributos
    private int Id;
    private Cliente cliente;
    private Administrador administrador;
    private Empleado empleado;

    private String descripcion;
    private boolean estado; // false NO ATENDIDO, true ATENDIDO
    private Date fechaRegistro;
    private Date fechaAtencion;
    private String observacion;

    //constructor
    public Reclamo() {
    }
    
    //getters y setters
    
    public int getId() {
        return Id;
    }

    public void setId(int Id) {
        this.Id = Id;
    }
    
    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Administrador getAdministrador() {
        return administrador;
    }

    public void setAdministrador(Administrador administrador) {
        this.administrador = administrador;
    }

    public Empleado getEmpleado() {
        return empleado;
    }

    public void setEmpleado(Empleado empleado) {
        this.empleado = empleado;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fecha) {
        this.fechaRegistro = fecha;
    }

    public String getObservacion() {
        return observacion;
    }

    public void setObservacion(String observacion) {
        this.observacion = observacion;
    }
    
    public Date getFechaAtencion() {
        return fechaAtencion;
    }

    public void setFechaAtencion(Date fechaAtencion) {
        this.fechaAtencion = fechaAtencion;
    }

    
    //metodos
}