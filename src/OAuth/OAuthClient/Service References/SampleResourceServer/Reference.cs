﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OAuthClient.SampleResourceServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SampleResourceServer.IDataApi")]
    public interface IDataApi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataApi/GetAge", ReplyAction="http://tempuri.org/IDataApi/GetAgeResponse")]
        System.Nullable<int> GetAge();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataApi/GetName", ReplyAction="http://tempuri.org/IDataApi/GetNameResponse")]
        string GetName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataApi/GetFavoriteSites", ReplyAction="http://tempuri.org/IDataApi/GetFavoriteSitesResponse")]
        string[] GetFavoriteSites();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataApiChannel : OAuthClient.SampleResourceServer.IDataApi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataApiClient : System.ServiceModel.ClientBase<OAuthClient.SampleResourceServer.IDataApi>, OAuthClient.SampleResourceServer.IDataApi {
        
        public DataApiClient() {
        }
        
        public DataApiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataApiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataApiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataApiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Nullable<int> GetAge() {
            return base.Channel.GetAge();
        }
        
        public string GetName() {
            return base.Channel.GetName();
        }
        
        public string[] GetFavoriteSites() {
            return base.Channel.GetFavoriteSites();
        }
    }
}