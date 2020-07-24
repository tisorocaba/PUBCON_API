using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubconApi.Data
{
    public class Convenio
    {
        public string NumeroParceria { get; set; }
        public decimal ValorInicialParceria { get; set; }
        public decimal ValorAtualParceria { get; set; }
        public string NumeroProcesso { get; set; }
        public string ProcessoConam { get; set; }
        public string Modalidade { get; set; }
        public int IdTipoParceria { get; set; }
        public string TipoTermo { get; set; }
        public string NaturezaConvenio { get; set; }
        public int Exercicio { get; set; }
        public string NomeOrganizacao { get; set; }
        public string NomeFantasia { get; set; }
        public string Objeto { get; set; }
        public string DataAssinatura { get; set; }
        public string DataFimParceria { get; set; }
        public string DataInicioParceria { get; set; }
        public string CnpjOrganizacao { get; set; }
        public string SecretariaResponsavel { get; set; }
        public string Secretaria1 { get; set; }
        public string Secretaria2 { get; set; }
        public decimal ValorComprometido { get; set; }
        public decimal TotalEmpenhadoConam { get; set; }
        public decimal TotalProcessadoConam { get; set; }
        public decimal ValoresLiberados { get; set; }
        public decimal Saldo { get; set; }
    }
}
