package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.ArrayList;

public class Cliente extends PersonaNatural {

    //atributos
    private ArrayList<Reserva> reservas;
    private ArrayList<Reclamo> reclamos;

    //constructor
    public Cliente() {
    }

    //getters y setters
    public ArrayList<Reserva> getReservas() {
        return reservas;
    }

    public void setReservas(ArrayList<Reserva> reservas) {
        this.reservas = reservas;
    }

    public ArrayList<Reclamo> getReclamos() {
        return reclamos;
    }

    public void setReclamos(ArrayList<Reclamo> reclamos) {
        this.reclamos = reclamos;
    }

    //metodos
}
