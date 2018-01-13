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
    public partial class THorario
    {

        private sbyte diaField;

        private string codHorContratField;

        /// <remarks/>
        public sbyte dia
        {
            get
            {
                return this.diaField;
            }
            set
            {
                this.diaField = value;
            }
        }

        /// <remarks/>
        public string codHorContrat
        {
            get
            {
                return this.codHorContratField;
            }
            set
            {
                this.codHorContratField = value;
            }
        }
    }
}
