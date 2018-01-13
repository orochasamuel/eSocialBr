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
    public partial class TFgts
    {

        private string opcFGTSField;

        private System.DateTime dtOpcFGTSField;

        private bool dtOpcFGTSFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string opcFGTS
        {
            get
            {
                return this.opcFGTSField;
            }
            set
            {
                this.opcFGTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtOpcFGTS
        {
            get
            {
                return this.dtOpcFGTSField;
            }
            set
            {
                this.dtOpcFGTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtOpcFGTSSpecified
        {
            get
            {
                return this.dtOpcFGTSFieldSpecified;
            }
            set
            {
                this.dtOpcFGTSFieldSpecified = value;
            }
        }
    }
}
