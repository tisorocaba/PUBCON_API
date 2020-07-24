using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubconApi.Data
{
    public class Publicacao
    {
        public int Id { get; set; }
        public int IdStatusPublicacao { get; set; }
        public int AnoProcessoSiat { get; set; }
        public int NumeroProcessoSiat { get; set; }
        public int DigitoVerificadorProcessoSiat { get; set; }
        public int? CodigoAssuntoSiat { get; set; }
        public string AssuntoSiat { get; set; }
        public string Descricao { get; set; }
        public string DataAbertura { get; set; }
        public string DataPublicacao { get; set; }
        public int IdUnidade { get; set; }
        public string DataHoraCriacao { get; set; }
        public string DataHoraAlteracao { get; set; }
        public StatusPublicacao StatusPublicacao { get; set; }
        public Unidade Unidade { get; set; }
    }
}
