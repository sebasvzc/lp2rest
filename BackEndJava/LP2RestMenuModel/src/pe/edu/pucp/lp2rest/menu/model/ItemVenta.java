package pe.edu.pucp.lp2rest.menu.model;

import java.util.ArrayList;

public class ItemVenta {

    //atributos
    private int idItemVenta;
    private String nombre;
    private double precio;
    private int stock;
    private TipoItem TipoItem;
    private boolean activo;
    private int disponible;
    private ArrayList<Receta> recetas;
    private ArrayList<LineaDetalleCombo> lineasCombo;
    private String recetaDePreparacion;
    private double descuento;
    //constructor
    public ItemVenta() {

    }

    //Gets y Sets
    
    
    public int getIdItemVenta() {
        return idItemVenta;
    }

    public void setIdItemVenta(int idItemVenta) {
        this.idItemVenta = idItemVenta;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }
    
    public int getDisponible() {
        return disponible;
    }

    public void setDisponible(int disponible) {
        this.disponible = disponible;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }
    
    //Metodos
    public void ingresarReceta(){
        
    }

    public void editarEstado(){

    }

    public void editarStock(){

    }

    public TipoItem getTipoItem() {
        return TipoItem;
    }

    public void setTipoItem(TipoItem TipoItem) {
        this.TipoItem = TipoItem;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    /**
     * @return the recetas
     */
    public ArrayList<Receta> getRecetas() {
        return recetas;
    }

    /**
     * @param recetas the recetas to set
     */
    public void setRecetas(ArrayList<Receta> recetas) {
        this.recetas = recetas;
    }

    /**
     * @return the lineasCombo
     */
    public ArrayList<LineaDetalleCombo> getLineasCombo() {
        return lineasCombo;
    }

    /**
     * @param lineasCombo the lineasCombo to set
     */
    public void setLineasCombo(ArrayList<LineaDetalleCombo> lineasCombo) {
        this.lineasCombo = lineasCombo;
    }

    /**
     * @return the recetaDePreparacion
     */
    public String getRecetaDePreparacion() {
        return recetaDePreparacion;
    }

    /**
     * @param recetaDePreparacion the recetaDePreparacion to set
     */
    public void setRecetaDePreparacion(String recetaDePreparacion) {
        this.recetaDePreparacion = recetaDePreparacion;
    }

    /**
     * @return the descuento
     */
    public double getDescuento() {
        return descuento;
    }

    /**
     * @param descuento the descuento to set
     */
    public void setDescuento(double descuento) {
        this.descuento = descuento;
    }

}