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
    public class TEmpregador
    {

        private sbyte tpInscField;

        private string nrInscField;

        /// <remarks/>
        public sbyte tpInsc
        {
            get
            {
                return this.tpInscField;
            }
            set
            {
                this.tpInscField = value;
            }
        }

        /// <remarks/>
        public string nrInsc
        {
            get
            {
                return this.nrInscField;
            }
            set
            {
                this.nrInscField = value;
            }
        }
    }
}
