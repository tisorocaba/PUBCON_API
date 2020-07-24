using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PubconApi.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PubconApi
{
    public class ApiWeb
    {
        public struct HttpResult
        {
            public Boolean Erro;
            public string MensagemErro;
        }

        public HttpResult httpResult;

        int idUsuario;
        string secret;
        
        string rtBaseUrl = "";
        string rtPublicacao = "/publicacao";
        string rtConvenio = "/convenio?numero=<paramNumero>&ano=<paramAno>";
        string rtConvenioAditivo = "/convenioAditivo?nrParceria=<paramNrParceria>";
        string rtConvenioApostilamento = "/convenioApostilamento?nrParceria=<paramNrParceria>";
        string rtConvenioProrrogacao = "/convenioProrrogacao?nrParceria=<paramNrParceria>";
        string rtPrestacaoConta = "/prestacaoConta?nrParceria=<paramNrParceria>";
        string rtStatus = "/statusPublicacao";
        string rtTipoParceria = "/tipoParceria";
        string rtUnidade = "/unidade";

        public ApiWeb(int idUs, string senhaUs, string url)
        {
            idUsuario = idUs;
            secret = senhaUs;
            if (!string.IsNullOrWhiteSpace(url)) rtBaseUrl = url;
        }


        private string GetSignature(int idUsuario, string secret, string nonce, object obj)
        {
            string texto = nonce + idUsuario.ToString();

            if (obj != null) texto = texto + JsonConvert.SerializeObject(obj);

            return GerarHash(texto, secret);
        }


        private string GetTimeStamp()
        {
            long nonce = Convert.ToInt64(TimeSpan.FromTicks(DateTime.UtcNow.Ticks).TotalMilliseconds);
            return nonce.ToString();
        }


        private string GerarHash(string texto, string secret)
        {
            HMACSHA256 hashMaker;
            hashMaker = new HMACSHA256(Encoding.UTF8.GetBytes(secret));

            byte[] data = Encoding.UTF8.GetBytes(texto);
            byte[] hash = hashMaker.ComputeHash(data);
            string signature = GetHexString(hash);

            return signature;
        }


        private string GetHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                sb.Append(String.Format("{0:x2}", b));
            }

            return sb.ToString();
        }

        private string ValidarRetorno(string response)
        {
            ResponseData resp = JsonConvert.DeserializeObject<ResponseData>(response);

            if (!resp.Error)
            {
                return resp.Data.ToString();
            }
            else
            {
                httpResult.Erro = true;
                httpResult.MensagemErro = resp.Message;

                return "";
            }
        }


        private string SendRequest(string url, object obj, string metodo)
        {
            string nonce = GetTimeStamp();

            string signRequest = GetSignature(idUsuario, secret, nonce, obj);

            HttpWebRequest wr = WebRequest.Create(url) as HttpWebRequest;
            wr.ContentType = "application/json";
            wr.Headers.Add("PUB_API_USER", idUsuario.ToString());
            wr.Headers.Add("PUB_API_TIMESTAMP", nonce);
            wr.Headers.Add("PUB_API_SIGN", signRequest);
            wr.Method = metodo;

            string response = null;

            try
            {
                // adiciona obj ao corpo da requisição
                if (obj != null && metodo == "POST")
                {
                    using (var streamWriter = new StreamWriter(wr.GetRequestStream()))
                    {
                        string json = JsonConvert.SerializeObject(obj);
                        streamWriter.Write(json);
                    }
                }

                HttpWebResponse resp = wr.GetResponse() as HttpWebResponse;
                StreamReader sr = new StreamReader(resp.GetResponseStream());
                response = sr.ReadToEnd();
                sr.Close();

                httpResult.Erro = false;
                httpResult.MensagemErro = "";

                response = ValidarRetorno(response);
            }
            catch (WebException ex)
            {
                httpResult.Erro = true;
                httpResult.MensagemErro = ex.Message;
                response = "";
            }

            return response;
        }


        public List<Publicacao> ConsultarPublicacao(int numeroProcesso, int anoProcesso)
        {
            string url = rtBaseUrl + rtPublicacao;
            string metodo = "POST";

            RequestData obj = new RequestData { NumeroProcesso = numeroProcesso.ToString(), AnoProcesso = anoProcesso.ToString() };
            string response = SendRequest(url, obj, metodo);

            List<Publicacao> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<Publicacao>>(response);
            }

            return lista;
        }


        public List<Convenio> ConsultarConvenio(int numeroProcesso, int anoProcesso)
        {
            string url = rtBaseUrl + rtConvenio.Replace("<paramNumero>", numeroProcesso.ToString()).Replace("<paramAno>", anoProcesso.ToString());

            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<Convenio> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<Convenio>>(response);
            }

            return lista;
        }


        public List<ConvenioAditivo> ConsultarConvenioAditivo(string nrParceria)
        {
            string url = rtBaseUrl + rtConvenioAditivo.Replace("<paramNrParceria>", nrParceria);

            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<ConvenioAditivo> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<ConvenioAditivo>>(response);
            }

            return lista;
        }


        public List<ConvenioApostilamento> ConsultarConvenioApostilamento(string nrParceria)
        {
            string url = rtBaseUrl + rtConvenioApostilamento.Replace("<paramNrParceria>", nrParceria);

            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<ConvenioApostilamento> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<ConvenioApostilamento>>(response);
            }

            return lista;
        }


        public List<ConvenioProrrogacao> ConsultarConvenioProrrogacao(string nrParceria)
        {
            string url = rtBaseUrl + rtConvenioProrrogacao.Replace("<paramNrParceria>", nrParceria);

            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<ConvenioProrrogacao> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<ConvenioProrrogacao>>(response);
            }

            return lista;
        }


        public List<PrestacaoConta> ConsultarPrestacaoConta(string nrParceria)
        {
            string url = rtBaseUrl + rtPrestacaoConta.Replace("<paramNrParceria>", nrParceria);

            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<PrestacaoConta> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<PrestacaoConta>>(response);
            }

            return lista;
        }


        public List<StatusPublicacao> ConsultarStatusPublicacao()
        {
            string url = rtBaseUrl + rtStatus;
            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<StatusPublicacao> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<StatusPublicacao>>(response);
            }

            return lista;
        }


        public List<TipoParceria> ConsultarTipoParceria()
        {
            string url = rtBaseUrl + rtTipoParceria;
            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<TipoParceria> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<TipoParceria>>(response);
            }

            return lista;
        }


        public List<Unidade> ConsultarUnidade()
        {
            string url = rtBaseUrl + rtUnidade;
            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<Unidade> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<Unidade>>(response);
            }

            return lista;
        }

    }
}
