package pe.edu.pucp.lp2rest.gestpersonas.model;

public class PersonaJuridica extends Persona {

    //atributos
    private String RUC;
    private String nombreComercial;
    private String razonSocial;

    //contructores
    public PersonaJuridica() {
    }

    //setters y getters
    public String getRUC() {
        return RUC;
    }

    public void setRUC(String RUC) {
        this.RUC = RUC;
    }

    public String getNombreComercial() {
        return nombreComercial;
    }

    public void setNombreComercial(String nombreComercial) {
        this.nombreComercial = nombreComercial;
    }

    public String getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }
    
    //metodoss
}
