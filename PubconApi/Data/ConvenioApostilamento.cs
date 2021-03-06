﻿using System;
using System.Collections.Generic;

namespace PubconApi.Data
{
    public class ConvenioApostilamento
    {
        public int IdTermo { get; set; }
        public string NumeroParceria { get; set; }
        public string TermoApostilamento { get; set; }
        public string TipoTermo { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public decimal Valor { get; set; }
        public string Operacao { get; set; }
        public string Descricao { get; set; }
    }
}
