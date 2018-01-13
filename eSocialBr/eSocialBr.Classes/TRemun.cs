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
    public partial class TRemun
    {

        private decimal vrSalFxField;

        private sbyte undSalFixoField;

        private string dscSalVarField;

        /// <remarks/>
        public decimal vrSalFx
        {
            get
            {
                return this.vrSalFxField;
            }
            set
            {
                this.vrSalFxField = value;
            }
        }

        /// <remarks/>
        public sbyte undSalFixo
        {
            get
            {
                return this.undSalFixoField;
            }
            set
            {
                this.undSalFixoField = value;
            }
        }

        /// <remarks/>
        public string dscSalVar
        {
            get
            {
                return this.dscSalVarField;
            }
            set
            {
                this.dscSalVarField = value;
            }
        }
    }
}
