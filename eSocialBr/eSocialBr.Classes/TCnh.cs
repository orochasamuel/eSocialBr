using eSocialBr.Classes.Enums;
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
    public partial class TCnh
    {

        private string nrRegCnhField;

        private System.DateTime dtExpedField;

        private bool dtExpedFieldSpecified;

        private TCnhUfCnh ufCnhField;

        private System.DateTime dtValidField;

        private System.DateTime dtPriHabField;

        private bool dtPriHabFieldSpecified;

        private string categoriaCnhField;

        /// <remarks/>
        public string nrRegCnh
        {
            get
            {
                return this.nrRegCnhField;
            }
            set
            {
                this.nrRegCnhField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtExped
        {
            get
            {
                return this.dtExpedField;
            }
            set
            {
                this.dtExpedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtExpedSpecified
        {
            get
            {
                return this.dtExpedFieldSpecified;
            }
            set
            {
                this.dtExpedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TCnhUfCnh ufCnh
        {
            get
            {
                return this.ufCnhField;
            }
            set
            {
                this.ufCnhField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtValid
        {
            get
            {
                return this.dtValidField;
            }
            set
            {
                this.dtValidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtPriHab
        {
            get
            {
                return this.dtPriHabField;
            }
            set
            {
                this.dtPriHabField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtPriHabSpecified
        {
            get
            {
                return this.dtPriHabFieldSpecified;
            }
            set
            {
                this.dtPriHabFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string categoriaCnh
        {
            get
            {
                return this.categoriaCnhField;
            }
            set
            {
                this.categoriaCnhField = value;
            }
        }
    }
}
