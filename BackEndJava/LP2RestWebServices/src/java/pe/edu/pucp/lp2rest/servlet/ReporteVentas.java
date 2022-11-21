/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package pe.edu.pucp.lp2rest.servlet;

import java.awt.Image;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.lp2rest.config.DBManager;

/**
 *
 * @author Gonzalo
 */
public class ReporteVentas extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try{
            Connection con = DBManager.getInstance().getConnection();
            JasperReport reporte = (JasperReport) JRLoader.loadObject(
                ReporteAsistencias.class.getResource("/pe/edu/pucp/lp2rest/report/ReporteVentas.jasper"));
            
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
            
            JasperPrint jp = JasperFillManager.fillReport(reporte,parametros,con);
            con.close();
            JasperExportManager.exportReportToPdfStream(jp,response.getOutputStream());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
