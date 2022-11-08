package pe.edu.pucp.lp2rest.menu.model;


public class LineaDetalleCombo {
    private int id_linea_detalle_combo;
    private int fid_combo;
    private int fid_producto;
    private int cantidad;
    private boolean activo;

    /**
     * @return the id_linea_detalle_combo
     */
    public int getId_linea_detalle_combo() {
        return id_linea_detalle_combo;
    }

    /**
     * @param id_linea_detalle_combo the id_linea_detalle_combo to set
     */
    public void setId_linea_detalle_combo(int id_linea_detalle_combo) {
        this.id_linea_detalle_combo = id_linea_detalle_combo;
    }

    /**
     * @return the fid_combo
     */
    public int getFid_combo() {
        return fid_combo;
    }

    /**
     * @param fid_combo the fid_combo to set
     */
    public void setFid_combo(int fid_combo) {
        this.fid_combo = fid_combo;
    }

    /**
     * @return the fid_producto
     */
    public int getFid_producto() {
        return fid_producto;
    }

    /**
     * @param fid_producto the fid_producto to set
     */
    public void setFid_producto(int fid_producto) {
        this.fid_producto = fid_producto;
    }

    /**
     * @return the cantidad
     */
    public int getCantidad() {
        return cantidad;
    }

    /**
     * @param cantidad the cantidad to set
     */
    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    /**
     * @return the activo
     */
    public boolean isActivo() {
        return activo;
    }

    /**
     * @param activo the activo to set
     */
    public void setActivo(boolean activo) {
        this.activo = activo;
    }
}