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
    public class eSocialEvtAdmissaoVinculoAfastamento
    {

        private System.DateTime dtIniAfastField;

        private string codMotAfastField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtIniAfast
        {
            get
            {
                return this.dtIniAfastField;
            }
            set
            {
                this.dtIniAfastField = value;
            }
        }

        /// <remarks/>
        public string codMotAfast
        {
            get
            {
                return this.codMotAfastField;
            }
            set
            {
                this.codMotAfastField = value;
            }
        }
    }
}
