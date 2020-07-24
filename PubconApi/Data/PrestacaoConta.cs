using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubconApi.Data
{
    public class PrestacaoConta
    {
        public int Id { get; set; }
        public int AnoProcesso { get; set; }
        public int NumeroProcesso { get; set; }
        public int DigitoVerificadorProcesso { get; set; }
        public string NumeroTermo { get; set; }
        public string Periodicidade { get; set; }
        public string PeriodoReferencia { get; set; }
        public string PrevisaoApresentacao { get; set; }
        public string PrazoAnalise { get; set; }
        public string Fonte { get; set; }
        public string DataApresentacao { get; set; }
        public string ResultadoConclusivo { get; set; }
        public string DataResultadoConclusivo { get; set; }
    }
}
