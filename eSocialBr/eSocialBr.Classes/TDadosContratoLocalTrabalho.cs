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
    public partial class TDadosContratoLocalTrabalho
    {

        private TLocalTrab localTrabGeralField;

        private TEnderecoBrasil localTrabDomField;

        /// <remarks/>
        public TLocalTrab localTrabGeral
        {
            get
            {
                return this.localTrabGeralField;
            }
            set
            {
                this.localTrabGeralField = value;
            }
        }

        /// <remarks/>
        public TEnderecoBrasil localTrabDom
        {
            get
            {
                return this.localTrabDomField;
            }
            set
            {
                this.localTrabDomField = value;
            }
        }
    }
}
