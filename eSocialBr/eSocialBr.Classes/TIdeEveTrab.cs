namespace eSocialBr.Classes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.esocial.gov.br/schema/evt/evtAdmissao/v02_04_01")]
    public class TIdeEveTrab
    {

        private sbyte indRetifField;

        private string nrReciboField;

        private sbyte tpAmbField;

        private sbyte procEmiField;

        private string verProcField;

        /// <remarks/>
        public sbyte indRetif
        {
            get
            {
                return this.indRetifField;
            }
            set
            {
                this.indRetifField = value;
            }
        }

        /// <remarks/>
        public string nrRecibo
        {
            get
            {
                return this.nrReciboField;
            }
            set
            {
                this.nrReciboField = value;
            }
        }

        /// <remarks/>
        public sbyte tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public sbyte procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
            }
        }

        /// <remarks/>
        public string verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }
    }
}