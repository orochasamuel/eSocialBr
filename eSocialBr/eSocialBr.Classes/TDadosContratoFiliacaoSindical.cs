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
    public partial class TDadosContratoFiliacaoSindical
    {

        private string cnpjSindTrabField;

        /// <remarks/>
        public string cnpjSindTrab
        {
            get
            {
                return this.cnpjSindTrabField;
            }
            set
            {
                this.cnpjSindTrabField = value;
            }
        }
    }
}
