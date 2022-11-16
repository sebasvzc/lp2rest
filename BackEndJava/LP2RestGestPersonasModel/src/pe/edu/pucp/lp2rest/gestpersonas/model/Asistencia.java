package pe.edu.pucp.lp2rest.gestpersonas.model;

import java.sql.Time;
import java.time.LocalTime;
import java.util.Date;

public class Asistencia {

    //atributos
    private int idCuentaUsuario;
    private String fechaIngreso;
    private String horaIngreso;
    private String fechaSalida;
    private String horaSalida;
    
    //constructor
    public Asistencia() {
    }

    //setters y getters
    public String getFechaIngreso() {
        return fechaIngreso;
    }

    public void setFechaIngreso(String fechaIngreso) {
        this.fechaIngreso = fechaIngreso;
    }

    public String getHoraIngreso() {
        return horaIngreso;
    }

    public void setHoraIngreso(String horaIngreso) {
        this.horaIngreso = horaIngreso;
    }

    public String getFechaSalida() {
        return fechaSalida;
    }

    public void setFechaSalida(String fechaSalida) {
        this.fechaSalida = fechaSalida;
    }

    public String getHoraSalida() {
        return horaSalida;
    }

    public void setHoraSalida(String horaSalida) {
        this.horaSalida = horaSalida;
    }

    //metodos

    /**
     * @return the idCuentaUsuario
     */
    public int getIdCuentaUsuario() {
        return idCuentaUsuario;
    }

    /**
     * @param idCuentaUsuario the idCuentaUsuario to set
     */
    public void setIdCuentaUsuario(int idCuentaUsuario) {
        this.idCuentaUsuario = idCuentaUsuario;
    }
}
