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
    public class eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletista
    {

        private System.DateTime dtAdmField;

        private sbyte tpAdmissaoField;

        private sbyte indAdmissaoField;

        private sbyte tpRegJorField;

        private sbyte natAtividadeField;

        private sbyte dtBaseField;

        private bool dtBaseFieldSpecified;

        private string cnpjSindCategProfField;

        private TFgts fGTSField;

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporario trabTemporarioField;

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaAprend aprendField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtAdm
        {
            get
            {
                return this.dtAdmField;
            }
            set
            {
                this.dtAdmField = value;
            }
        }

        /// <remarks/>
        public sbyte tpAdmissao
        {
            get
            {
                return this.tpAdmissaoField;
            }
            set
            {
                this.tpAdmissaoField = value;
            }
        }

        /// <remarks/>
        public sbyte indAdmissao
        {
            get
            {
                return this.indAdmissaoField;
            }
            set
            {
                this.indAdmissaoField = value;
            }
        }

        /// <remarks/>
        public sbyte tpRegJor
        {
            get
            {
                return this.tpRegJorField;
            }
            set
            {
                this.tpRegJorField = value;
            }
        }

        /// <remarks/>
        public sbyte natAtividade
        {
            get
            {
                return this.natAtividadeField;
            }
            set
            {
                this.natAtividadeField = value;
            }
        }

        /// <remarks/>
        public sbyte dtBase
        {
            get
            {
                return this.dtBaseField;
            }
            set
            {
                this.dtBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtBaseSpecified
        {
            get
            {
                return this.dtBaseFieldSpecified;
            }
            set
            {
                this.dtBaseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string cnpjSindCategProf
        {
            get
            {
                return this.cnpjSindCategProfField;
            }
            set
            {
                this.cnpjSindCategProfField = value;
            }
        }

        /// <remarks/>
        public TFgts FGTS
        {
            get
            {
                return this.fGTSField;
            }
            set
            {
                this.fGTSField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporario trabTemporario
        {
            get
            {
                return this.trabTemporarioField;
            }
            set
            {
                this.trabTemporarioField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaAprend aprend
        {
            get
            {
                return this.aprendField;
            }
            set
            {
                this.aprendField = value;
            }
        }
    }
}
