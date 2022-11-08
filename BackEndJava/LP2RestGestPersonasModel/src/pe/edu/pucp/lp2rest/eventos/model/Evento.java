package pe.edu.pucp.lp2rest.eventos.model;

import java.time.LocalDateTime;
import java.util.Date;
import pe.edu.pucp.lp2rest.gestpersonas.model.Administrador;
import pe.edu.pucp.lp2rest.gestpersonas.model.Artista;

public class Evento {

    //atributos
    private int idEvento;   
    private boolean activo;
    private Date fecha_inicio;
    private Date fecha_fin;
    private double monto_pagar;
    private Administrador administrador;
    private Artista artista;
    private String nombre;

    //constructor
    public Evento() {
    }

    //getters y setters
    public Artista getArtista() {
        return artista;
    }

    public void setArtista(Artista artista) {
        this.artista = artista;
    }
    
    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public Date getFecha_inicio() {
        return fecha_inicio;
    }

    public void setFecha_inicio(Date fecha_inicio) {
        this.fecha_inicio = fecha_inicio;
    }

    public Date getFecha_fin() {
        return fecha_fin;
    }

    public void setFecha_fin(Date fecha_fin) {
        this.fecha_fin = fecha_fin;
    }

    public double getMonto_pagar() {
        return monto_pagar;
    }

    public void setMonto_pagar(double monto_pagar) {
        this.monto_pagar = monto_pagar;
    }
    
    public int getIdEvento() {
        return idEvento;
    }

    public void setIdEvento(int idEvento) {
        this.idEvento = idEvento;
    }
    
    public Administrador getAdministrador() {
        return administrador;
    }

    public void setAdministrador(Administrador administrador) {
        this.administrador = administrador;
    }

    
    //metodos
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}
