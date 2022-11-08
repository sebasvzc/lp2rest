package pe.edu.pucp.lp2rest.almacen.model;

public class TipoProducto {
    //atributos
    private int idTipoProducto;
    private String descripcion;
    private String nombre;

    public TipoProducto(String descripcion, String nombre){
        this.descripcion = descripcion;
        this.nombre = nombre;
    }
    
    public TipoProducto(){
        
    }
    
    /**
     * @return the idTipoProducto
     */
    public int getIdTipoProducto() {
        return idTipoProducto;
    }

    /**
     * @param idTipoProducto the idTipoProducto to set
     */
    public void setIdTipoProducto(int idTipoProducto) {
        this.idTipoProducto = idTipoProducto;
    }

    /**
     * @return the descripcion
     */
    public String getDescripcion() {
        return descripcion;
    }

    /**
     * @param descripcion the descripcion to set
     */
    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    /**
     * @return the nombre
     */
    public String getNombre() {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    
    
}