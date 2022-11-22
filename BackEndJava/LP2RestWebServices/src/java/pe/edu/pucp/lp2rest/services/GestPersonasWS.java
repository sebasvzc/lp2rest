package pe.edu.pucp.lp2rest.services;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2rest.eventos.dao.EventoDAO;
import pe.edu.pucp.lp2rest.eventos.model.Evento;
import pe.edu.pucp.lp2rest.eventos.mysql.EventoMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.dao.AdministradorDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ArtistaDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.AsistenciaDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.CajeroDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ChefDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ClienteDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.CuentaUsuarioDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.EmpleadoDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.MeseroDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ProveedorDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.RecepcionistaDAO;
import pe.edu.pucp.lp2rest.gestpersonas.dao.ReclamoDAO;
import pe.edu.pucp.lp2rest.gestpersonas.model.Administrador;
import pe.edu.pucp.lp2rest.gestpersonas.model.Artista;
import pe.edu.pucp.lp2rest.gestpersonas.model.Asistencia;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cajero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Chef;
import pe.edu.pucp.lp2rest.gestpersonas.model.Cliente;
import pe.edu.pucp.lp2rest.gestpersonas.model.CuentaUsuario;
import pe.edu.pucp.lp2rest.gestpersonas.model.Empleado;
import pe.edu.pucp.lp2rest.gestpersonas.model.Mesero;
import pe.edu.pucp.lp2rest.gestpersonas.model.Proveedor;
import pe.edu.pucp.lp2rest.gestpersonas.model.Recepcionista;
import pe.edu.pucp.lp2rest.gestpersonas.model.Reclamo;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.AdministradorMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.ArtistaMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.AsistenciaMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.CajeroMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.ChefMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.ClienteMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.CuentaUsuarioMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.EmpleadoMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.MeseroMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.ProveedorMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.RecepcionistaMySQL;
import pe.edu.pucp.lp2rest.gestpersonas.mysql.ReclamoMySQL;

@WebService(serviceName = "GestPersonasWS")
public class GestPersonasWS {

    private EventoDAO daoEvento = new EventoMySQL();
    private ClienteDAO daoCliente = new ClienteMySQL();
    private ArtistaDAO daoArtista = new ArtistaMySQL();
    private AdministradorDAO daoAdministrador = new AdministradorMySQL();
    private CajeroDAO daoCajero = new CajeroMySQL();
    private ChefDAO daoChef = new ChefMySQL();
    private MeseroDAO daoMesero = new MeseroMySQL();
    private RecepcionistaDAO daoRecepcionista = new RecepcionistaMySQL();
    private CuentaUsuarioDAO daoCuentaUsuario = new CuentaUsuarioMySQL();
    private AsistenciaDAO daoAsistencia = new AsistenciaMySQL();
    private ReclamoDAO daoReclamo = new ReclamoMySQL();
    private EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
    private ProveedorDAO daoProveedor = new ProveedorMySQL();

