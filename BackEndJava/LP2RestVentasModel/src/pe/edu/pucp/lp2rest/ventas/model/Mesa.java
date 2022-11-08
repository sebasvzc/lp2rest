package pe.edu.pucp.lp2rest.ventas.model;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Reserva;

public class Mesa {

    //atributos
    private int idMesa;
    private int capacidadMaxima;
    private boolean disponible;
    private ArrayList<OrdenVenta> ordenesVenta;
    private Reserva reserva;

    // constructor
    public Mesa(int capacidadMaxima, boolean disponible) {
        this.capacidadMaxima = capacidadMaxima;
        this.disponible = disponible;
    }

    public Mesa() {

    }

    // getters y setters
    public int getIdMesa() {
        return idMesa;
    }

    public void setIdMesa(int idMesa) {
        this.idMesa = idMesa;
    }

    public int getCapacidadMaxima() {
        return capacidadMaxima;
    }

    public void setCapacidadMaxima(int capacidadMaxima) {
        this.capacidadMaxima = capacidadMaxima;
    }

    public boolean isDisponible() {
        return disponible;
    }

    public void setDisponible(boolean disponible) {
        this.disponible = disponible;
    }

    public ArrayList<OrdenVenta> getOrdenesVenta() {
        return ordenesVenta;
    }

    public void setOrdenesVenta(ArrayList<OrdenVenta> ordenesVenta) {
        this.ordenesVenta = ordenesVenta;
    }

    public Reserva getReserva() {
        return reserva;
    }

    public void setReserva(Reserva reserva) {
        this.reserva = reserva;
    }

    // metodos
    public void cambiarEstadoMesa() {
    }

}
