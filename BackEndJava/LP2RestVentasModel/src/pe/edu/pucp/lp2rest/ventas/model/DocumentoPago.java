package pe.edu.pucp.lp2rest.ventas.model;

import java.util.Date;

public class DocumentoPago {

    //atributos
    private int idDocumentoPago;
    private String RUC_empresa;
    private String direccionFiscal;
    private String tipoPago;
    private double total;
    private Date fechaEmision;
    private boolean activo;
    private int numero;
    private String serie;
    private double montoRecibido;
    private String numeroAutorizacion;
    private String metodoPago;
    private OrdenVenta ordenVenta;

    private double igv;
    private Date fechaPago;
    private String ruc;
    private String razonSocial;

    // constructor
    public DocumentoPago() {

    }

    public DocumentoPago(String RUC_empresa, String direccionFiscal,
            String tipoPago, double total, Date fechaEmision, boolean activo, int numero,
            String serie, double montoRecibido, String numeroAutorizacion,
            String metodoPago, OrdenVenta ordenVenta, double igv, Date fechaPago,
            String ruc, String razonSocial) {
        this.RUC_empresa = RUC_empresa;
        this.direccionFiscal = direccionFiscal;
        this.tipoPago = tipoPago;
        this.total = total;
        this.fechaEmision = fechaEmision;
        this.activo = activo;
        this.numero = numero;
        this.serie = serie;
        this.montoRecibido = montoRecibido;
        this.numeroAutorizacion = numeroAutorizacion;
        this.metodoPago = metodoPago;
        this.ordenVenta = ordenVenta;
        this.igv = igv;
        this.fechaPago = fechaPago;
        this.ruc = ruc;
        this.razonSocial = razonSocial;
    }

    // getters y setters
    public int getIdDocumentoPago() {
        return idDocumentoPago;
    }

    public void setIdDocumentoPago(int idDocumentoPago) {
        this.idDocumentoPago = idDocumentoPago;
    }

    public String getRUC_empresa() {
        return RUC_empresa;
    }

    public void setRUC_empresa(String RUC_empresa) {
        this.RUC_empresa = RUC_empresa;
    }

    public String getDireccionFiscal() {
        return direccionFiscal;
    }

    public void setDireccionFiscal(String direccionFiscal) {
        this.direccionFiscal = direccionFiscal;
    }

    public String getTipoPago() {
        return tipoPago;
    }

    public void setTipoPago(String tipoPago) {
        this.tipoPago = tipoPago;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }

    public Date getFechaEmision() {
        return fechaEmision;
    }

    public void setFechaEmision(Date fechaEmision) {
        this.fechaEmision = fechaEmision;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public String getSerie() {
        return serie;
    }

    public void setSerie(String serie) {
        this.serie = serie;
    }

    public double getMontoRecibido() {
        return montoRecibido;
    }

    public void setMontoRecibido(double montoRecibido) {
        this.montoRecibido = montoRecibido;
    }

    public String getNumeroAutorizacion() {
        return numeroAutorizacion;
    }

    public void setNumeroAutorizacion(String numeroAutorizacion) {
        this.numeroAutorizacion = numeroAutorizacion;
    }

    public String getMetodoPago() {
        return metodoPago;
    }

    public void setMetodoPago(String metodoPago) {
        this.metodoPago = metodoPago;
    }

    public OrdenVenta getOrdenVenta() {
        return ordenVenta;
    }

    public void setOrdenVenta(OrdenVenta ordenVenta) {
        this.ordenVenta = ordenVenta;
    }

    // metodos
//    public abstract void imprimir();
//    public abstract void enviarCorreo();
//    public abstract void enviarSMS();
//    public abstract void enviarWhatsapp();
    public double getIgv() {
        return igv;
    }

    public void setIgv(double igv) {
        this.igv = igv;
    }

    public Date getFechaPago() {
        return fechaPago;
    }

    public void setFechaPago(Date FechaPago) {
        this.fechaPago = FechaPago;
    }

    public String getRuc() {
        return ruc;
    }

    public void setRuc(String ruc) {
        this.ruc = ruc;
    }

    public String getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }
}
