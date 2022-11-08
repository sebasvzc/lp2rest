package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.eventos.model.Evento;

public class Artista {

    //atributos
    private int idArtista;
    private String nombre;
    private ArrayList<Evento> eventos;

    //constructor
    public Artista() {
    }

    //getters y setters
    public int getIdArtista() {
        return idArtista;
    }

    public void setIdArtista(int idArtista) {
        this.idArtista = idArtista;
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }


    public ArrayList<Evento> getEventos() {
        return eventos;
    }

    public void setEventos(ArrayList<Evento> eventos) {
        this.eventos = eventos;
    }

    //metodos
}
