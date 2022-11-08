package pe.edu.pucp.lp2rest.gestpersonas.model;

public class Persona {

    //atributos
    private int idPersona;
    private String email;
    private String telefono;
    private String direccion;

    //constructores
    public Persona() {
    }

    //setters y getters
    public int getIdPersona() {
        return idPersona;
    }

    public void setIdPersona(int idPersona) {
        this.idPersona = idPersona;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    //metodos
}
