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
    public partial class TRg
    {

        private string nrRgField;

        private string orgaoEmissorField;

        private System.DateTime dtExpedField;

        private bool dtExpedFieldSpecified;

        /// <remarks/>
        public string nrRg
        {
            get
            {
                return this.nrRgField;
            }
            set
            {
                this.nrRgField = value;
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
    }
}
