/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ProveedorDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Proveedor;
import pe.edu.pucp.lp2rest.config.DBManager;

/**
 *
 * @author Usuario
 */
public class ProveedorMySQL implements ProveedorDAO{
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public int insertar(Proveedor proveedor) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int modificar(Proveedor proveedor) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idProveedor) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Proveedor> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Proveedor> listarProveedorePorNombre(String nombre) {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_PROVEEDORES_POR_NOMBRE(?)");
            cs.setString("_nombre_razon_social", nombre);
            
            rs = cs.executeQuery();
            while(rs.next()){
                Proveedor proveedor = new Proveedor();
                proveedor.setIdPersona(rs.getInt("fid_personaJuridica")); 
                proveedor.setNombreComercial(rs.getString("nombre_comercial"));
                proveedor.setRUC(rs.getString("ruc"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedores.add(proveedor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return proveedores;
    }
    
}
