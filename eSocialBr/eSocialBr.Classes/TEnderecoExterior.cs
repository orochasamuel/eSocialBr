using System;
using System.Collections.Generic;
using System.Text;

namespace eSocialBr.Classes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.esocial.gov.br/schema/evt/evtAdmissao/v02_04_01")]
    public partial class TEnderecoExterior
    {

        private string paisResidField;

        private string dscLogradField;

        private string nrLogradField;

        private string complementoField;

        private string bairroField;

        private string nmCidField;

        private string codPostalField;

        /// <remarks/>
        public string paisResid
        {
            get
            {
                return this.paisResidField;
            }
            set
            {
                this.paisResidField = value;
            }
        }

        /// <remarks/>
        public string dscLograd
        {
            get
            {
                return this.dscLogradField;
            }
            set
            {
                this.dscLogradField = value;
            }
        }

        /// <remarks/>
        public string nrLograd
        {
            get
            {
                return this.nrLogradField;
            }
            set
            {
                this.nrLogradField = value;
            }
        }

        /// <remarks/>
        public string complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }

        /// <remarks/>
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }

        /// <remarks/>
        public string nmCid
        {
            get
            {
                return this.nmCidField;
            }
            set
            {
                this.nmCidField = value;
            }
        }

        /// <remarks/>
        public string codPostal
        {
            get
            {
                return this.codPostalField;
            }
            set
            {
                this.codPostalField = value;
            }
        }
    }
}
