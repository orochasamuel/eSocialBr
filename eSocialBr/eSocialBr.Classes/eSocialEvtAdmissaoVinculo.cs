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
    public class eSocialEvtAdmissaoVinculo
    {

        private string matriculaField;

        private sbyte tpRegTrabField;

        private sbyte tpRegPrevField;

        private string nrRecInfPrelimField;

        private string cadIniField;

        private eSocialEvtAdmissaoVinculoInfoRegimeTrab infoRegimeTrabField;

        private TDadosContrato infoContratoField;

        private eSocialEvtAdmissaoVinculoSucessaoVinc sucessaoVincField;

        private eSocialEvtAdmissaoVinculoTransfDom transfDomField;

        private eSocialEvtAdmissaoVinculoAfastamento afastamentoField;

        private eSocialEvtAdmissaoVinculoDesligamento desligamentoField;

        /// <remarks/>
        public string matricula
        {
            get
            {
                return this.matriculaField;
            }
            set
            {
                this.matriculaField = value;
            }
        }

        /// <remarks/>
        public sbyte tpRegTrab
        {
            get
            {
                return this.tpRegTrabField;
            }
            set
            {
                this.tpRegTrabField = value;
            }
        }

        /// <remarks/>
        public sbyte tpRegPrev
        {
            get
            {
                return this.tpRegPrevField;
            }
            set
            {
                this.tpRegPrevField = value;
            }
        }

        /// <remarks/>
        public string nrRecInfPrelim
        {
            get
            {
                return this.nrRecInfPrelimField;
            }
            set
            {
                this.nrRecInfPrelimField = value;
            }
        }

        /// <remarks/>
        public string cadIni
        {
            get
            {
                return this.cadIniField;
            }
            set
            {
                this.cadIniField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoInfoRegimeTrab infoRegimeTrab
        {
            get
            {
                return this.infoRegimeTrabField;
            }
            set
            {
                this.infoRegimeTrabField = value;
            }
        }

        /// <remarks/>
        public TDadosContrato infoContrato
        {
            get
            {
                return this.infoContratoField;
            }
            set
            {
                this.infoContratoField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoSucessaoVinc sucessaoVinc
        {
            get
            {
                return this.sucessaoVincField;
            }
            set
            {
                this.sucessaoVincField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoTransfDom transfDom
        {
            get
            {
                return this.transfDomField;
            }
            set
            {
                this.transfDomField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoAfastamento afastamento
        {
            get
            {
                return this.afastamentoField;
            }
            set
            {
                this.afastamentoField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoDesligamento desligamento
        {
            get
            {
                return this.desligamentoField;
            }
            set
            {
                this.desligamentoField = value;
            }
        }
    }
}
