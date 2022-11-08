/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2rest.menu.model;


public class TipoItem {
    private int idTipoItem;
    private String codigo;
    private String descripcion;
    private boolean activo;

    public int getIdTipoItem() {
        return idTipoItem;
    }

    public void setIdTipoItem(int idTipoItem) {
        this.idTipoItem = idTipoItem;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
