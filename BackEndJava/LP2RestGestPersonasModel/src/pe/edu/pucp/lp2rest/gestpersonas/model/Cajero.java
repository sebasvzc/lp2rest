package pe.edu.pucp.lp2rest.gestpersonas.model;


public class Cajero extends Empleado {

    //atributos
    private int nroCaja;

    
    //constructor
    public Cajero() {
    }
    //setters y getter
    public int getNroCaja() {
        return nroCaja;
    }

    public void setNroCaja(int nroCaja) {
        this.nroCaja = nroCaja;
    }
    //metodos
}
