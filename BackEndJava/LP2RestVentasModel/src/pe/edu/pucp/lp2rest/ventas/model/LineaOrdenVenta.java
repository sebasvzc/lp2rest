package pe.edu.pucp.lp2rest.ventas.model;

import pe.edu.pucp.lp2rest.menu.model.ItemVenta;
import java.util.Date;

public class LineaOrdenVenta {

    //atributos
    private int idLineaOrdenVenta;
    private double subtotal;
    private Date fechaRegistro;
    private boolean activo;
    private boolean promocion;
    private int cantidadVenta;
    private OrdenVenta ordenVenta;
    private ItemVenta itemVenta;
    private double descuento;
    private double montoDescontado;
    private int cantidadVendida;

    //contructor
    public LineaOrdenVenta() {

    }

    //getters y setters
    public int getIdLineaOrdenVenta() {
        return idLineaOrdenVenta;
    }

    public void setIdLineaOrdenVenta(int idLineaOrdenVenta) {
        this.idLineaOrdenVenta = idLineaOrdenVenta;
    }

    public double getSubtotal() {
        return subtotal;
    }

    public void setSubtotal(double subtotal) {
        this.subtotal = subtotal;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public boolean isPromocion() {
        return promocion;
    }

    public void setPromocion(boolean promocion) {
        this.promocion = promocion;
    }

    public int getCantidadVenta() {
        return cantidadVenta;
    }

    public void setCantidadVenta(int cantidadVenta) {
        this.cantidadVenta = cantidadVenta;
    }

    public OrdenVenta getOrdenVenta() {
        return ordenVenta;
    }

    public void setOrdenVenta(OrdenVenta ordenVenta) {
        this.ordenVenta = ordenVenta;
    }

    public ItemVenta getItemVenta() {
        return itemVenta;
    }

    public void setItemVenta(ItemVenta itemVenta) {
        this.itemVenta = itemVenta;
    }

    public double getDescuento() {
        return descuento;
    }

    public void setDescuento(double descuento) {
        this.descuento = descuento;
    }

    public double getMontoDescontado() {
        return montoDescontado;
    }

    public void setMontoDescontado(double montoDescontado) {
        this.montoDescontado = montoDescontado;
    }

    public int getCantidadVendida() {
        return cantidadVendida;
    }

    public void setCantidadVendida(int cantidadVendida) {
        this.cantidadVendida = cantidadVendida;
    }

    //metodos
}
