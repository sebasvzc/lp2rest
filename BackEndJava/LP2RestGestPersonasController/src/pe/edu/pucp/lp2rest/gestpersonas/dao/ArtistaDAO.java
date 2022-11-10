package pe.edu.pucp.lp2rest.gestpersonas.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.model.Artista;


public interface ArtistaDAO {
    int insertar(Artista artista);
    int modificar(Artista artista);
    int eliminar(int idArtista);
    ArrayList<Artista> listarTodas();
    public ArrayList<Artista> listarPorNombre(String nombre);
}
