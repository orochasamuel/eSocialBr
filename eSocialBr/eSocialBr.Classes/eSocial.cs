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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.esocial.gov.br/schema/evt/evtAdmissao/v02_04_01", IsNullable = false)]
    public class eSocial
    {

        private eSocialEvtAdmissao evtAdmissaoField;

        private SignatureType signatureField;

        /// <remarks/>
        public eSocialEvtAdmissao evtAdmissao
        {
            get
            {
                return this.evtAdmissaoField;
            }
            set
            {
                this.evtAdmissaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }
}
