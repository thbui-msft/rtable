﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime _rtable_Version:2.0.50727.5477
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, _rtable_Version=2.0.50727.312.
// 
namespace Microsoft.WindowsAzure.Storage.RTableTest {
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/RTableTestConfiguration.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/RTableTestConfiguration.xsd", IsNullable=false)]
    public partial class RTableTestConfiguration {
        
        private RTableTestConfigurationStorageInformation storageInformationField;
        
        private RTableTestConfigurationRTableInformation rTableInformationField;

        private RTableTestConfigurationRunnerInformation runnerInformationField;
        
        /// <remarks/>
        public RTableTestConfigurationStorageInformation StorageInformation {
            get {
                return this.storageInformationField;
            }
            set {
                this.storageInformationField = value;
            }
        }
        
        /// <remarks/>
        public RTableTestConfigurationRTableInformation RTableInformation {
            get {
                return this.rTableInformationField;
            }
            set {
                this.rTableInformationField = value;
            }
        }

        /// <remarks/>
        public RTableTestConfigurationRunnerInformation RunnerInformation {
            get {
                return this.runnerInformationField;
            }
            set {
                this.runnerInformationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/RTableTestConfiguration.xsd")]
    public partial class RTableTestConfigurationStorageInformation {
        
        private string domainNameField;
        
        private string[] accountNamesField;
        
        private string[] accountKeysField;
        
        /// <remarks/>
        public string DomainName {
            get {
                return this.domainNameField;
            }
            set {
                this.domainNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AccountName", IsNullable=false)]
        public string[] AccountNames {
            get {
                return this.accountNamesField;
            }
            set {
                this.accountNamesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AccountKey", IsNullable=false)]
        public string[] AccountKeys {
            get {
                return this.accountKeysField;
            }
            set {
                this.accountKeysField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/RTableTestConfiguration.xsd")]
    public partial class RTableTestConfigurationRTableInformation {
        
        private string containerNameField;
        
        private string blobNameField;
        
        private string rTableNameField;
        
        private int viewIdField;
        
        /// <remarks/>
        public string ContainerName {
            get {
                return this.containerNameField;
            }
            set {
                this.containerNameField = value;
            }
        }
        
        /// <remarks/>
        public string BlobName {
            get {
                return this.blobNameField;
            }
            set {
                this.blobNameField = value;
            }
        }
        
        /// <remarks/>
        public string RTableName {
            get {
                return this.rTableNameField;
            }
            set {
                this.rTableNameField = value;
            }
        }
        
        /// <remarks/>
        public int ViewId {
            get {
                return this.viewIdField;
            }
            set {
                this.viewIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/RTableTestConfiguration.xsd")]
    public partial class RTableTestConfigurationRunnerInformation {
        
        private Guid interactiveLoginTenantIdField;
        
        /// <remarks/>
        public Guid InteractiveLoginTenantId {
            get {
                return this.interactiveLoginTenantIdField;
            }
            set {
                this.interactiveLoginTenantIdField = value;
            }
        }
    }
}
