package pe.edu.pucp.lp2rest.menu.model;

import pe.edu.pucp.lp2rest.almacen.model.Insumo;

public class Receta {
    private int idReceta;
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
    
    /**
     * @return the idReceta
     */
    public int getIdReceta() {
        return idReceta;
    }

    /**
     * @param idReceta the idReceta to set
     */
    public void setIdReceta(int idReceta) {
        this.idReceta = idReceta;
    }
    
}
