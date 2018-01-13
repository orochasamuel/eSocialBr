using eSocialBr.Classes.Enums;
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
    public partial class TCtps
    {

        private string nrCtpsField;

        private string serieCtpsField;

        private TCtpsUfCtps ufCtpsField;

        /// <remarks/>
        public string nrCtps
        {
            get
            {
                return this.nrCtpsField;
            }
            set
            {
                this.nrCtpsField = value;
            }
        }

        /// <remarks/>
        public string serieCtps
        {
            get
            {
                return this.serieCtpsField;
            }
            set
            {
                this.serieCtpsField = value;
            }
        }

        /// <remarks/>
        public TCtpsUfCtps ufCtps
        {
            get
            {
                return this.ufCtpsField;
            }
            set
            {
                this.ufCtpsField = value;
            }
        }
    }
}
