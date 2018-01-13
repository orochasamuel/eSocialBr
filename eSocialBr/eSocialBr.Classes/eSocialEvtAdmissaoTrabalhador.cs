using System;
using System.Collections.Generic;
using System.Text;

namespace eSocialBr.Classes
{
    ///
    /// S-2200 - Cadastramento Inicial do Vínculo e Admissão/Ingresso de Trabalhador 
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.esocial.gov.br/schema/evt/evtAdmissao/v02_04_01")]
    public class eSocialEvtAdmissaoTrabalhador
    {
        private string cpfTrabField;

        private string nisTrabField;

        private string nmTrabField;

        private string sexoField;

        private sbyte racaCorField;

        private sbyte estCivField;

        private bool estCivFieldSpecified;

        private string grauInstrField;

        private string indPriEmprField;

        private string nmSocField;

        private eSocialEvtAdmissaoTrabalhadorNascimento nascimentoField;

        private eSocialEvtAdmissaoTrabalhadorDocumentos documentosField;

        private eSocialEvtAdmissaoTrabalhadorEndereco enderecoField;

        private TTrabEstrang trabEstrangeiroField;

        private eSocialEvtAdmissaoTrabalhadorInfoDeficiencia infoDeficienciaField;

        private TDependente[] dependenteField;

        private eSocialEvtAdmissaoTrabalhadorAposentadoria aposentadoriaField;

        private TContato contatoField;

        /// <remarks/>
        public string cpfTrab
        {
            get
            {
                return this.cpfTrabField;
            }
            set
            {
                this.cpfTrabField = value;
            }
        }

        /// <remarks/>
        public string nisTrab
        {
            get
            {
                return this.nisTrabField;
            }
            set
            {
                this.nisTrabField = value;
            }
        }

        /// <remarks/>
        public string nmTrab
        {
            get
            {
                return this.nmTrabField;
            }
            set
            {
                this.nmTrabField = value;
            }
        }

        /// <remarks/>
        public string sexo
        {
            get
            {
                return this.sexoField;
            }
            set
            {
                this.sexoField = value;
            }
        }

        /// <remarks/>
        public sbyte racaCor
        {
            get
            {
                return this.racaCorField;
            }
            set
            {
                this.racaCorField = value;
            }
        }

        /// <remarks/>
        public sbyte estCiv
        {
            get
            {
                return this.estCivField;
            }
            set
            {
                this.estCivField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estCivSpecified
        {
            get
            {
                return this.estCivFieldSpecified;
            }
            set
            {
                this.estCivFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string grauInstr
        {
            get
            {
                return this.grauInstrField;
            }
            set
            {
                this.grauInstrField = value;
            }
        }

        /// <remarks/>
        public string indPriEmpr
        {
            get
            {
                return this.indPriEmprField;
            }
            set
            {
                this.indPriEmprField = value;
            }
        }

        /// <remarks/>
        public string nmSoc
        {
            get
            {
                return this.nmSocField;
            }
            set
            {
                this.nmSocField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoTrabalhadorNascimento nascimento
        {
            get
            {
                return this.nascimentoField;
            }
            set
            {
                this.nascimentoField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoTrabalhadorDocumentos documentos
        {
            get
            {
                return this.documentosField;
            }
            set
            {
                this.documentosField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoTrabalhadorEndereco endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }

        /// <remarks/>
        public TTrabEstrang trabEstrangeiro
        {
            get
            {
                return this.trabEstrangeiroField;
            }
            set
            {
                this.trabEstrangeiroField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoTrabalhadorInfoDeficiencia infoDeficiencia
        {
            get
            {
                return this.infoDeficienciaField;
            }
            set
            {
                this.infoDeficienciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dependente")]
        public TDependente[] dependente
        {
            get
            {
                return this.dependenteField;
            }
            set
            {
                this.dependenteField = value;
            }
        }

        /// <remarks/>
        public eSocialEvtAdmissaoTrabalhadorAposentadoria aposentadoria
        {
            get
            {
                return this.aposentadoriaField;
            }
            set
            {
                this.aposentadoriaField = value;
            }
        }

        /// <remarks/>
        public TContato contato
        {
            get
            {
                return this.contatoField;
            }
            set
            {
                this.contatoField = value;
            }
        }
    }
}