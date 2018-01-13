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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.esocial.gov.br/schema/evt/evtAdmissao/v02_04_01")]
    public partial class TDadosContratoDuracao
    {

        private sbyte tpContrField;

        private System.DateTime dtTermField;

        private bool dtTermFieldSpecified;

        private string clauAssecField;

        /// <remarks/>
        public sbyte tpContr
        {
            get
            {
                return this.tpContrField;
            }
            set
            {
                this.tpContrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtTerm
        {
            get
            {
                return this.dtTermField;
            }
            set
            {
                this.dtTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtTermSpecified
        {
            get
            {
                return this.dtTermFieldSpecified;
            }
            set
            {
                this.dtTermFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string clauAssec
        {
            get
            {
                return this.clauAssecField;
            }
            set
            {
                this.clauAssecField = value;
            }
        }
    }
}
