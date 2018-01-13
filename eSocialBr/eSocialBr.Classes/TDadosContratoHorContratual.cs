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
    public partial class TDadosContratoHorContratual
    {

        private decimal qtdHrsSemField;

        private bool qtdHrsSemFieldSpecified;

        private sbyte tpJornadaField;

        private string dscTpJornField;

        private sbyte tmpParcField;

        private THorario[] horarioField;

        /// <remarks/>
        public decimal qtdHrsSem
        {
            get
            {
                return this.qtdHrsSemField;
            }
            set
            {
                this.qtdHrsSemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtdHrsSemSpecified
        {
            get
            {
                return this.qtdHrsSemFieldSpecified;
            }
            set
            {
                this.qtdHrsSemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public sbyte tpJornada
        {
            get
            {
                return this.tpJornadaField;
            }
            set
            {
                this.tpJornadaField = value;
            }
        }

        /// <remarks/>
        public string dscTpJorn
        {
            get
            {
                return this.dscTpJornField;
            }
            set
            {
                this.dscTpJornField = value;
            }
        }

        /// <remarks/>
        public sbyte tmpParc
        {
            get
            {
                return this.tmpParcField;
            }
            set
            {
                this.tmpParcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("horario")]
        public THorario[] horario
        {
            get
            {
                return this.horarioField;
            }
            set
            {
                this.horarioField = value;
            }
        }
    }
}
