package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.ArrayList;

public class Recepcionista extends Empleado {

    //atributos
    private ArrayList<Reserva> reservas;

    //constructor
    public Recepcionista() {
    }

    //getters y setters
    public ArrayList<Reserva> getReservas() {
        return reservas;
    }

    public void setReservas(ArrayList<Reserva> reservas) {
        this.reservas = reservas;
    }

    //metodos
}
