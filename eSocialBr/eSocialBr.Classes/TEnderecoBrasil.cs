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
    public partial class TEnderecoBrasil
    {

        private string tpLogradField;

        private string dscLogradField;

        private string nrLogradField;

        private string complementoField;

        private string bairroField;

        private string cepField;

        private string codMunicField;

        private TEnderecoBrasilUF ufField;

        /// <remarks/>
        public string tpLograd
        {
            get
            {
                return this.tpLogradField;
            }
            set
            {
                this.tpLogradField = value;
            }
        }

        /// <remarks/>
        public string dscLograd
        {
            get
            {
                return this.dscLogradField;
            }
            set
            {
                this.dscLogradField = value;
            }
        }

        /// <remarks/>
        public string nrLograd
        {
            get
            {
                return this.nrLogradField;
            }
            set
            {
                this.nrLogradField = value;
            }
        }

        /// <remarks/>
        public string complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }

        /// <remarks/>
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }

        /// <remarks/>
        public string cep
        {
            get
            {
                return this.cepField;
            }
            set
            {
                this.cepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codMunic
        {
            get
            {
                return this.codMunicField;
            }
            set
            {
                this.codMunicField = value;
            }
        }

        /// <remarks/>
        public TEnderecoBrasilUF uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }
}
