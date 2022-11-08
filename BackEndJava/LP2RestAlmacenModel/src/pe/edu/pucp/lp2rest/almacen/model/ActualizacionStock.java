/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2rest.almacen.model;

import java.util.Date;
import pe.edu.pucp.lp2rest.gestpersonas.model.Chef;

/**
 *
 * @author Usuario
 */
public class ActualizacionStock {
    private Insumo insumo;
    private Chef chef;
    private boolean activo;
    private Date fechaRegistro;
    private double cantidad;
    public ActualizacionStock(Insumo insumo,Chef chef,Date fechaRegistro,double cantidad, boolean activo) {
        this.insumo=insumo;
        this.chef=chef;
        this.fechaRegistro=fechaRegistro;
        this.cantidad=cantidad;
        this.activo=activo;
    }
    
    public ActualizacionStock() {
    }
    
    public Insumo getInsumo() {
        return insumo;
    }

    public void setInsumo(Insumo insumo) {
        this.insumo = insumo;
    }
     public Chef getChef() {
        return chef;
    }

    public void setChef(Chef chef) {
        this.chef = chef;
    }
    
    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public Date getFechaRegistron() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }
      public double getCantidad() {
        return cantidad;
    }

    public void setCantidad(double cantidad) {
        this.cantidad = cantidad;
    }
}
