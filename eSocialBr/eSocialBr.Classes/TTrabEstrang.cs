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
    public partial class TTrabEstrang
    {

        private System.DateTime dtChegadaField;

        private sbyte classTrabEstrangField;

        private string casadoBrField;

        private string filhosBrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtChegada
        {
            get
            {
                return this.dtChegadaField;
            }
            set
            {
                this.dtChegadaField = value;
            }
        }

        /// <remarks/>
        public sbyte classTrabEstrang
        {
            get
            {
                return this.classTrabEstrangField;
            }
            set
            {
                this.classTrabEstrangField = value;
            }
        }

        /// <remarks/>
        public string casadoBr
        {
            get
            {
                return this.casadoBrField;
            }
            set
            {
                this.casadoBrField = value;
            }
        }

        /// <remarks/>
        public string filhosBr
        {
            get
            {
                return this.filhosBrField;
            }
            set
            {
                this.filhosBrField = value;
            }
        }
    }
}
