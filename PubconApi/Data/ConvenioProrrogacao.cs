using System;
using System.Collections.Generic;

namespace PubconApi.Data
{
    public class ConvenioProrrogacao
    {
        public int IdTermo { get; set; }
        public string NumeroParceria { get; set; }
        public string TermoProrrogacao { get; set; }
        public string TipoTermo { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
