using System;
using System.Collections.Generic;

namespace PubconApi.Data
{
    public class TipoParceria
    {
        public int IdTipoParceria { get; set; }
        public int? IdTipoDocSup { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
    }
}
