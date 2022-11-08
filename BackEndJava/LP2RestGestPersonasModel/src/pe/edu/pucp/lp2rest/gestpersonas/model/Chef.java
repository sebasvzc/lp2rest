package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.ArrayList;

public class Chef extends Empleado {

    //atributos
    private String especialidad;
    private ArrayList<Solicitud> solicitudes;

    public ArrayList<Solicitud> getSolicitudes() {
        return solicitudes;
    }

    public void setSolicitudes(ArrayList<Solicitud> solicitudes) {
        this.solicitudes = solicitudes;
    }

    //constructor
    public Chef() {
    }

    //getters y setters
    public String getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(String especialidad) {
        this.especialidad = especialidad;
    }
    
    //metodos
}
