package pe.edu.pucp.lp2rest.gestpersonas.mysql;

import java.awt.Panel;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Properties;
import java.util.concurrent.ThreadLocalRandom;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import javax.swing.JOptionPane;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.gestpersonas.dao.CuentaUsuarioDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.CuentaUsuario;
import pe.edu.pucp.lp2rest.gestpersonas.model.Empleado;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;

public class CuentaUsuarioMySQL implements CuentaUsuarioDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    public static String cadenaAleatoria(int longitud) {
        // El banco de caracteres
        String banco = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        // La cadena en donde iremos agregando un carácter aleatorio
        String cadena = "";
        for (int x = 0; x < longitud; x++) {
            int indiceAleatorio = numeroAleatorioEnRango(0, banco.length() - 1);
            char caracterAleatorio = banco.charAt(indiceAleatorio);
            cadena += caracterAleatorio;
        }
        return cadena;
    }

    public static int numeroAleatorioEnRango(int minimo, int maximo) {
        // nextInt regresa en rango pero con límite superior exclusivo, por eso sumamos 1
        return ThreadLocalRandom.current().nextInt(minimo, maximo + 1);
    }

    @Override
    public int insertar(CuentaUsuario cuentaUsuario) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CUENTA_USUARIO(?,?,?,?)}");
            cs.setInt("_fid_empleado", cuentaUsuario.getIdUsuario());
            cs.setString("_user", cuentaUsuario.getUsuario());
            cs.setString("_password", cuentaUsuario.getContrasenia());
            cs.setString("_tipo_empleado", String.valueOf(cuentaUsuario.getTipoEmpleado()));
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
            cs = con.prepareCall("{call MODIFICAR_CUENTA_USUARIO(?,?,?,?,?)}");
            cs.setInt("_id_cuentaUsuario", cuentaUsuario.getIdUsuario());
            cs.setInt("_fid_empleado", cuentaUsuario.getEmpleado().getIdPersona());
            cs.setString("_user", cuentaUsuario.getUsuario());
            cs.setString("_password", cuentaUsuario.getContrasenia());
            cs.setString("_tipo_empleado", String.valueOf(cuentaUsuario.getTipoEmpleado()));
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
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call LISTAR_CUENTAS_USUARIO()");
            rs = cs.executeQuery();
            while (rs.next()) {
                CuentaUsuario cuentaUsuario = new CuentaUsuario();

                cuentaUsuario.setIdUsuario(rs.getInt("id_cuentaUsuario"));
                cuentaUsuario.setUsuario(rs.getString("user"));
                cuentaUsuario.setContrasenia(rs.getString("password"));
                cuentaUsuario.setTipoEmpleado(rs.getString("tipo_empleado").charAt(0));
                Empleado empleado = new Empleado();
                empleado.setIdPersona(rs.getInt("fid_empleado"));
                cuentaUsuario.setEmpleado(empleado);

                cuentaUsuarios.add(cuentaUsuario);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                rs.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return cuentaUsuarios;
    }

    @Override
    public CuentaUsuario verificar(CuentaUsuario cuentaUsuario) {
        int resultado = 0;
        CuentaUsuario cuentaUsuarioRetorno = new CuentaUsuario();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call VERIFICAR_CUENTA_USUARIO(?,?)");
            cs.setString("_user", cuentaUsuario.getUsuario());
            cs.setString("_password", cuentaUsuario.getContrasenia());
            rs = cs.executeQuery();
            if (rs.next()) {
                cuentaUsuarioRetorno.setIdUsuario(rs.getInt("id_cuentaUsuario"));
                cuentaUsuarioRetorno.setUsuario(rs.getString("user"));
                cuentaUsuarioRetorno.setContrasenia(rs.getString("password"));
                cuentaUsuarioRetorno.setActivo(true);
                cuentaUsuarioRetorno.setTipoEmpleado(rs.getString("tipo_empleado").charAt(0));
                Empleado empleado = new Empleado();
                empleado.setIdPersona(rs.getInt("fid_empleado"));
                cuentaUsuarioRetorno.setEmpleado(empleado);
                resultado = 1;
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                rs.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return cuentaUsuarioRetorno;
    }

    @Override
    public int enviarCorreoRecuperacion(String correoReceptor) {
        int resultado = 0, cuentaUsuario = 0;
        String codigoVerificacion = cadenaAleatoria(10);

        Properties propiedad = new Properties();
        propiedad.setProperty("mail.smtp.host", "smtp.gmail.com");
        propiedad.setProperty("mail.smtp.starttls.enable", "true");
        propiedad.setProperty("mail.smtp.port", "587");
        propiedad.setProperty("mail.smtp.auth", "true");

        Session sesion = Session.getDefaultInstance(propiedad);
        String correoEnvia = "lp2rest@gmail.com";
        String contrasena = "ewgujuqszibdkzhp";
        String receptor = correoReceptor;
        String asunto = "Recuperación de contraseña LP2Rest";
        String mensaje = "Por favor, introduzca el siguiente codigo de verificación"
                + " en la interfaz: " + codigoVerificacion;

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CODIGO_VERIFICACION(?,?,?)}");
            cs.registerOutParameter("_id_cuentaUsuario", java.sql.Types.INTEGER);
            cs.setString("_correo_receptor", correoReceptor);
            cs.setString("_codigo_verificacion", codigoVerificacion);

            cs.executeUpdate();
            cuentaUsuario = cs.getInt("_id_cuentaUsuario");
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
            return 0;
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }

        resultado = 0;
        MimeMessage mail = new MimeMessage(sesion);
        try {
            mail.setFrom(new InternetAddress(correoEnvia));
            mail.addRecipient(Message.RecipientType.TO, new InternetAddress(receptor));
            mail.setSubject(asunto);
            mail.setText(mensaje);

            Transport transportar = sesion.getTransport("smtp");
            transportar.connect(correoEnvia, contrasena);
            transportar.sendMessage(mail, mail.getRecipients(Message.RecipientType.TO));
            transportar.close();
            resultado = cuentaUsuario;
            //JOptionPane.showMessageDialog(null, "Listo, revise su correoReceptor");

        } catch (MessagingException ex) {
            Logger.getLogger(Panel.class.getName()).log(Level.SEVERE, null, ex);
        }
        return resultado;

    }

    @Override
    public int verificarCodigoVerificacion(int idCuentaUsuario, String codigo) {
        int resultado = 0;
        String codigoObtenido = "";
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call OBTENER_CODIGO_VERIFICACION(?,?)");
            cs.registerOutParameter("_codigo_verificacion", java.sql.Types.VARCHAR);
            cs.setInt("_id_cuentaUsuario", idCuentaUsuario);
            rs = cs.executeQuery();
            codigoObtenido = cs.getString("_codigo_verificacion");

            if (codigo.equals(codigoObtenido)) {
                resultado = 1;
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                rs.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }

        return resultado;
    }

    @Override
    public int actualizarContrasenia(int idCuentaUsuario, String contrasenia) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ACTUALIZAR_CONTRASENIA_CUENTA_USUARIO(?,?)");
            cs.setInt("_id_cuentaUsuario", idCuentaUsuario);
            cs.setString("_password", contrasenia);
            rs = cs.executeQuery();

            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                rs.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int enviarCorreoBienvenida(String correoReceptor, String nombre, String apellidoPaterno,
            String usuario, String contraseniaUser) {
        int resultado = 0;

        Properties propiedad = new Properties();
        propiedad.setProperty("mail.smtp.host", "smtp.gmail.com");
        propiedad.setProperty("mail.smtp.starttls.enable", "true");
        propiedad.setProperty("mail.smtp.port", "587");
        propiedad.setProperty("mail.smtp.auth", "true");

        Session sesion = Session.getDefaultInstance(propiedad);
        String correoEnvia = "lp2rest@gmail.com";
        String contrasena = "ewgujuqszibdkzhp";
        String receptor = correoReceptor;
        String asunto = "Bienvenid@ a LP2Rest!";
        String mensaje = "Hola " + nombre + " " + apellidoPaterno + "!\n"
                + "Usa los siguientes datos para iniciar sesión\n"
                + "Usuario    : " + usuario + "\n"
                + "Contraseña : " + contraseniaUser + "\n\n"
                + "Se le recomienda cambiar la contraseña por defecto.";

        MimeMessage mail = new MimeMessage(sesion);
        try {
            mail.setFrom(new InternetAddress(correoEnvia));
            mail.addRecipient(Message.RecipientType.TO, new InternetAddress(receptor));
            mail.setSubject(asunto);
            mail.setText(mensaje);

            Transport transportar = sesion.getTransport("smtp");
            transportar.connect(correoEnvia, contrasena);
            transportar.sendMessage(mail, mail.getRecipients(Message.RecipientType.TO));
            transportar.close();
            resultado = 1;

        } catch (MessagingException ex) {
            Logger.getLogger(Panel.class.getName()).log(Level.SEVERE, null, ex);
        }
        return resultado;
    }
}
