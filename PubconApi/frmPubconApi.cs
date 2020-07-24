using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubconApi
{
    public partial class frmPubconApi : Form
    {
        public frmPubconApi()
        {
            InitializeComponent();
        }

        private ApiWeb CriarApi()
        {
            int idUs = Convert.ToInt32(edtUsuario.Text);
            string senha = edtChave.Text;
            string url = edtUrl.Text;

            ApiWeb api = new ApiWeb(idUs, senha, url);

            return api;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(edtNumero.Text);
            int ano = Convert.ToInt32(edtAno.Text);

            ApiWeb api = CriarApi();

            var lista = api.ConsultarPublicacao(numero, ano);

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnConvenio_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(edtNumero.Text);
            int ano = Convert.ToInt32(edtAno.Text);

            ApiWeb api = CriarApi();

            var lista = api.ConsultarConvenio(numero, ano);

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnConvenioAd_Click(object sender, EventArgs e)
        {
            string parceria = edtParceria.Text;

            ApiWeb api = CriarApi();

            var lista = api.ConsultarConvenioAditivo(parceria);

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnConvenioAp_Click(object sender, EventArgs e)
        {
            string parceria = edtParceria.Text;

            ApiWeb api = CriarApi();

            var lista = api.ConsultarConvenioApostilamento(parceria);

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnConvenioPro_Click(object sender, EventArgs e)
        {
            string parceria = edtParceria.Text;

            ApiWeb api = CriarApi();

            var lista = api.ConsultarConvenioProrrogacao(parceria);

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnPrestacaoConta_Click(object sender, EventArgs e)
        {
            string parceria = edtParceria.Text;

            ApiWeb api = CriarApi();

            var lista = api.ConsultarPrestacaoConta(parceria);

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            ApiWeb api = CriarApi();

            var lista = api.ConsultarStatusPublicacao();

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnParceria_Click(object sender, EventArgs e)
        {
            ApiWeb api = CriarApi();

            var lista = api.ConsultarTipoParceria();

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnUnidade_Click(object sender, EventArgs e)
        {
            ApiWeb api = CriarApi();

            var lista = api.ConsultarUnidade();

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }
    }
}
