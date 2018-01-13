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
    public class eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporario
    {

        private sbyte hipLegField;

        private string justContrField;

        private sbyte tpInclContrField;

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeTomadorServ ideTomadorServField;

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeTrabSubstituido[] ideTrabSubstituidoField;

        /// <remarks/>
        public sbyte hipLeg
        {
            get
            {
                return this.hipLegField;
            }
            set
            {
                this.hipLegField = value;
            }
        }

        /// <remarks/>
        public string justContr
        {
            get
            {
                return this.justContrField;
            }
            set
            {
                this.justContrField = value;
            }
        }

        /// <remarks/>
        public sbyte tpInclContr
        {
            get
            {
                return this.tpInclContrField;
            }
            set
            {
                this.tpInclContrField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeTomadorServ ideTomadorServ
        {
            get
            {
                return this.ideTomadorServField;
            }
            set
            {
                this.ideTomadorServField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ideTrabSubstituido")]
        public eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeTrabSubstituido[] ideTrabSubstituido
        {
            get
            {
                return this.ideTrabSubstituidoField;
            }
            set
            {
                this.ideTrabSubstituidoField = value;
            }
        }
    }
}
