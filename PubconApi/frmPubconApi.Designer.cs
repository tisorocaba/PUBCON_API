namespace PubconApi
{
    partial class frmPubconApi
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.edtUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtUsuario = new System.Windows.Forms.TextBox();
            this.edtParceria = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNumero = new System.Windows.Forms.TextBox();
            this.edtAno = new System.Windows.Forms.TextBox();
            this.btnConvenio = new System.Windows.Forms.Button();
            this.edtChave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConvenioAd = new System.Windows.Forms.Button();
            this.btnConvenioAp = new System.Windows.Forms.Button();
            this.btnConvenioPro = new System.Windows.Forms.Button();
            this.btnPrestacaoConta = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnParceria = new System.Windows.Forms.Button();
            this.btnUnidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Url";
            // 
            // edtUrl
            // 
            this.edtUrl.Location = new System.Drawing.Point(221, 19);
            this.edtUrl.Name = "edtUrl";
            this.edtUrl.Size = new System.Drawing.Size(337, 20);
            this.edtUrl.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Parceria";
            // 
            // edtUsuario
            // 
            this.edtUsuario.Location = new System.Drawing.Point(64, 97);
            this.edtUsuario.Name = "edtUsuario";
            this.edtUsuario.Size = new System.Drawing.Size(100, 20);
            this.edtUsuario.TabIndex = 38;
            // 
            // edtParceria
            // 
            this.edtParceria.Location = new System.Drawing.Point(64, 71);
            this.edtParceria.Name = "edtParceria";
            this.edtParceria.Size = new System.Drawing.Size(100, 20);
            this.edtParceria.TabIndex = 37;
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(16, 190);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(585, 201);
            this.dgvDados.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Retorno";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(198, 64);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Publicação";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ano";
            // 
            // edtNumero
            // 
            this.edtNumero.Location = new System.Drawing.Point(64, 45);
            this.edtNumero.Name = "edtNumero";
            this.edtNumero.Size = new System.Drawing.Size(100, 20);
            this.edtNumero.TabIndex = 31;
            // 
            // edtAno
            // 
            this.edtAno.Location = new System.Drawing.Point(64, 19);
            this.edtAno.Name = "edtAno";
            this.edtAno.Size = new System.Drawing.Size(100, 20);
            this.edtAno.TabIndex = 30;
            // 
            // btnConvenio
            // 
            this.btnConvenio.Location = new System.Drawing.Point(310, 64);
            this.btnConvenio.Name = "btnConvenio";
            this.btnConvenio.Size = new System.Drawing.Size(75, 23);
            this.btnConvenio.TabIndex = 46;
            this.btnConvenio.Text = "Convênio";
            this.btnConvenio.UseVisualStyleBackColor = true;
            this.btnConvenio.Click += new System.EventHandler(this.btnConvenio_Click);
            // 
            // edtChave
            // 
            this.edtChave.Location = new System.Drawing.Point(64, 123);
            this.edtChave.Name = "edtChave";
            this.edtChave.Size = new System.Drawing.Size(100, 20);
            this.edtChave.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Chave";
            // 
            // btnConvenioAd
            // 
            this.btnConvenioAd.Location = new System.Drawing.Point(198, 97);
            this.btnConvenioAd.Name = "btnConvenioAd";
            this.btnConvenioAd.Size = new System.Drawing.Size(75, 23);
            this.btnConvenioAd.TabIndex = 54;
            this.btnConvenioAd.Text = "Aditivo";
            this.btnConvenioAd.UseVisualStyleBackColor = true;
            this.btnConvenioAd.Click += new System.EventHandler(this.btnConvenioAd_Click);
            // 
            // btnConvenioAp
            // 
            this.btnConvenioAp.Location = new System.Drawing.Point(198, 126);
            this.btnConvenioAp.Name = "btnConvenioAp";
            this.btnConvenioAp.Size = new System.Drawing.Size(86, 23);
            this.btnConvenioAp.TabIndex = 55;
            this.btnConvenioAp.Text = "Apostilamento";
            this.btnConvenioAp.UseVisualStyleBackColor = true;
            this.btnConvenioAp.Click += new System.EventHandler(this.btnConvenioAp_Click);
            // 
            // btnConvenioPro
            // 
            this.btnConvenioPro.Location = new System.Drawing.Point(310, 95);
            this.btnConvenioPro.Name = "btnConvenioPro";
            this.btnConvenioPro.Size = new System.Drawing.Size(75, 23);
            this.btnConvenioPro.TabIndex = 56;
            this.btnConvenioPro.Text = "Prorrogação";
            this.btnConvenioPro.UseVisualStyleBackColor = true;
            this.btnConvenioPro.Click += new System.EventHandler(this.btnConvenioPro_Click);
            // 
            // btnPrestacaoConta
            // 
            this.btnPrestacaoConta.Location = new System.Drawing.Point(310, 126);
            this.btnPrestacaoConta.Name = "btnPrestacaoConta";
            this.btnPrestacaoConta.Size = new System.Drawing.Size(75, 23);
            this.btnPrestacaoConta.TabIndex = 57;
            this.btnPrestacaoConta.Text = "Pre. contas";
            this.btnPrestacaoConta.UseVisualStyleBackColor = true;
            this.btnPrestacaoConta.Click += new System.EventHandler(this.btnPrestacaoConta_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(423, 64);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 58;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnParceria
            // 
            this.btnParceria.Location = new System.Drawing.Point(423, 95);
            this.btnParceria.Name = "btnParceria";
            this.btnParceria.Size = new System.Drawing.Size(75, 23);
            this.btnParceria.TabIndex = 59;
            this.btnParceria.Text = "Parceria";
            this.btnParceria.UseVisualStyleBackColor = true;
            this.btnParceria.Click += new System.EventHandler(this.btnParceria_Click);
            // 
            // btnUnidade
            // 
            this.btnUnidade.Location = new System.Drawing.Point(423, 126);
            this.btnUnidade.Name = "btnUnidade";
            this.btnUnidade.Size = new System.Drawing.Size(75, 23);
            this.btnUnidade.TabIndex = 60;
            this.btnUnidade.Text = "Unidade";
            this.btnUnidade.UseVisualStyleBackColor = true;
            this.btnUnidade.Click += new System.EventHandler(this.btnUnidade_Click);
            // 
            // frmPubconApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 403);
            this.Controls.Add(this.btnUnidade);
            this.Controls.Add(this.btnParceria);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnPrestacaoConta);
            this.Controls.Add(this.btnConvenioPro);
            this.Controls.Add(this.btnConvenioAp);
            this.Controls.Add(this.btnConvenioAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edtChave);
            this.Controls.Add(this.btnConvenio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtUsuario);
            this.Controls.Add(this.edtParceria);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtNumero);
            this.Controls.Add(this.edtAno);
            this.Name = "frmPubconApi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pubcon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtUsuario;
        private System.Windows.Forms.TextBox edtParceria;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNumero;
        private System.Windows.Forms.TextBox edtAno;
        private System.Windows.Forms.Button btnConvenio;
        private System.Windows.Forms.TextBox edtChave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConvenioAd;
        private System.Windows.Forms.Button btnConvenioAp;
        private System.Windows.Forms.Button btnConvenioPro;
        private System.Windows.Forms.Button btnPrestacaoConta;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnParceria;
        private System.Windows.Forms.Button btnUnidade;
    }
}

