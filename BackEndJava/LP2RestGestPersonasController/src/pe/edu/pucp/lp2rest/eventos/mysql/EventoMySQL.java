package pe.edu.pucp.lp2rest.eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.eventos.dao.EventoDAO;
import pe.edu.pucp.lp2rest.eventos.model.Evento;
import pe.edu.pucp.lp2rest.gestpersonas.model.Artista;


public class EventoMySQL implements EventoDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Evento evento) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_EVENTO(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_evento", java.sql.Types.INTEGER);
            cs.setInt("_fid_administrador", evento.getAdministrador().getIdPersona());
            cs.setInt("_fid_artista", evento.getArtista().getIdArtista());
            cs.setDate("_fecha_inicio", new java.sql.Date(evento.getFecha_inicio().getTime()));
            cs.setDouble("_monto_pagar", evento.getMonto_pagar());
            cs.setString("_nombre_evento", evento.getNombre());
            cs.executeUpdate(); 
            evento.setIdEvento(cs.getInt("_id_evento"));
            resultado = evento.getIdEvento();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Evento evento) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_EVENTO(?,?,?,?,?,?)}");
            cs.setInt("evento", evento.getIdEvento());
            cs.setInt("_fid_administrador", evento.getAdministrador().getIdPersona());
            cs.setInt("_fid_artista", evento.getArtista().getIdArtista());
            cs.setDate("_fecha_inicio", new java.sql.Date(evento.getFecha_inicio().getTime()));
            cs.setDouble("_monto_pagar", evento.getMonto_pagar());
            cs.setString("_nombre_evento", evento.getNombre());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idEvento) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_EVENTO(?)}");
            cs.setInt("_id_evento", idEvento);            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Evento> listarTodas() {
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_EVENTOS()");
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();
                evento.setIdEvento(rs.getInt("id_evento"));
                evento.setFecha_inicio(rs.getDate("fecha_inicio"));
                evento.setMonto_pagar(rs.getDouble("monto_pagar"));
                evento.setArtista(new Artista());
                evento.getArtista().setNombre(rs.getString("nombre_artistico"));        
                eventos.add(evento);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return eventos;
    }

    @Override
    public ArrayList<Evento> FiltrarEventos(String nombre_evento, int fid_artista, 
            Date fecha_inicio, Date fecha_fin, 
            double monto_min, double monto_max) {
        
        ArrayList<Evento> eventos = new ArrayList<>();
        
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call FILTRAR_EVENTOS(?,?,?,?,?,?)");
            cs.setString("_nombre_evento", nombre_evento);
            cs.setInt("_fid_artista", fid_artista);
            cs.setDate("_fecha_inicio", new java.sql.Date(fecha_inicio.getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(fecha_fin.getTime()));
            cs.setDouble("_monto_min", monto_min);            
            cs.setDouble("_monto_max", monto_max);
            
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();
                evento.setIdEvento(rs.getInt("id_evento"));                
                evento.setNombre(rs.getString("nombre_evento"));

                evento.setFecha_inicio(rs.getDate("fecha_inicio"));
                evento.setMonto_pagar(rs.getDouble("monto_pagar"));
                evento.setArtista(new Artista());
                evento.getArtista().setNombre(rs.getString("nombre_artistico"));        
                eventos.add(evento);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return eventos;
    }
}
