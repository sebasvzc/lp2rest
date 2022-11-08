package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.Date;
import java.time.LocalTime;
import java.util.ArrayList;

public class Reserva {

    //atributos
    private Recepcionista recepcionista;
    private Cliente cliente;

    private int idReserva;
    private Date fecha;
    private LocalTime horaInicio;

    //contructor
    public Reserva() {
    }

    //getters y setters
    public Recepcionista getRecepcionista() {
        return recepcionista;
    }

    public void setRecepcionista(Recepcionista recepcionista) {
        this.recepcionista = recepcionista;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public int getIdReserva() {
        return idReserva;
    }

    public void setIdReserva(int idReserva) {
        this.idReserva = idReserva;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public LocalTime getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(LocalTime horaInicio) {
        this.horaInicio = horaInicio;
    }
    
    //metodos
}
