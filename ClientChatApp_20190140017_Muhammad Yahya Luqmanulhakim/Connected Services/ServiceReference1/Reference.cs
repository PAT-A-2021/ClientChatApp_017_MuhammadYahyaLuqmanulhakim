﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientChatApp_20190140017_Muhammad_Yahya_Luqmanulhakim.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceCallback", CallbackContract=typeof(ClientChatApp_20190140017_Muhammad_Yahya_Luqmanulhakim.ServiceReference1.IServiceCallbackCallback))]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/gabung")]
        void gabung(string userrname);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/gabung")]
        System.Threading.Tasks.Task gabungAsync(string userrname);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/kirimPesan")]
        void kirimPesan(string pesan);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/kirimPesan")]
        System.Threading.Tasks.Task kirimPesanAsync(string pesan);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallbackCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/pesanKirim")]
        void pesanKirim(string user, string pesan);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallbackChannel : ClientChatApp_20190140017_Muhammad_Yahya_Luqmanulhakim.ServiceReference1.IServiceCallback, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCallbackClient : System.ServiceModel.DuplexClientBase<ClientChatApp_20190140017_Muhammad_Yahya_Luqmanulhakim.ServiceReference1.IServiceCallback>, ClientChatApp_20190140017_Muhammad_Yahya_Luqmanulhakim.ServiceReference1.IServiceCallback {
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void gabung(string userrname) {
            base.Channel.gabung(userrname);
        }
        
        public System.Threading.Tasks.Task gabungAsync(string userrname) {
            return base.Channel.gabungAsync(userrname);
        }
        
        public void kirimPesan(string pesan) {
            base.Channel.kirimPesan(pesan);
        }
        
        public System.Threading.Tasks.Task kirimPesanAsync(string pesan) {
            return base.Channel.kirimPesanAsync(pesan);
        }
    }
}
