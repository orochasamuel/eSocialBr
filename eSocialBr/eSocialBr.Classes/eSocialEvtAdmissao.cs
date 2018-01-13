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
    public class eSocialEvtAdmissao
    {

        private TIdeEveTrab ideEventoField;

        private TEmpregador ideEmpregadorField;

        private eSocialEvtAdmissaoTrabalhador trabalhadorField;

        private eSocialEvtAdmissaoVinculo vinculoField;

        private string idField;

        /// <remarks/>
        public TIdeEveTrab ideEvento
        {
            get
            {
                return this.ideEventoField;
            }
            set
            {
                this.ideEventoField = value;
            }
        }

        /// <remarks/>
        public TEmpregador ideEmpregador
        {
            get
            {
                return this.ideEmpregadorField;
            }
            set
            {
                this.ideEmpregadorField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoTrabalhador trabalhador
        {
            get
            {
                return this.trabalhadorField;
            }
            set
            {
                this.trabalhadorField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoVinculo vinculo
        {
            get
            {
                return this.vinculoField;
            }
            set
            {
                this.vinculoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}
