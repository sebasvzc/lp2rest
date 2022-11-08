package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.CuentaUsuarioDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.CuentaUsuario;
import pe.edu.pucp.lp2rest.gestpersonas.model.Empleado;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;

public class CuentaUsuarioMySQL implements CuentaUsuarioDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(CuentaUsuario cuentaUsuario) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CUENTA_USUARIO(?,?,?)}");
            cs.setInt("_fid_empleado", cuentaUsuario.getIdUsuario());
            cs.setString("_user", cuentaUsuario.getUsuario());
            cs.setString("_password", cuentaUsuario.getContrasenia());

            cs.executeUpdate(); 
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(CuentaUsuario cuentaUsuario) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CUENTA_USUARIO(?,?,?,?)}");
            cs.setInt("_id_cuentaUsuario", cuentaUsuario.getIdUsuario());
            cs.setInt("_fid_empleado", cuentaUsuario.getEmpleado().getIdPersona());
            cs.setString("_user", cuentaUsuario.getUsuario());
            cs.setString("_password", cuentaUsuario.getContrasenia());
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idCuentaUsuario) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CUENTA_USUARIO(?)}");
            cs.setInt("_id_cuentaUsuario", idCuentaUsuario);
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<CuentaUsuario> listarTodas() {
        ArrayList<CuentaUsuario> cuentaUsuarios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_CUENTAS_USUARIO()");
            rs = cs.executeQuery();
            while(rs.next()){
                CuentaUsuario cuentaUsuario = new CuentaUsuario();
                
                cuentaUsuario.setIdUsuario(rs.getInt("id_cuentaUsuario"));
                cuentaUsuario.setUsuario(rs.getString("user"));
                cuentaUsuario.setContrasenia(rs.getString("password"));
                Empleado empleado = new Empleado();
                empleado.setIdPersona(rs.getInt("fid_empleado"));
                cuentaUsuario.setEmpleado(empleado);
                
                
                cuentaUsuarios.add(cuentaUsuario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return cuentaUsuarios;
    }

}
