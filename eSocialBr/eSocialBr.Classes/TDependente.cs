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
    public partial class TDependente
    {

        private string tpDepField;

        private string nmDepField;

        private System.DateTime dtNasctoField;

        private string cpfDepField;

        private string depIRRFField;

        private string depSFField;

        private string incTrabField;

        /// <remarks/>
        public string tpDep
        {
            get
            {
                return this.tpDepField;
            }
            set
            {
                this.tpDepField = value;
            }
        }

        /// <remarks/>
        public string nmDep
        {
            get
            {
                return this.nmDepField;
            }
            set
            {
                this.nmDepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtNascto
        {
            get
            {
                return this.dtNasctoField;
            }
            set
            {
                this.dtNasctoField = value;
            }
        }

        /// <remarks/>
        public string cpfDep
        {
            get
            {
                return this.cpfDepField;
            }
            set
            {
                this.cpfDepField = value;
            }
        }

        /// <remarks/>
        public string depIRRF
        {
            get
            {
                return this.depIRRFField;
            }
            set
            {
                this.depIRRFField = value;
            }
        }

        /// <remarks/>
        public string depSF
        {
            get
            {
                return this.depSFField;
            }
            set
            {
                this.depSFField = value;
            }
        }

        /// <remarks/>
        public string incTrab
        {
            get
            {
                return this.incTrabField;
            }
            set
            {
                this.incTrabField = value;
            }
        }
    }
}
