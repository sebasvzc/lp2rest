package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ArtistaDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Artista;

public class ArtistaMySQL implements ArtistaDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Artista artista) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ARTISTA(?)}");
            cs.setString("_nombre_artistico", artista.getNombre());
            resultado = cs.executeUpdate(); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Artista artista) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ARTISTA(?,?)}");
            cs.setInt("_id_artista", artista.getIdArtista());
            cs.setString("_nombre_artistico", artista.getNombre());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idArtista) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ARTISTA(?)}");
            cs.setInt("_id_artista", idArtista);            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Artista> listarTodas() {
       ArrayList<Artista> artistas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_TODOS_ARTISTAS()");
            rs = cs.executeQuery();
            while(rs.next()){
                Artista artista = new Artista();
                artista.setIdArtista(rs.getInt("id_artista"));
                artista.setNombre(rs.getString("nombre_artistico"));
                artistas.add(artista);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return artistas;
    }
    
}
