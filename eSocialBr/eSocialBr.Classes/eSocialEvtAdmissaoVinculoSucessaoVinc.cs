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
    public class eSocialEvtAdmissaoVinculoSucessaoVinc
    {

        private string cnpjEmpregAntField;

        private string matricAntField;

        private System.DateTime dtTransfField;

        private string observacaoField;

        /// <remarks/>
        public string cnpjEmpregAnt
        {
            get
            {
                return this.cnpjEmpregAntField;
            }
            set
            {
                this.cnpjEmpregAntField = value;
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

        /// <remarks/>
        public string observacao
        {
            get
            {
                return this.observacaoField;
            }
            set
            {
                this.observacaoField = value;
            }
        }
    }
}
