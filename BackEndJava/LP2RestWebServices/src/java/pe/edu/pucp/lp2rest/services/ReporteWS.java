/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.lp2rest.services;

import java.awt.Image;
import java.sql.Connection;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.lp2rest.config.DBManager;
import pe.edu.pucp.lp2rest.servlet.ReporteAsistencias;

/**
 *
 
 */
@WebService(serviceName = "ReporteWS")
public class ReporteWS {

    /**
     * This is a sample web service operation
     */
    private Connection con;
    @WebMethod(operationName = "generarReporteAsistencia")
    public byte[] generarReporteAsistencia(@WebParam(name = "id_cuentaUsuario") int idCuentaUsuario,
            @WebParam(name = "fecha_ini") String fecha_ini,
            @WebParam(name = "fecha_fin") String fecha_fin) {
        byte[] reporteBytes = null;
        try{
            con = DBManager.getInstance().getConnection();
            
            
            JasperReport reporte = (JasperReport) JRLoader.loadObject(
               ReporteAsistencias.class.getResource("/pe/edu/pucp/lp2rest/report/AsistenciasDefinitivo.jasper")
            );
            
            String rutaSubReporte = ReporteAsistencias.class.getResource(
                    "/pe/edu/pucp/lp2rest/report/ReporteAsistenciasGrafico.jasper").getPath();
             
            String rutaImagen = ReporteAsistencias.class.getResource("/pe/edu/pucp/lp2rest/img/LogoCrema.jpg").getPath();
            Image imagen = (new ImageIcon(rutaImagen)).getImage();
            
            
            HashMap parametros = new HashMap();
            parametros.put("ImagenLogoEmpresa", imagen);
            parametros.put("fid_cuenta",idCuentaUsuario);
            parametros.put("fecha_ini",fecha_ini);
            parametros.put("fecha_fin",fecha_fin);
            parametros.put("SubReporteGrafico", rutaSubReporte);
            
            
            
            JasperPrint jp = JasperFillManager.fillReport(reporte, parametros, con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
    
    
    @WebMethod(operationName = "generarBoletaVenta")
    public byte[] generarBoletaVenta(@WebParam(name = "id_orden_venta") int id_orden_venta) {
        byte[] reporteBytes = null;
        try{
            con = DBManager.getInstance().getConnection();
            JasperReport reporte = (JasperReport) JRLoader.loadObject(
               ReporteWS.class.getResource("/pe/edu/pucp/lp2rest/report/BoletaVenta.jasper")
            );
            HashMap parametros = new HashMap();
            parametros.put("id_ordenVenta",id_orden_venta);

            JasperPrint jp = JasperFillManager.fillReport(reporte, parametros, con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
    
    
    @WebMethod(operationName = "generarReporteOrdenVentas")
    public byte[] generarReporteOrdenVentas(@WebParam(name = "fecha_ini") String fecha_ini,
            @WebParam(name = "fecha_fin") String fecha_fin) {
        byte[] reporteBytes = null;
        try{
            con = DBManager.getInstance().getConnection();
            JasperReport reporte = (JasperReport) JRLoader.loadObject(
               ReporteWS.class.getResource("/pe/edu/pucp/lp2rest/report/ReporteVentas.jasper")
            );
            
            String rutaSubReporteCajero = ReporteAsistencias.class.getResource(
                    "/pe/edu/pucp/lp2rest/report/ReporteGraficoVentasCajero.jasper").getPath();
            String rutaSubReporteCliente = ReporteAsistencias.class.getResource(
                    "/pe/edu/pucp/lp2rest/report/ReporteGraficoVentasClientes.jasper").getPath();
            String rutaSubReporteMesero = ReporteAsistencias.class.getResource(
                    "/pe/edu/pucp/lp2rest/report/ReporteGraficoVentasMesero.jasper").getPath();
            
            
            String rutaImagen = ReporteAsistencias.class.getResource("/pe/edu/pucp/lp2rest/img/LogoCrema.jpg").getPath();
            Image imagen = (new ImageIcon(rutaImagen)).getImage();
            HashMap parametros = new HashMap();
            parametros.put("ImagenLogoEmpresa", imagen);
            parametros.put("SubReporteGraficoCajero",rutaSubReporteCajero);
            parametros.put("SubReporteGraficoCliente",rutaSubReporteCliente);
            parametros.put("SubReporteGraficoMesero",rutaSubReporteMesero);
            parametros.put("fecha_ini",fecha_ini);
            parametros.put("fecha_fin",fecha_fin);

            JasperPrint jp = JasperFillManager.fillReport(reporte, parametros, con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
    
    @WebMethod(operationName = "generarReportePlatos")
    public byte[] generarReportePlatos(@WebParam(name = "fecha_ini") String fecha_ini,
            @WebParam(name = "fecha_fin") String fecha_fin) {
        byte[] reporteBytes = null;
        try{
            con = DBManager.getInstance().getConnection();
            JasperReport reporte = (JasperReport) JRLoader.loadObject(
               ReporteWS.class.getResource("/pe/edu/pucp/lp2rest/report/ReportePlatos.jasper")
            );
            
            String rutaSubReporteCategoria = ReporteAsistencias.class.getResource(
                    "/pe/edu/pucp/lp2rest/report/ReportePlatoCategoria.jasper").getPath();
            
            String rutaImagen = ReporteAsistencias.class.getResource("/pe/edu/pucp/lp2rest/img/LogoCrema.jpg").getPath();
            Image imagen = (new ImageIcon(rutaImagen)).getImage();
            HashMap parametros = new HashMap();
            parametros.put("ImagenLogoEmpresa", imagen);
            parametros.put("fecha_ini",fecha_ini);
            parametros.put("fecha_fin",fecha_fin);
            parametros.put("SubreportePlatoCategoria", rutaSubReporteCategoria);
            JasperPrint jp = JasperFillManager.fillReport(reporte, parametros, con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
}
