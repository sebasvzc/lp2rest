package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ClienteDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;


public class ClienteMySQL implements ClienteDAO{
    
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
            
    @Override
    public int insertar(Cliente cliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CLIENTE(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_cliente", java.sql.Types.INTEGER);
            cs.setString("_email", cliente.getEmail());
            cs.setString("_direccion", cliente.getDireccion());
            cs.setString("_telefono", cliente.getTelefono());
            cs.setString("_nombres", cliente.getNombre());
            cs.setString("_apellidos", cliente.getApellidoPaterno());
            cs.setString("_DNI", cliente.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(cliente.getFechaNacimiento().getTime()));
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Cliente cliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CLIENTE(?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_cliente", cliente.getIdPersona());
            cs.setString("_email", cliente.getEmail());
            cs.setString("_direccion", cliente.getDireccion());
            cs.setString("_telefono", cliente.getTelefono());
            cs.setString("_nombres", cliente.getNombre());
            cs.setString("_apellidos", cliente.getApellidoPaterno());
            cs.setString("_DNI", cliente.getDNI());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(cliente.getFechaNacimiento().getTime()));
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idCliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CLIENTE(?)}");
            cs.setInt("_id_cliente", idCliente);            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Cliente> filtrarClientes(String dni,String email,String nombres,String apellidos,String telefono) {
        
        ArrayList<Cliente> clientes = new ArrayList<>();
        
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call FILTRAR_CLIENTES(?,?,?,?,?)");
            cs.setString("_dni", dni);
            cs.setString("_email", email);
            cs.setString("_nombres", nombres);
            cs.setString("_apellidos", apellidos);
            cs.setString("_telefono", telefono);
            
            rs = cs.executeQuery();
            while(rs.next()){
                Cliente cliente = new Cliente();
                cliente.setIdPersona(rs.getInt("id_persona")); 
                cliente.setNombre(rs.getString("nombres"));
                cliente.setApellidoPaterno(rs.getString("apellidos")); 
                cliente.setDNI(rs.getString("DNI")); 
                cliente.setEmail(rs.getString("email")); 
                cliente.setTelefono(rs.getString("telefono")); 
                
                clientes.add(cliente);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return clientes;
    }

    @Override
    public ArrayList<Cliente> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public Cliente listarPorDni(String dni) {
        Cliente cliente = new Cliente();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_POR_DNI(?)");
            cs.setString("_dni", dni);
            
            rs = cs.executeQuery();
            while(rs.next()){
                cliente.setIdPersona(rs.getInt("id_persona")); 
                cliente.setNombre(rs.getString("nombres"));
                cliente.setApellidoPaterno(rs.getString("apellidos")); 
                cliente.setDNI(rs.getString("DNI")); 
                cliente.setFechaNacimiento(rs.getDate("fecha_nacimiento")); 
                cliente.setEmail(rs.getString("email")); 
                cliente.setTelefono(rs.getString("telefono")); 
                cliente.setDireccion(rs.getString("direccion"));
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return cliente;
    }

    
}
