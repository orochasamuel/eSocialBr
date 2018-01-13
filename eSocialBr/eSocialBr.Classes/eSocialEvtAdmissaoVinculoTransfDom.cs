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
    public class eSocialEvtAdmissaoVinculoTransfDom
    {

        private string cpfSubstituidoField;

        private string matricAntField;

        private System.DateTime dtTransfField;

        /// <remarks/>
        public string cpfSubstituido
        {
            get
            {
                return this.cpfSubstituidoField;
            }
            set
            {
                this.cpfSubstituidoField = value;
            }
        }

        /// <remarks/>
        public string matricAnt
        {
            get
            {
                return this.matricAntField;
            }
            set
            {
                this.matricAntField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtTransf
        {
            get
            {
                return this.dtTransfField;
            }
            set
            {
                this.dtTransfField = value;
            }
        }
    }
}
