﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebObligatorio_1_P3.ServicioIngresoActividad {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DTOIngresoActividad", Namespace="http://schemas.datacontract.org/2004/07/IngresoActividadWCF")]
    [System.SerializableAttribute()]
    public partial class DTOIngresoActividad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Dominio.DiaYHora DiaYHrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaYHoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Dominio.Socio SocioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Dominio.DiaYHora DiaYHr {
            get {
                return this.DiaYHrField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaYHrField, value) != true)) {
                    this.DiaYHrField = value;
                    this.RaisePropertyChanged("DiaYHr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaYHora {
            get {
                return this.FechaYHoraField;
            }
            set {
                if ((this.FechaYHoraField.Equals(value) != true)) {
                    this.FechaYHoraField = value;
                    this.RaisePropertyChanged("FechaYHora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Dominio.Socio Socio {
            get {
                return this.SocioField;
            }
            set {
                if ((object.ReferenceEquals(this.SocioField, value) != true)) {
                    this.SocioField = value;
                    this.RaisePropertyChanged("Socio");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioIngresoActividad.IServicioIngreso")]
    public interface IServicioIngreso {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/AltaIngresoActividadDTO", ReplyAction="http://tempuri.org/IServicioIngreso/AltaIngresoActividadDTOResponse")]
        bool AltaIngresoActividadDTO(WebObligatorio_1_P3.ServicioIngresoActividad.DTOIngresoActividad nuevoIngreso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/AltaIngresoActividadDTO", ReplyAction="http://tempuri.org/IServicioIngreso/AltaIngresoActividadDTOResponse")]
        System.Threading.Tasks.Task<bool> AltaIngresoActividadDTOAsync(WebObligatorio_1_P3.ServicioIngresoActividad.DTOIngresoActividad nuevoIngreso);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioIngresoChannel : WebObligatorio_1_P3.ServicioIngresoActividad.IServicioIngreso, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioIngresoClient : System.ServiceModel.ClientBase<WebObligatorio_1_P3.ServicioIngresoActividad.IServicioIngreso>, WebObligatorio_1_P3.ServicioIngresoActividad.IServicioIngreso {
        
        public ServicioIngresoClient() {
        }
        
        public ServicioIngresoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioIngresoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioIngresoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioIngresoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AltaIngresoActividadDTO(WebObligatorio_1_P3.ServicioIngresoActividad.DTOIngresoActividad nuevoIngreso) {
            return base.Channel.AltaIngresoActividadDTO(nuevoIngreso);
        }
        
        public System.Threading.Tasks.Task<bool> AltaIngresoActividadDTOAsync(WebObligatorio_1_P3.ServicioIngresoActividad.DTOIngresoActividad nuevoIngreso) {
            return base.Channel.AltaIngresoActividadDTOAsync(nuevoIngreso);
        }
    }
}