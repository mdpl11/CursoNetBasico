﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ColegioColombia.Mvc.ServicioColombia {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioColombia.ServicioColombiaSoap")]
    public interface ServicioColombiaSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ColegioColombia.Mvc.ServicioColombia.HelloWorldResponse HelloWorld(ColegioColombia.Mvc.ServicioColombia.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.HelloWorldResponse> HelloWorldAsync(ColegioColombia.Mvc.ServicioColombia.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Saludo", ReplyAction="*")]
        ColegioColombia.Mvc.ServicioColombia.SaludoResponse Saludo(ColegioColombia.Mvc.ServicioColombia.SaludoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Saludo", ReplyAction="*")]
        System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.SaludoResponse> SaludoAsync(ColegioColombia.Mvc.ServicioColombia.SaludoRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaludoPersonalizado", ReplyAction="*")]
        ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoResponse SaludoPersonalizado(ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaludoPersonalizado", ReplyAction="*")]
        System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoResponse> SaludoPersonalizadoAsync(ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sumar", ReplyAction="*")]
        decimal Sumar(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sumar", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> SumarAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Restar", ReplyAction="*")]
        decimal Restar(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Restar", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> RestarAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicar", ReplyAction="*")]
        decimal Multiplicar(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicar", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> MultiplicarAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Dividir", ReplyAction="*")]
        decimal Dividir(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Dividir", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> DividirAsync(decimal a, decimal b);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ColegioColombia.Mvc.ServicioColombia.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ColegioColombia.Mvc.ServicioColombia.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ColegioColombia.Mvc.ServicioColombia.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ColegioColombia.Mvc.ServicioColombia.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaludoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Saludo", Namespace="http://tempuri.org/", Order=0)]
        public ColegioColombia.Mvc.ServicioColombia.SaludoRequestBody Body;
        
        public SaludoRequest() {
        }
        
        public SaludoRequest(ColegioColombia.Mvc.ServicioColombia.SaludoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaludoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public SaludoRequestBody() {
        }
        
        public SaludoRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaludoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaludoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ColegioColombia.Mvc.ServicioColombia.SaludoResponseBody Body;
        
        public SaludoResponse() {
        }
        
        public SaludoResponse(ColegioColombia.Mvc.ServicioColombia.SaludoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaludoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SaludoResult;
        
        public SaludoResponseBody() {
        }
        
        public SaludoResponseBody(string SaludoResult) {
            this.SaludoResult = SaludoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaludoPersonalizadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaludoPersonalizado", Namespace="http://tempuri.org/", Order=0)]
        public ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequestBody Body;
        
        public SaludoPersonalizadoRequest() {
        }
        
        public SaludoPersonalizadoRequest(ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaludoPersonalizadoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public SaludoPersonalizadoRequestBody() {
        }
        
        public SaludoPersonalizadoRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaludoPersonalizadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaludoPersonalizadoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoResponseBody Body;
        
        public SaludoPersonalizadoResponse() {
        }
        
        public SaludoPersonalizadoResponse(ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaludoPersonalizadoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SaludoPersonalizadoResult;
        
        public SaludoPersonalizadoResponseBody() {
        }
        
        public SaludoPersonalizadoResponseBody(string SaludoPersonalizadoResult) {
            this.SaludoPersonalizadoResult = SaludoPersonalizadoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioColombiaSoapChannel : ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioColombiaSoapClient : System.ServiceModel.ClientBase<ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap>, ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap {
        
        public ServicioColombiaSoapClient() {
        }
        
        public ServicioColombiaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioColombiaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioColombiaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioColombiaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ColegioColombia.Mvc.ServicioColombia.HelloWorldResponse ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap.HelloWorld(ColegioColombia.Mvc.ServicioColombia.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ColegioColombia.Mvc.ServicioColombia.HelloWorldRequest inValue = new ColegioColombia.Mvc.ServicioColombia.HelloWorldRequest();
            inValue.Body = new ColegioColombia.Mvc.ServicioColombia.HelloWorldRequestBody();
            ColegioColombia.Mvc.ServicioColombia.HelloWorldResponse retVal = ((ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.HelloWorldResponse> ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap.HelloWorldAsync(ColegioColombia.Mvc.ServicioColombia.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.HelloWorldResponse> HelloWorldAsync() {
            ColegioColombia.Mvc.ServicioColombia.HelloWorldRequest inValue = new ColegioColombia.Mvc.ServicioColombia.HelloWorldRequest();
            inValue.Body = new ColegioColombia.Mvc.ServicioColombia.HelloWorldRequestBody();
            return ((ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ColegioColombia.Mvc.ServicioColombia.SaludoResponse ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap.Saludo(ColegioColombia.Mvc.ServicioColombia.SaludoRequest request) {
            return base.Channel.Saludo(request);
        }
        
        public string Saludo(string nombre) {
            ColegioColombia.Mvc.ServicioColombia.SaludoRequest inValue = new ColegioColombia.Mvc.ServicioColombia.SaludoRequest();
            inValue.Body = new ColegioColombia.Mvc.ServicioColombia.SaludoRequestBody();
            inValue.Body.nombre = nombre;
            ColegioColombia.Mvc.ServicioColombia.SaludoResponse retVal = ((ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap)(this)).Saludo(inValue);
            return retVal.Body.SaludoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.SaludoResponse> ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap.SaludoAsync(ColegioColombia.Mvc.ServicioColombia.SaludoRequest request) {
            return base.Channel.SaludoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.SaludoResponse> SaludoAsync(string nombre) {
            ColegioColombia.Mvc.ServicioColombia.SaludoRequest inValue = new ColegioColombia.Mvc.ServicioColombia.SaludoRequest();
            inValue.Body = new ColegioColombia.Mvc.ServicioColombia.SaludoRequestBody();
            inValue.Body.nombre = nombre;
            return ((ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap)(this)).SaludoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoResponse ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap.SaludoPersonalizado(ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequest request) {
            return base.Channel.SaludoPersonalizado(request);
        }
        
        public string SaludoPersonalizado(string nombre) {
            ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequest inValue = new ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequest();
            inValue.Body = new ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequestBody();
            inValue.Body.nombre = nombre;
            ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoResponse retVal = ((ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap)(this)).SaludoPersonalizado(inValue);
            return retVal.Body.SaludoPersonalizadoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoResponse> ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap.SaludoPersonalizadoAsync(ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequest request) {
            return base.Channel.SaludoPersonalizadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoResponse> SaludoPersonalizadoAsync(string nombre) {
            ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequest inValue = new ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequest();
            inValue.Body = new ColegioColombia.Mvc.ServicioColombia.SaludoPersonalizadoRequestBody();
            inValue.Body.nombre = nombre;
            return ((ColegioColombia.Mvc.ServicioColombia.ServicioColombiaSoap)(this)).SaludoPersonalizadoAsync(inValue);
        }
        
        public decimal Sumar(decimal a, decimal b) {
            return base.Channel.Sumar(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> SumarAsync(decimal a, decimal b) {
            return base.Channel.SumarAsync(a, b);
        }
        
        public decimal Restar(decimal a, decimal b) {
            return base.Channel.Restar(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> RestarAsync(decimal a, decimal b) {
            return base.Channel.RestarAsync(a, b);
        }
        
        public decimal Multiplicar(decimal a, decimal b) {
            return base.Channel.Multiplicar(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> MultiplicarAsync(decimal a, decimal b) {
            return base.Channel.MultiplicarAsync(a, b);
        }
        
        public decimal Dividir(decimal a, decimal b) {
            return base.Channel.Dividir(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> DividirAsync(decimal a, decimal b) {
            return base.Channel.DividirAsync(a, b);
        }
    }
}