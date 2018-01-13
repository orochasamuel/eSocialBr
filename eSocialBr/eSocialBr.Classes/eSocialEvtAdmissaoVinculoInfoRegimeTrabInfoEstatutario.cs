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
    public class eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoEstatutario
    {

        private sbyte indProvimField;

        private sbyte tpProvField;

        private System.DateTime dtNomeacaoField;

        private System.DateTime dtPosseField;

        private System.DateTime dtExercicioField;

        private sbyte tpPlanRPField;

        private bool tpPlanRPFieldSpecified;

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoEstatutarioInfoDecJud infoDecJudField;

        /// <remarks/>
        public sbyte indProvim
        {
            get
            {
                return this.indProvimField;
            }
            set
            {
                this.indProvimField = value;
            }
        }

        /// <remarks/>
        public sbyte tpProv
        {
            get
            {
                return this.tpProvField;
            }
            set
            {
                this.tpProvField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtNomeacao
        {
            get
            {
                return this.dtNomeacaoField;
            }
            set
            {
                this.dtNomeacaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtPosse
        {
            get
            {
                return this.dtPosseField;
            }
            set
            {
                this.dtPosseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtExercicio
        {
            get
            {
                return this.dtExercicioField;
            }
            set
            {
                this.dtExercicioField = value;
            }
        }

        /// <remarks/>
        public sbyte tpPlanRP
        {
            get
            {
                return this.tpPlanRPField;
            }
            set
            {
                this.tpPlanRPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tpPlanRPSpecified
        {
            get
            {
                return this.tpPlanRPFieldSpecified;
            }
            set
            {
                this.tpPlanRPFieldSpecified = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoEstatutarioInfoDecJud infoDecJud
        {
            get
            {
                return this.infoDecJudField;
            }
            set
            {
                this.infoDecJudField = value;
            }
        }
    }
}
