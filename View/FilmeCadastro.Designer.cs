namespace View
{
    partial class FilmeCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCurtiu = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.ckbTemSequencia = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(91, 28);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.lblCategoria.Location = new System.Drawing.Point(12, 63);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(164, 28);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblCurtiu
            // 
            this.lblCurtiu.AutoSize = true;
            this.lblCurtiu.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.lblCurtiu.Location = new System.Drawing.Point(12, 117);
            this.lblCurtiu.Name = "lblCurtiu";
            this.lblCurtiu.Size = new System.Drawing.Size(114, 28);
            this.lblCurtiu.TabIndex = 4;
            this.lblCurtiu.Text = "Curtiu";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.rbSim.Location = new System.Drawing.Point(17, 148);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(76, 30);
            this.rbSim.TabIndex = 5;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.rbNao.Location = new System.Drawing.Point(160, 148);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(86, 30);
            this.rbNao.TabIndex = 6;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.lblDuracao.Location = new System.Drawing.Point(12, 181);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(142, 28);
            this.lblDuracao.TabIndex = 7;
            this.lblDuracao.Text = "Duração";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(17, 212);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(229, 20);
            this.txtDuracao.TabIndex = 8;
            // 
            // ckbTemSequencia
            // 
            this.ckbTemSequencia.AutoSize = true;
            this.ckbTemSequencia.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.ckbTemSequencia.Location = new System.Drawing.Point(17, 293);
            this.ckbTemSequencia.Name = "ckbTemSequencia";
            this.ckbTemSequencia.Size = new System.Drawing.Size(233, 30);
            this.ckbTemSequencia.TabIndex = 9;
            this.ckbTemSequencia.Text = "Tem Sequencia";
            this.ckbTemSequencia.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.btnSalvar.Location = new System.Drawing.Point(42, 329);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(165, 68);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F);
            this.lblAvaliacao.Location = new System.Drawing.Point(16, 235);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(160, 28);
            this.lblAvaliacao.TabIndex = 11;
            this.lblAvaliacao.Text = "Avaliação";
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Location = new System.Drawing.Point(17, 266);
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(229, 20);
            this.txtAvaliacao.TabIndex = 12;
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
            this.cbCategoria.Location = new System.Drawing.Point(21, 95);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(225, 21);
            this.cbCategoria.TabIndex = 13;
            // 
            // FilmeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 409);
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
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FilmeCadastro";
            this.Text = "FilmeCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCurtiu;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.CheckBox ckbTemSequencia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.TextBox txtAvaliacao;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}