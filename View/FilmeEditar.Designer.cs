namespace View
{
    partial class FilmeEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ckbTemSequencia = new System.Windows.Forms.CheckBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.lblCurtiu = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Ação",
            "Infantil",
            "Bipolaridade",
            "Drama"});
            this.cbCategoria.Location = new System.Drawing.Point(21, 140);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(225, 21);
            this.cbCategoria.TabIndex = 26;
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Location = new System.Drawing.Point(17, 311);
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(229, 20);
            this.txtAvaliacao.TabIndex = 25;
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.lblAvaliacao.Location = new System.Drawing.Point(16, 280);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(160, 28);
            this.lblAvaliacao.TabIndex = 24;
            this.lblAvaliacao.Text = "Avaliação";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.btnSalvar.Location = new System.Drawing.Point(42, 374);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(165, 68);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ckbTemSequencia
            // 
            this.ckbTemSequencia.AutoSize = true;
            this.ckbTemSequencia.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.ckbTemSequencia.Location = new System.Drawing.Point(17, 338);
            this.ckbTemSequencia.Name = "ckbTemSequencia";
            this.ckbTemSequencia.Size = new System.Drawing.Size(233, 30);
            this.ckbTemSequencia.TabIndex = 22;
            this.ckbTemSequencia.Text = "Tem Sequencia";
            this.ckbTemSequencia.UseVisualStyleBackColor = true;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(17, 257);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(229, 20);
            this.txtDuracao.TabIndex = 21;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.lblDuracao.Location = new System.Drawing.Point(12, 226);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(142, 28);
            this.lblDuracao.TabIndex = 20;
            this.lblDuracao.Text = "Duração";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.rbNao.Location = new System.Drawing.Point(160, 193);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(86, 30);
            this.rbNao.TabIndex = 19;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.rbSim.Location = new System.Drawing.Point(17, 193);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(76, 30);
            this.rbSim.TabIndex = 18;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // lblCurtiu
            // 
            this.lblCurtiu.AutoSize = true;
            this.lblCurtiu.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.lblCurtiu.Location = new System.Drawing.Point(12, 162);
            this.lblCurtiu.Name = "lblCurtiu";
            this.lblCurtiu.Size = new System.Drawing.Size(114, 28);
            this.lblCurtiu.TabIndex = 17;
            this.lblCurtiu.Text = "Curtiu";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.lblCategoria.Location = new System.Drawing.Point(12, 108);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(164, 28);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(18, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(229, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(13, 7);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(118, 28);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 20);
            this.txtNome.TabIndex = 27;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(91, 28);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome";
            // 
            // FilmeEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 452);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtAvaliacao);
            this.Controls.Add(this.lblAvaliacao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ckbTemSequencia);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.lblCurtiu);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FilmeEditar";
            this.Text = "FilmeEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtAvaliacao;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox ckbTemSequencia;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label lblCurtiu;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}