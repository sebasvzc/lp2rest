package pe.edu.pucp.lp2rest.almacen.model;

import java.util.Date;

public class LineaOrdenCompra {

    //metodos
    private Insumo insumo;
    private OrdenCompra ordenCompra;
    private int idLineaOrdenCompra;
    private double precioUnitario;
    private double subtotal;
    private double cantidad;
    private Date fechaVencimiento;

    //constructor
    public LineaOrdenCompra() {
    }
    public LineaOrdenCompra(Insumo insumo,OrdenCompra ordenCompra,double precioUnitario,double subtotal,double cantidad,Date fechaVencimiento) {
        this.insumo=insumo;
        this.ordenCompra=ordenCompra;
        this.precioUnitario=precioUnitario;
        this.subtotal=subtotal;
        this.cantidad=cantidad;
        this.fechaVencimiento=fechaVencimiento;
    }
    //getters y setters
    public Insumo getInsumo() {
        return insumo;
    }

    public void setInsumo(Insumo insumo) {
        this.insumo = insumo;
    }

    public OrdenCompra getOrdenCompra() {
        return ordenCompra;
    }

    public void setOrdenCompra(OrdenCompra ordenCompra) {
        this.ordenCompra = ordenCompra;
    }

    public int getIdLineaOrdenCompra() {
        return idLineaOrdenCompra;
    }

    public void setIdLineaOrdenCompra(int idLineaOrdenCompra) {
        this.idLineaOrdenCompra = idLineaOrdenCompra;
    }

    public double getPrecioUnitario() {
        return precioUnitario;
    }

    public void setPrecioUnitario(double precioUnitario) {
        this.precioUnitario = precioUnitario;
    }

    public double getSubtotal() {
        return subtotal;
    }

    public void setSubtotal(double total) {
        this.subtotal = total;
    }

    public Date getFechaVencimiento() {
        return fechaVencimiento;
    }

    public void setFechaVencimiento(Date fechaVencimiento) {
        this.fechaVencimiento = fechaVencimiento;
    }

    public double getCantidad() {
        return cantidad;
    }

    public void setCantidad(double cantidad) {
        this.cantidad = cantidad;
    }

    //metodos
    
    
}
