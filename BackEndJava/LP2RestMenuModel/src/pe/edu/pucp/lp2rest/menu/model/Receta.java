/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2rest.menu.model;

import pe.edu.pucp.lp2rest.almacen.model.Insumo;

public class Receta {
    private ItemVenta itemVenta;
    private Insumo insumo;
    private double cantidad;

    public ItemVenta getItemVenta() {
        return itemVenta;
    }

    public void setItemVenta(ItemVenta itemVenta) {
        this.itemVenta = itemVenta;
    }

    public Insumo getInsumo() {
        return insumo;
    }

    public void setInsumo(Insumo insumo) {
        this.insumo = insumo;
    }

    public double getCantidad() {
        return cantidad;
    }

    public void setCantidad(double cantidad) {
        this.cantidad = cantidad;
    }
    
    
}
