﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2Rest.ReporteWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.lp2rest.pucp.edu.pe/", ConfigurationName="ReporteWS.ReporteWS")]
    public interface ReporteWS {
        
        // CODEGEN: Generating message contract since element name fecha_ini from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReportePlatosRequest", ReplyAction="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReportePlatosResponse")]
        LP2Rest.ReporteWS.generarReportePlatosResponse generarReportePlatos(LP2Rest.ReporteWS.generarReportePlatosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReportePlatosRequest", ReplyAction="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReportePlatosResponse")]
        System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReportePlatosResponse> generarReportePlatosAsync(LP2Rest.ReporteWS.generarReportePlatosRequest request);
        
        // CODEGEN: Generating message contract since element name fecha_ini from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReporteAsistenciaRequest", ReplyAction="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReporteAsistenciaResponse")]
        LP2Rest.ReporteWS.generarReporteAsistenciaResponse generarReporteAsistencia(LP2Rest.ReporteWS.generarReporteAsistenciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReporteAsistenciaRequest", ReplyAction="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReporteAsistenciaResponse")]
        System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReporteAsistenciaResponse> generarReporteAsistenciaAsync(LP2Rest.ReporteWS.generarReporteAsistenciaRequest request);
        
        // CODEGEN: Generating message contract since message part namespace () does not match the default value (http://services.lp2rest.pucp.edu.pe/)
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarBoletaVentaRequest", ReplyAction="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarBoletaVentaResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2Rest.ReporteWS.generarBoletaVentaResponse generarBoletaVenta(LP2Rest.ReporteWS.generarBoletaVentaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarBoletaVentaRequest", ReplyAction="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarBoletaVentaResponse")]
        System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarBoletaVentaResponse> generarBoletaVentaAsync(LP2Rest.ReporteWS.generarBoletaVentaRequest request);
        
        // CODEGEN: Generating message contract since element name fecha_ini from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReporteOrdenVentasRequest", ReplyAction="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReporteOrdenVentasResponse")]
        LP2Rest.ReporteWS.generarReporteOrdenVentasResponse generarReporteOrdenVentas(LP2Rest.ReporteWS.generarReporteOrdenVentasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReporteOrdenVentasRequest", ReplyAction="http://services.lp2rest.pucp.edu.pe/ReporteWS/generarReporteOrdenVentasResponse")]
        System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReporteOrdenVentasResponse> generarReporteOrdenVentasAsync(LP2Rest.ReporteWS.generarReporteOrdenVentasRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReportePlatosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReportePlatos", Namespace="http://services.lp2rest.pucp.edu.pe/", Order=0)]
        public LP2Rest.ReporteWS.generarReportePlatosRequestBody Body;
        
        public generarReportePlatosRequest() {
        }
        
        public generarReportePlatosRequest(LP2Rest.ReporteWS.generarReportePlatosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReportePlatosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fecha_ini;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fecha_fin;
        
        public generarReportePlatosRequestBody() {
        }
        
        public generarReportePlatosRequestBody(string fecha_ini, string fecha_fin) {
            this.fecha_ini = fecha_ini;
            this.fecha_fin = fecha_fin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReportePlatosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReportePlatosResponse", Namespace="http://services.lp2rest.pucp.edu.pe/", Order=0)]
        public LP2Rest.ReporteWS.generarReportePlatosResponseBody Body;
        
        public generarReportePlatosResponse() {
        }
        
        public generarReportePlatosResponse(LP2Rest.ReporteWS.generarReportePlatosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReportePlatosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] @return;
        
        public generarReportePlatosResponseBody() {
        }
        
        public generarReportePlatosResponseBody(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReporteAsistenciaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReporteAsistencia", Namespace="http://services.lp2rest.pucp.edu.pe/", Order=0)]
        public LP2Rest.ReporteWS.generarReporteAsistenciaRequestBody Body;
        
        public generarReporteAsistenciaRequest() {
        }
        
        public generarReporteAsistenciaRequest(LP2Rest.ReporteWS.generarReporteAsistenciaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReporteAsistenciaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id_cuentaUsuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fecha_ini;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string fecha_fin;
        
        public generarReporteAsistenciaRequestBody() {
        }
        
        public generarReporteAsistenciaRequestBody(int id_cuentaUsuario, string fecha_ini, string fecha_fin) {
            this.id_cuentaUsuario = id_cuentaUsuario;
            this.fecha_ini = fecha_ini;
            this.fecha_fin = fecha_fin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReporteAsistenciaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReporteAsistenciaResponse", Namespace="http://services.lp2rest.pucp.edu.pe/", Order=0)]
        public LP2Rest.ReporteWS.generarReporteAsistenciaResponseBody Body;
        
        public generarReporteAsistenciaResponse() {
        }
        
        public generarReporteAsistenciaResponse(LP2Rest.ReporteWS.generarReporteAsistenciaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReporteAsistenciaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] @return;
        
        public generarReporteAsistenciaResponseBody() {
        }
        
        public generarReporteAsistenciaResponseBody(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="generarBoletaVenta", WrapperNamespace="http://services.lp2rest.pucp.edu.pe/", IsWrapped=true)]
    public partial class generarBoletaVentaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int id_orden_venta;
        
        public generarBoletaVentaRequest() {
        }
        
        public generarBoletaVentaRequest(int id_orden_venta) {
            this.id_orden_venta = id_orden_venta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="generarBoletaVentaResponse", WrapperNamespace="http://services.lp2rest.pucp.edu.pe/", IsWrapped=true)]
    public partial class generarBoletaVentaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public byte[] @return;
        
        public generarBoletaVentaResponse() {
        }
        
        public generarBoletaVentaResponse(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReporteOrdenVentasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReporteOrdenVentas", Namespace="http://services.lp2rest.pucp.edu.pe/", Order=0)]
        public LP2Rest.ReporteWS.generarReporteOrdenVentasRequestBody Body;
        
        public generarReporteOrdenVentasRequest() {
        }
        
        public generarReporteOrdenVentasRequest(LP2Rest.ReporteWS.generarReporteOrdenVentasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReporteOrdenVentasRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fecha_ini;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fecha_fin;
        
        public generarReporteOrdenVentasRequestBody() {
        }
        
        public generarReporteOrdenVentasRequestBody(string fecha_ini, string fecha_fin) {
            this.fecha_ini = fecha_ini;
            this.fecha_fin = fecha_fin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReporteOrdenVentasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReporteOrdenVentasResponse", Namespace="http://services.lp2rest.pucp.edu.pe/", Order=0)]
        public LP2Rest.ReporteWS.generarReporteOrdenVentasResponseBody Body;
        
        public generarReporteOrdenVentasResponse() {
        }
        
        public generarReporteOrdenVentasResponse(LP2Rest.ReporteWS.generarReporteOrdenVentasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReporteOrdenVentasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] @return;
        
        public generarReporteOrdenVentasResponseBody() {
        }
        
        public generarReporteOrdenVentasResponseBody(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ReporteWSChannel : LP2Rest.ReporteWS.ReporteWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReporteWSClient : System.ServiceModel.ClientBase<LP2Rest.ReporteWS.ReporteWS>, LP2Rest.ReporteWS.ReporteWS {
        
        public ReporteWSClient() {
        }
        
        public ReporteWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReporteWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReporteWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReporteWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Rest.ReporteWS.generarReportePlatosResponse LP2Rest.ReporteWS.ReporteWS.generarReportePlatos(LP2Rest.ReporteWS.generarReportePlatosRequest request) {
            return base.Channel.generarReportePlatos(request);
        }
        
        public byte[] generarReportePlatos(string fecha_ini, string fecha_fin) {
            LP2Rest.ReporteWS.generarReportePlatosRequest inValue = new LP2Rest.ReporteWS.generarReportePlatosRequest();
            inValue.Body = new LP2Rest.ReporteWS.generarReportePlatosRequestBody();
            inValue.Body.fecha_ini = fecha_ini;
            inValue.Body.fecha_fin = fecha_fin;
            LP2Rest.ReporteWS.generarReportePlatosResponse retVal = ((LP2Rest.ReporteWS.ReporteWS)(this)).generarReportePlatos(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReportePlatosResponse> LP2Rest.ReporteWS.ReporteWS.generarReportePlatosAsync(LP2Rest.ReporteWS.generarReportePlatosRequest request) {
            return base.Channel.generarReportePlatosAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReportePlatosResponse> generarReportePlatosAsync(string fecha_ini, string fecha_fin) {
            LP2Rest.ReporteWS.generarReportePlatosRequest inValue = new LP2Rest.ReporteWS.generarReportePlatosRequest();
            inValue.Body = new LP2Rest.ReporteWS.generarReportePlatosRequestBody();
            inValue.Body.fecha_ini = fecha_ini;
            inValue.Body.fecha_fin = fecha_fin;
            return ((LP2Rest.ReporteWS.ReporteWS)(this)).generarReportePlatosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Rest.ReporteWS.generarReporteAsistenciaResponse LP2Rest.ReporteWS.ReporteWS.generarReporteAsistencia(LP2Rest.ReporteWS.generarReporteAsistenciaRequest request) {
            return base.Channel.generarReporteAsistencia(request);
        }
        
        public byte[] generarReporteAsistencia(int id_cuentaUsuario, string fecha_ini, string fecha_fin) {
            LP2Rest.ReporteWS.generarReporteAsistenciaRequest inValue = new LP2Rest.ReporteWS.generarReporteAsistenciaRequest();
            inValue.Body = new LP2Rest.ReporteWS.generarReporteAsistenciaRequestBody();
            inValue.Body.id_cuentaUsuario = id_cuentaUsuario;
            inValue.Body.fecha_ini = fecha_ini;
            inValue.Body.fecha_fin = fecha_fin;
            LP2Rest.ReporteWS.generarReporteAsistenciaResponse retVal = ((LP2Rest.ReporteWS.ReporteWS)(this)).generarReporteAsistencia(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReporteAsistenciaResponse> LP2Rest.ReporteWS.ReporteWS.generarReporteAsistenciaAsync(LP2Rest.ReporteWS.generarReporteAsistenciaRequest request) {
            return base.Channel.generarReporteAsistenciaAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReporteAsistenciaResponse> generarReporteAsistenciaAsync(int id_cuentaUsuario, string fecha_ini, string fecha_fin) {
            LP2Rest.ReporteWS.generarReporteAsistenciaRequest inValue = new LP2Rest.ReporteWS.generarReporteAsistenciaRequest();
            inValue.Body = new LP2Rest.ReporteWS.generarReporteAsistenciaRequestBody();
            inValue.Body.id_cuentaUsuario = id_cuentaUsuario;
            inValue.Body.fecha_ini = fecha_ini;
            inValue.Body.fecha_fin = fecha_fin;
            return ((LP2Rest.ReporteWS.ReporteWS)(this)).generarReporteAsistenciaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Rest.ReporteWS.generarBoletaVentaResponse LP2Rest.ReporteWS.ReporteWS.generarBoletaVenta(LP2Rest.ReporteWS.generarBoletaVentaRequest request) {
            return base.Channel.generarBoletaVenta(request);
        }
        
        public byte[] generarBoletaVenta(int id_orden_venta) {
            LP2Rest.ReporteWS.generarBoletaVentaRequest inValue = new LP2Rest.ReporteWS.generarBoletaVentaRequest();
            inValue.id_orden_venta = id_orden_venta;
            LP2Rest.ReporteWS.generarBoletaVentaResponse retVal = ((LP2Rest.ReporteWS.ReporteWS)(this)).generarBoletaVenta(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarBoletaVentaResponse> LP2Rest.ReporteWS.ReporteWS.generarBoletaVentaAsync(LP2Rest.ReporteWS.generarBoletaVentaRequest request) {
            return base.Channel.generarBoletaVentaAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarBoletaVentaResponse> generarBoletaVentaAsync(int id_orden_venta) {
            LP2Rest.ReporteWS.generarBoletaVentaRequest inValue = new LP2Rest.ReporteWS.generarBoletaVentaRequest();
            inValue.id_orden_venta = id_orden_venta;
            return ((LP2Rest.ReporteWS.ReporteWS)(this)).generarBoletaVentaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Rest.ReporteWS.generarReporteOrdenVentasResponse LP2Rest.ReporteWS.ReporteWS.generarReporteOrdenVentas(LP2Rest.ReporteWS.generarReporteOrdenVentasRequest request) {
            return base.Channel.generarReporteOrdenVentas(request);
        }
        
        public byte[] generarReporteOrdenVentas(string fecha_ini, string fecha_fin) {
            LP2Rest.ReporteWS.generarReporteOrdenVentasRequest inValue = new LP2Rest.ReporteWS.generarReporteOrdenVentasRequest();
            inValue.Body = new LP2Rest.ReporteWS.generarReporteOrdenVentasRequestBody();
            inValue.Body.fecha_ini = fecha_ini;
            inValue.Body.fecha_fin = fecha_fin;
            LP2Rest.ReporteWS.generarReporteOrdenVentasResponse retVal = ((LP2Rest.ReporteWS.ReporteWS)(this)).generarReporteOrdenVentas(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReporteOrdenVentasResponse> LP2Rest.ReporteWS.ReporteWS.generarReporteOrdenVentasAsync(LP2Rest.ReporteWS.generarReporteOrdenVentasRequest request) {
            return base.Channel.generarReporteOrdenVentasAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Rest.ReporteWS.generarReporteOrdenVentasResponse> generarReporteOrdenVentasAsync(string fecha_ini, string fecha_fin) {
            LP2Rest.ReporteWS.generarReporteOrdenVentasRequest inValue = new LP2Rest.ReporteWS.generarReporteOrdenVentasRequest();
            inValue.Body = new LP2Rest.ReporteWS.generarReporteOrdenVentasRequestBody();
            inValue.Body.fecha_ini = fecha_ini;
            inValue.Body.fecha_fin = fecha_fin;
            return ((LP2Rest.ReporteWS.ReporteWS)(this)).generarReporteOrdenVentasAsync(inValue);
        }
    }
}
