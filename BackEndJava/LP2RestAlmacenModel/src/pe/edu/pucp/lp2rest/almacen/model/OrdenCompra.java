package pe.edu.pucp.lp2rest.almacen.model;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2rest.gestpersonas.model.Proveedor;

public class OrdenCompra {

    //atributos
    private Proveedor proveedor;
    private ArrayList<LineaOrdenCompra> lineasOrdenCompra;
    private int idOrdenCompra;
    private double total;
    private Date fechaHoraCreacion;
    private Date fechaHoraCumplimiento;
    private boolean activo;
    private String estado;
    private String descripcion;

    //constructor
    public OrdenCompra(Proveedor proveedor,double total,Date fechaHoraCreacion,Date fechaHoraCumplimiento,boolean activo,String estado,String descripcion) {
        this.proveedor=proveedor;
        this.total=total;
        this.fechaHoraCreacion=fechaHoraCreacion;
        this.fechaHoraCumplimiento=fechaHoraCumplimiento;
        this.activo=activo;
        this.estado=estado;
        this.descripcion= descripcion;
    }
    public OrdenCompra() {
        
    }
    //getters y setters
    public Proveedor getProveedor() {
        return proveedor;
    }

    public void setProveedor(Proveedor proveedor) {
        this.proveedor = proveedor;
    }


    public ArrayList<LineaOrdenCompra> getLineasOrdenCompra() {
        return lineasOrdenCompra;
    }

    public void setLineasOrdenCompra(ArrayList<LineaOrdenCompra> lineasOrdenCompra) {
        this.lineasOrdenCompra = lineasOrdenCompra;
    }


    public int getIdOrdenCompra() {
        return idOrdenCompra;
    }

    public void setIdOrdenCompra(int idOrdenCompra) {
        this.idOrdenCompra = idOrdenCompra;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }

    public Date getFechaHoraCreacion() {
        return fechaHoraCreacion;
    }

    public void setFechaHoraCreacion(Date fechaHoraCreacion) {
        this.fechaHoraCreacion = fechaHoraCreacion;
    }
    public Date getFechaHoraCumplimiento() {
        return fechaHoraCumplimiento;
    }

    public void setFechaHoraCumplimiento(Date fechaHoraCumplimiento) {
        this.fechaHoraCumplimiento = fechaHoraCumplimiento;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }
    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    //metodos
    public void calcularTotal() {}
    public void agregarLineaOrdenCompra(LineaOrdenCompra linOrdCompra) {}
    public void eliminarLineaOrdenCompra(LineaOrdenCompra linOrdCompra) {}
}
