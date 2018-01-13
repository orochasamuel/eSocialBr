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
    public partial class TContato
    {

        private string fonePrincField;

        private string foneAlternatField;

        private string emailPrincField;

        private string emailAlternatField;

        /// <remarks/>
        public string fonePrinc
        {
            get
            {
                return this.fonePrincField;
            }
            set
            {
                this.fonePrincField = value;
            }
        }

        /// <remarks/>
        public string foneAlternat
        {
            get
            {
                return this.foneAlternatField;
            }
            set
            {
                this.foneAlternatField = value;
            }
        }

        /// <remarks/>
        public string emailPrinc
        {
            get
            {
                return this.emailPrincField;
            }
            set
            {
                this.emailPrincField = value;
            }
        }

        /// <remarks/>
        public string emailAlternat
        {
            get
            {
                return this.emailAlternatField;
            }
            set
            {
                this.emailAlternatField = value;
            }
        }
    }
}
