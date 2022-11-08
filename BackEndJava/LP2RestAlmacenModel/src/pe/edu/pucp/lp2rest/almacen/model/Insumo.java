package pe.edu.pucp.lp2rest.almacen.model;


public class Insumo {

    //atributos
    private String SKU;
    private int idInsumo;
    private double stock;
    private String descripcion;
    private String nombre;
    private double precioCompra;
    private boolean activo;
    private UnidadMedida unidadMedida;
    private TipoProducto tipoProducto;

    //constructor
    public Insumo(String SKU,double stock, String descripcion,String nombre,double precioCompra,boolean activo,UnidadMedida unidadMedida) {
        this.SKU=SKU;
        this.stock=stock;
        this.descripcion=descripcion;
        this.nombre=nombre;
        this.precioCompra=precioCompra;
        this.activo=activo;
        this.unidadMedida=unidadMedida;
        
    }
    public Insumo() {
        
        
    }
    //getters y setters
    public String getSKU() {
        return SKU;
    }

    public void setSKU(String SKU) {
        this.SKU = SKU;
    }

    public int getIdInsumo() {
        return idInsumo;
    }

    public void setIdInsumo(int idInsumo) {
        this.idInsumo = idInsumo;
    }

    public double getStock() {
        return stock;
    }

    public void setStock(double stock) {
        this.stock = stock;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getPrecioCompra() {
        return precioCompra;
    }

    public void setPrecioCompra(double precioCompra) {
        this.precioCompra = precioCompra;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public UnidadMedida getUnidadMedida() {
        return unidadMedida;
    }

    public void setUnidadMedida(UnidadMedida unidadMedida) {
        this.unidadMedida = unidadMedida;
    }

    //metodos

    /**
     * @return the tipoProducto
     */
    public TipoProducto getTipoProducto() {
        return tipoProducto;
    }

    /**
     * @param tipoProducto the tipoProducto to set
     */
    public void setTipoProducto(TipoProducto tipoProducto) {
        this.tipoProducto = tipoProducto;
    }



}