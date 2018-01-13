using eSocialBr.Classes.Enums;

namespace eSocialBr.Classes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtAdmissao/v02_04_01")]
    public class eSocialEvtAdmissaoTrabalhadorNascimento
    {
        private System.DateTime dtNasctoField;

        private string codMunicField;

        private eSocialEvtAdmissaoTrabalhadorNascimentoUF ufField;

        private bool ufFieldSpecified;

        private string paisNasctoField;

        private string paisNacField;

        private string nmMaeField;

        private string nmPaiField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtNascto
        {
            get { return this.dtNasctoField; }
            set { this.dtNasctoField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codMunic
        {
            get { return this.codMunicField; }
            set { this.codMunicField = value; }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoTrabalhadorNascimentoUF uf
        {
            get { return this.ufField; }
            set { this.ufField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ufSpecified
        {
            get { return this.ufFieldSpecified; }
            set { this.ufFieldSpecified = value; }
        }

        /// <remarks/>
        public string paisNascto
        {
            get { return this.paisNasctoField; }
            set { this.paisNasctoField = value; }
        }

        /// <remarks/>
        public string paisNac
        {
            get { return this.paisNacField; }
            set { this.paisNacField = value; }
        }

        /// <remarks/>
        public string nmMae
        {
            get { return this.nmMaeField; }
            set { this.nmMaeField = value; }
        }

        /// <remarks/>
        public string nmPai
        {
            get { return this.nmPaiField; }
            set { this.nmPaiField = value; }
        }
    }
}