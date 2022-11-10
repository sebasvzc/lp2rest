package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.util.ArrayList;

public class CuentaUsuario {

    //atributos
    private Empleado empleado;
    private ArrayList<Asistencia> asistencias;

    private int idUsuario;
    private String usuario;
    private String contrasenia;
    private char tipoEmpleado;
    private boolean activo;

    //constructor
    public CuentaUsuario() {
    }

    //getters y setters
    public char getTipoEmpleado() {
        return tipoEmpleado;
    }

    public void setTipoEmpleado(char tipoEmpleado) {
        this.tipoEmpleado = tipoEmpleado;
    }

    public Empleado getEmpleado() {
        return empleado;
    }

    public void setEmpleado(Empleado empleado) {
        this.empleado = empleado;
    }

    public ArrayList<Asistencia> getAsistencias() {
        return asistencias;
    }

    public void setAsistencias(ArrayList<Asistencia> asistencias) {
        this.asistencias = asistencias;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getContrasenia() {
        return contrasenia;
    }

    public void setContrasenia(String contrasenia) {
        this.contrasenia = contrasenia;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    //metodos
}
