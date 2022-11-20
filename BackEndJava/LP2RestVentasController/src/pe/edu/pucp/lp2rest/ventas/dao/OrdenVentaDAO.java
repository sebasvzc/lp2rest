package pe.edu.pucp.lp2rest.ventas.dao;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2rest.ventas.model.OrdenVenta;

/**
 *
 * @author Gerard
 */
public interface OrdenVentaDAO {
    int insertar(OrdenVenta ordenVenta);
    int modificar (OrdenVenta ordenVenta);
    int eliminar(int idOrdenVenta);
    ArrayList<OrdenVenta> listarTodos();
    ArrayList<OrdenVenta> listarBusqueda(String nombre,String apellido,
                                         Date fechaIni,Date fechaFin,
                                         double sueldoIni,double sueldoFin);
    ArrayList<OrdenVenta> listarBusquedaMesero( int idMesero,
                                                String nombre,String apellido,
                                                Date fechaIni,Date fechaFin,
                                                double sueldoIni,double sueldoFin);
    int actualizar(int idOrdenVenta);
}
