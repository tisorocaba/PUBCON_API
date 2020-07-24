using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PubconApi.Data
{
    public class RequestData
    {
        public string AnoProcesso { get; set; }
        public string NumeroProcesso { get; set; }
        public string CodigoAssunto { get; set; }
        public string Assunto { get; set; }
        public string CnpjOrganizacao { get; set; }
        public string NomeOrganizacao { get; set; }
        public string DataPublicacao { get; set; }
        public string IdUnidade { get; set; }
        public string IdStatusPublicacao { get; set; }
        public string IdTipoParceria { get; set; }
        public string NumeroParceria { get; set; }
    }
}