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
    public partial class TDadosContrato
    {

        private string codCargoField;

        private string codFuncaoField;

        private string codCategField;

        private string codCarreiraField;

        private System.DateTime dtIngrCarrField;

        private bool dtIngrCarrFieldSpecified;

        private TRemun remuneracaoField;

        private TDadosContratoDuracao duracaoField;

        private TDadosContratoLocalTrabalho localTrabalhoField;

        private TDadosContratoHorContratual horContratualField;

        private TDadosContratoFiliacaoSindical[] filiacaoSindicalField;

        private TDadosContratoAlvaraJudicial alvaraJudicialField;

        private TDadosContratoObservacoes[] observacoesField;

        /// <remarks/>
        public string codCargo
        {
            get
            {
                return this.codCargoField;
            }
            set
            {
                this.codCargoField = value;
            }
        }

        /// <remarks/>
        public string codFuncao
        {
            get
            {
                return this.codFuncaoField;
            }
            set
            {
                this.codFuncaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codCateg
        {
            get
            {
                return this.codCategField;
            }
            set
            {
                this.codCategField = value;
            }
        }

        /// <remarks/>
        public string codCarreira
        {
            get
            {
                return this.codCarreiraField;
            }
            set
            {
                this.codCarreiraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtIngrCarr
        {
            get
            {
                return this.dtIngrCarrField;
            }
            set
            {
                this.dtIngrCarrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtIngrCarrSpecified
        {
            get
            {
                return this.dtIngrCarrFieldSpecified;
            }
            set
            {
                this.dtIngrCarrFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TRemun remuneracao
        {
            get
            {
                return this.remuneracaoField;
            }
            set
            {
                this.remuneracaoField = value;
            }
        }

        /// <remarks/>
        public TDadosContratoDuracao duracao
        {
            get
            {
                return this.duracaoField;
            }
            set
            {
                this.duracaoField = value;
            }
        }

        /// <remarks/>
        public TDadosContratoLocalTrabalho localTrabalho
        {
            get
            {
                return this.localTrabalhoField;
            }
            set
            {
                this.localTrabalhoField = value;
            }
        }

        /// <remarks/>
        public TDadosContratoHorContratual horContratual
        {
            get
            {
                return this.horContratualField;
            }
            set
            {
                this.horContratualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("filiacaoSindical")]
        public TDadosContratoFiliacaoSindical[] filiacaoSindical
        {
            get
            {
                return this.filiacaoSindicalField;
            }
            set
            {
                this.filiacaoSindicalField = value;
            }
        }

        /// <remarks/>
        public TDadosContratoAlvaraJudicial alvaraJudicial
        {
            get
            {
                return this.alvaraJudicialField;
            }
            set
            {
                this.alvaraJudicialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observacoes")]
        public TDadosContratoObservacoes[] observacoes
        {
            get
            {
                return this.observacoesField;
            }
            set
            {
                this.observacoesField = value;
            }
        }
    }
}