    @WebMethod(operationName = "listarTodasEventos")
    public ArrayList<Evento> listarTodasEventos() {
        ArrayList<Evento> eventos = null;
        try {
            eventos = daoEvento.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return eventos;
    }

    @WebMethod(operationName = "buscarEventoPorID")
    public Evento buscarEventoPorID(@WebParam(name = "idEvento") int idEvento) {
        Evento evento = null;
        try {
            evento = daoEvento.buscarEventoPorID(idEvento);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return evento;
    }

    @WebMethod(operationName = "InsertarEvento")
    public int InsertarEvento(@WebParam(name = "evento") Evento evento) {
        int resultado = 0;
        try {
            resultado = daoEvento.insertar(evento);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarEvento")
    public int ModificarEvento(@WebParam(name = "evento") Evento evento) {
        int resultado = 0;
        try {
            resultado = daoEvento.modificar(evento);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarEvento")
    public int EliminarEvento(@WebParam(name = "idEvento") int idEvento) {
        int resultado = 0;
        try {
            resultado = daoEvento.eliminar(idEvento);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "FiltrarEventos")
    public ArrayList<Evento> FiltrarEventos(@WebParam(name = "nombre_evento") String nombre_evento,
            @WebParam(name = "fid_artista") int fid_artista,
            @WebParam(name = "fecha_inicio") Date fecha_inicio, @WebParam(name = "fecha_fin") Date fecha_fin,
            @WebParam(name = "monto_min") double monto_min, @WebParam(name = "monto_max") double monto_max) {

        ArrayList<Evento> eventos = null;
        try {
            eventos = daoEvento.FiltrarEventos(nombre_evento, fid_artista, fecha_inicio,
                    fecha_fin, monto_min, monto_max);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return eventos;
    }

    @WebMethod(operationName = "listarTodasArtistas")
    public ArrayList<Artista> listarTodasArtistas() {
        ArrayList<Artista> artistas = null;
        try {
            artistas = daoArtista.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return artistas;
    }

    @WebMethod(operationName = "listarArtistasPorNombre")
    public ArrayList<Artista> listarArtistasPorNombre(String nombre) {
        ArrayList<Artista> artistas = null;
        try {
            artistas = daoArtista.listarPorNombre(nombre);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return artistas;
    }

    @WebMethod(operationName = "InsertarArtista")
    public int InsertarArtista(@WebParam(name = "artista") Artista artista) {
        int resultado = 0;
        try {
            resultado = daoArtista.insertar(artista);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarArtista")
    public int ModificarArtista(@WebParam(name = "artista") Artista artista) {
        int resultado = 0;
        try {
            resultado = daoArtista.modificar(artista);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarArtista")
    public int EliminarArtista(@WebParam(name = "idArtista") int idArtista) {
        int resultado = 0;
        try {
            resultado = daoArtista.eliminar(idArtista);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasClientes")
    public ArrayList<Cliente> listarTodasClientes() {
        ArrayList<Cliente> clientes = null;
        try {
            clientes = daoCliente.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return clientes;
    }

    @WebMethod(operationName = "filtrarClientes")
    public ArrayList<Cliente> filtrarClientes(
            @WebParam(name = "dni") String dni,
            @WebParam(name = "email") String email,
            @WebParam(name = "nombres") String nombres, @WebParam(name = "apellidos") String apellidos,
            @WebParam(name = "telefono") String telefono) {
        ArrayList<Cliente> clientes = null;
        try {
            clientes = daoCliente.filtrarClientes(dni, email, nombres, apellidos, telefono);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return clientes;

        /*public ArrayList<Evento> FiltrarEventos(@WebParam(name = "nombre_evento") String nombre_evento, 
            @WebParam(name = "fid_artista") int fid_artista, 
            @WebParam(name = "fecha_inicio") Date fecha_inicio, @WebParam(name = "fecha_fin") Date fecha_fin,
            @WebParam(name = "monto_min") double monto_min, @WebParam(name = "monto_max") double monto_max) {
        
        ArrayList<Evento> eventos = null;
        try{
            eventos = daoEvento.FiltrarEventos(nombre_evento, fid_artista, fecha_inicio, 
                    fecha_fin, monto_min, monto_max);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return eventos;
        }*/
    }

    @WebMethod(operationName = "InsertarCliente")
    public int InsertarCliente(@WebParam(name = "cliente") Cliente cliente) {
        int resultado = 0;
        try {
            resultado = daoCliente.insertar(cliente);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarCliente")
    public int ModificarCliente(@WebParam(name = "cliente") Cliente cliente) {
        int resultado = 0;
        try {
            resultado = daoCliente.modificar(cliente);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarCliente")
    public int EliminarCliente(@WebParam(name = "idCliente") int idCliente) {
        int resultado = 0;
        try {
            resultado = daoCliente.eliminar(idCliente);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasAdministradores")
    public ArrayList<Administrador> listarTodasAdministradores() {
        ArrayList<Administrador> administradores = null;
        try {
            administradores = daoAdministrador.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return administradores;
    }

    @WebMethod(operationName = "InsertarAdministrador")
    public int InsertarAdministrador(@WebParam(name = "administrador") Administrador administrador) {
        int resultado = 0;
        try {
            resultado = daoAdministrador.insertar(administrador);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarAdministrador")
    public int ModificarAdministrador(@WebParam(name = "administrador") Administrador administrador) {
        int resultado = 0;
        try {
            resultado = daoAdministrador.modificar(administrador);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarAdministrador")
    public int EliminarAdministrador(@WebParam(name = "idAdministrador") int idAdministrador) {
        int resultado = 0;
        try {
            resultado = daoAdministrador.eliminar(idAdministrador);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasCajeros")
    public ArrayList<Cajero> listarTodasCajeros() {
        ArrayList<Cajero> cajeros = null;
        try {
            cajeros = daoCajero.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cajeros;
    }

    @WebMethod(operationName = "InsertarCajero")
    public int InsertarCajero(@WebParam(name = "cajero") Cajero cajero) {
        int resultado = 0;
        try {
            resultado = daoCajero.insertar(cajero);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarCajero")
    public int ModificarCajero(@WebParam(name = "cajero") Cajero cajero) {
        int resultado = 0;
        try {
            resultado = daoCajero.modificar(cajero);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarCajero")
    public int EliminarCajero(@WebParam(name = "idCajero") int idCajero) {
        int resultado = 0;
        try {
            resultado = daoCajero.eliminar(idCajero);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasChefs")
    public ArrayList<Chef> listarTodasChefs() {
        ArrayList<Chef> chefs = null;
        try {
            chefs = daoChef.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return chefs;
    }

    @WebMethod(operationName = "InsertarChef")
    public int InsertarChef(@WebParam(name = "chef") Chef chef) {
        int resultado = 0;
        try {
            resultado = daoChef.insertar(chef);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarChef")
    public int ModificarChef(@WebParam(name = "chef") Chef chef) {
        int resultado = 0;
        try {
            resultado = daoChef.modificar(chef);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarChef")
    public int EliminarChef(@WebParam(name = "idChef") int idChef) {
        int resultado = 0;
        try {
            resultado = daoChef.eliminar(idChef);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasMeseros")
    public ArrayList<Mesero> listarTodasMeseros() {
        ArrayList<Mesero> meseros = null;
        try {
            meseros = daoMesero.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return meseros;
    }

    @WebMethod(operationName = "InsertarMesero")
    public int InsertarMesero(@WebParam(name = "mesero") Mesero mesero) {
        int resultado = 0;
        try {
            resultado = daoMesero.insertar(mesero);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarMesero")
    public int ModificarMesero(@WebParam(name = "mesero") Mesero mesero) {
        int resultado = 0;
        try {
            resultado = daoMesero.modificar(mesero);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarMesero")
    public int EliminarMesero(@WebParam(name = "idMesero") int idMesero) {
        int resultado = 0;
        try {
            resultado = daoMesero.eliminar(idMesero);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasRecepcionistas")
    public ArrayList<Recepcionista> listarTodasRecepcionistas() {
        ArrayList<Recepcionista> recepcionistas = null;
        try {
            recepcionistas = daoRecepcionista.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return recepcionistas;
    }

    @WebMethod(operationName = "InsertarRecepcionista")
    public int InsertarRecepcionista(@WebParam(name = "recepcionista") Recepcionista recepcionista) {
        int resultado = 0;
        try {
            resultado = daoRecepcionista.insertar(recepcionista);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarRecepcionista")
    public int ModificarRecepcionista(@WebParam(name = "recepcionista") Recepcionista recepcionista) {
        int resultado = 0;
        try {
            resultado = daoRecepcionista.modificar(recepcionista);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarRecepcionista")
    public int EliminarRecepcionista(@WebParam(name = "idRecepcionista") int idRecepcionista) {
        int resultado = 0;
        try {
            resultado = daoRecepcionista.eliminar(idRecepcionista);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "InsertarCuentaUsuario")
    public int InsertarCuentaUsuario(@WebParam(name = "cuentaUsuario") CuentaUsuario cuentaUsuario) {
        int resultado = 0;
        try {
            resultado = daoCuentaUsuario.insertar(cuentaUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarCuentaUsuario")
    public int ModificarCuentaUsuario(@WebParam(name = "cuentaUsuario") CuentaUsuario cuentaUsuario) {
        int resultado = 0;
        try {
            resultado = daoCuentaUsuario.modificar(cuentaUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "verificarCuentaUsuario")
    public CuentaUsuario verificarCuentaUsuario(@WebParam(name = "cuentaUsuario") CuentaUsuario cuentaUsuario) {
        CuentaUsuario cuentaUsuarioRetorno = null;
        try {
            cuentaUsuarioRetorno = daoCuentaUsuario.verificar(cuentaUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cuentaUsuarioRetorno;
    }

    @WebMethod(operationName = "validarCodigoCuentaUsuario")
    public int validarCodigoCuentaUsuario(@WebParam(name = "idCuentaUsuario") int idCuentaUsuario,
            @WebParam(name = "codVerificacion") String codVerificacion) {
        int resultado = 0;
        try {
            resultado
                    = daoCuentaUsuario.verificarCodigoVerificacion(idCuentaUsuario, codVerificacion);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "enviarCorreoRecuperacion")
    public int enviarCorreoRecuperacion(@WebParam(name = "correo") String correo) {
        int resultado = 0;
        try {
            resultado = daoCuentaUsuario.enviarCorreoRecuperacion(correo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "actualizarContraseniaCuentaUsuario")
    public int actualizarContraseniaCuentaUsuario(
            @WebParam(name = "idCuentaUsuario") int idCuentaUsuario,
            @WebParam(name = "contrasenia") String contrasenia) {
        int resultado = 0;
        try {
            resultado = daoCuentaUsuario.actualizarContrasenia(idCuentaUsuario, contrasenia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "insertarAsistencia")
    public int insertarAsistencia(@WebParam(name = "asistencia") Asistencia asistencia) {
        int resultado = 0;
        try {
            resultado = daoAsistencia.insertarAsistencia(asistencia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarAsistenciaSalida")
    public int modificarAsistenciaSalida(@WebParam(name = "id_asistencia")int id_asistencia,
            @WebParam(name = "fecha_fin") String fecha_fin,
            @WebParam(name = "hora_fin")String hora_fin){
        
        int resultado = 0;
        try {
            resultado = daoAsistencia.modificarAsistencia(id_asistencia,fecha_fin,hora_fin);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    

    @WebMethod(operationName = "filtrarPorDni")
    public Cliente filtrarPorDni(@WebParam(name = "dni") String dni) {
        Cliente cliente = null;
        try {
            cliente = daoCliente.listarPorDni(dni);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cliente;
    }

    @WebMethod(operationName = "InsertarReclamo")
    public int InsertarReclamo(@WebParam(name = "reclamo") Reclamo reclamo, @WebParam(name = "fechaRegistro") String fechaRegistro) {
        int resultado = 0;
        try {
            SimpleDateFormat formateador = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
            Date fechaR = formateador.parse(fechaRegistro);
            reclamo.setFechaRegistro(fechaR);
            resultado = daoReclamo.insertar(reclamo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ModificarReclamo")
    public int ModificarReclamo(@WebParam(name = "reclamo") Reclamo reclamo) {
        int resultado = 0;
        try {
            resultado = daoReclamo.modificar(reclamo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "EliminarReclamo")
    public int EliminarReclamo(@WebParam(name = "reclamo") Reclamo reclamo) {
        int resultado = 0;
        try {
            resultado = daoReclamo.eliminar(reclamo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "ListarTodosReclamos")
    public ArrayList<Reclamo> ListarTodosReclamos() {
        ArrayList<Reclamo> reclamos = null;
        try {
            reclamos = daoReclamo.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return reclamos;
    }

    @WebMethod(operationName = "ListarBusquedaReclamos")
    public ArrayList<Reclamo> ListarBusquedaReclamos(@WebParam(name = "cliNombre") String cliNombre, @WebParam(name = "cliApellido") String cliApellido,
            @WebParam(name = "empNombre") String empNombre, @WebParam(name = "empApellido") String empApellido,
            @WebParam(name = "adminNombre") String adminNombre, @WebParam(name = "adminApellido") String adminApellido,
            @WebParam(name = "fechaIni") String fechaIni, @WebParam(name = "fechaFin") String fechaFin,
            @WebParam(name = "estadoBuscado") int estadoBuscado) {
        ArrayList<Reclamo> reclamos = null;
        try {
            SimpleDateFormat formateador = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
            Date fechaI = formateador.parse(fechaIni);
            Date fechaF = formateador.parse(fechaFin);
            reclamos = daoReclamo.listarBusqueda(cliNombre, cliApellido, empNombre, empApellido, adminNombre, adminApellido, fechaI, fechaF, estadoBuscado);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return reclamos;
    }

    @WebMethod(operationName = "EliminarCuentaUsuario")
    public int EliminarCuentaUsuario(@WebParam(name = "idCuentaUsuario") int idCuentaUsuario) {
        int resultado = 0;
        try {
            resultado = daoCuentaUsuario.eliminar(idCuentaUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasCuentasUsuario")
    public ArrayList<CuentaUsuario> listarTodasCuentasUsuario() {
        ArrayList<CuentaUsuario> cuentasUsuario = null;
        try {
            cuentasUsuario = daoCuentaUsuario.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cuentasUsuario;
    }

    @WebMethod(operationName = "ListarTodosEmpleados")
    public ArrayList<Empleado> ListarTodosEmpleados() {
        ArrayList<Empleado> lsEmpleados = null;
        try {
            lsEmpleados = daoEmpleado.listarTodos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return lsEmpleados;
    }

    @WebMethod(operationName = "ListarEmpleadosPorNombre")
    public ArrayList<Empleado> ListarEmpleadosPorNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Empleado> lsEmpleados = null;
        try {
            lsEmpleados = daoEmpleado.listarPorNombre(nombre);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return lsEmpleados;
    }
    
    @WebMethod(operationName = "buscarXidCuentaUsuario")
    public Empleado buscarXidCuentaUsuario(@WebParam(name = "idCuentaUsuario") int idCuentaUsuario) {
        Empleado empleado = null;
        try {
            empleado = daoEmpleado.buscarXidCuentaUsuario(idCuentaUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return empleado;
    }
    
    @WebMethod(operationName = "ListarBusquedaEmpleados")
    public ArrayList<Empleado> ListarBusquedaEmpleados(
            @WebParam(name = "nombreEmp") String nombre,
            @WebParam(name = "apellidoEmp") String apellido,
            @WebParam(name = "empDNI") String dni,
            @WebParam(name = "empCargo") String cargo,
            @WebParam(name = "empFechaIni") String fechaIni,
            @WebParam(name = "empFechaFin") String fechaFin,
            @WebParam(name = "empSueldoIni") double sueldoIni,
            @WebParam(name = "empSueldoFin") double sueldoFin
    ) {
        ArrayList<Empleado> lsEmpleados = null;
        try {
            SimpleDateFormat formateador = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
            Date fechaI = formateador.parse(fechaIni);
            Date fechaF = formateador.parse(fechaFin);
            lsEmpleados = daoEmpleado.listarBusqueda(
                    nombre,
                    apellido,
                    dni,
                    cargo,
                    fechaI,
                    fechaF,
                    sueldoIni,
                    sueldoFin
            );
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return lsEmpleados;
    }

    @WebMethod(operationName = "listarProveedoresPorNombre")
    public ArrayList<Proveedor> listarProveedoresPorNombre(@WebParam(name = "nombre_proveedor") String nombre_proveedor) {
        ArrayList<Proveedor> proveedor = null;
        try {
            proveedor = daoProveedor.listarProveedorePorNombre(nombre_proveedor);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return proveedor;
    }

}
