package pe.edu.pucp.lp2rest.eventos.dao;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2rest.eventos.model.Evento;


public interface EventoDAO {
    int insertar(Evento evento);
    int modificar(Evento evento);
    int eliminar(int idEvento);
    ArrayList<Evento> listarTodas();    
    ArrayList<Evento> FiltrarEventos(String nombre_evento, int fid_artista,
            Date fecha_inicio, Date fecha_fin, 
            double monto_min, double monto_max);
}
