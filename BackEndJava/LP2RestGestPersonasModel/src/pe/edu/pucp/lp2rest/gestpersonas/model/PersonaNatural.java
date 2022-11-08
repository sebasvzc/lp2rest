package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.Date;

public class PersonaNatural extends Persona {

    //atributos
    private String nombre;
    private String apellidoPaterno;
    private String DNI;
    private Date fechaNacimiento;

    

    //constructor
    public PersonaNatural() {
    }

    //getters y setters
    public Date getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(Date fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidoPaterno() {
        return apellidoPaterno;
    }

    public void setApellidoPaterno(String apellidoPaterno) {
        this.apellidoPaterno = apellidoPaterno;
    }

    public String getDNI() {
        return DNI;
    }

    public void setDNI(String DNI) {
        this.DNI = DNI;
    }

    //metodos
}
