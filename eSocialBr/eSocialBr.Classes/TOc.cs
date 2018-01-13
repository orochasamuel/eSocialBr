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
    public partial class TOc
    {

        private string nrOcField;

        private string orgaoEmissorField;

        private System.DateTime dtExpedField;

        private bool dtExpedFieldSpecified;

        private System.DateTime dtValidField;

        private bool dtValidFieldSpecified;

        /// <remarks/>
        public string nrOc
        {
            get
            {
                return this.nrOcField;
            }
            set
            {
                this.nrOcField = value;
            }
        }

        /// <remarks/>
        public string orgaoEmissor
        {
            get
            {
                return this.orgaoEmissorField;
            }
            set
            {
                this.orgaoEmissorField = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtValidSpecified
        {
            get
            {
                return this.dtValidFieldSpecified;
            }
            set
            {
                this.dtValidFieldSpecified = value;
            }
        }
    }
}
