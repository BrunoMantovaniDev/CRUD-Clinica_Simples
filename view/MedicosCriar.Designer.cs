namespace Clinica.View
{
    partial class MedicosCriar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicosCriar));
            this.voltarMedico = new System.Windows.Forms.Button();
            this.titulo_label = new System.Windows.Forms.Label();
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.especialidadeValor = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.especalidade_label = new System.Windows.Forms.Label();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ambulatorioValor = new System.Windows.Forms.TextBox();
            this.SalvarMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voltarMedico
            // 
            this.voltarMedico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltarMedico.BackgroundImage")));
            this.voltarMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.voltarMedico.FlatAppearance.BorderSize = 0;
            this.voltarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarMedico.Location = new System.Drawing.Point(12, 12);
            this.voltarMedico.Name = "voltarMedico";
            this.voltarMedico.Size = new System.Drawing.Size(68, 39);
            this.voltarMedico.TabIndex = 0;
            this.voltarMedico.UseVisualStyleBackColor = true;
            this.voltarMedico.Click += new System.EventHandler(this.button1_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(175, 76);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(234, 24);
            this.titulo_label.TabIndex = 25;
            this.titulo_label.Text = "Cadastrar Novo Medico:";
            this.titulo_label.Click += new System.EventHandler(this.titulo_label_Click);
            // 
            // cidadeValor
            // 
            this.cidadeValor.Location = new System.Drawing.Point(186, 357);
            this.cidadeValor.Multiline = true;
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(223, 25);
            this.cidadeValor.TabIndex = 16;
            this.cidadeValor.TextChanged += new System.EventHandler(this.doencaValor_TextChanged);
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Location = new System.Drawing.Point(92, 360);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(43, 13);
            this.cidade_label.TabIndex = 23;
            this.cidade_label.Text = "Cidade:";
            this.cidade_label.Click += new System.EventHandler(this.doenca_label_Click);
            // 
            // especialidadeValor
            // 
            this.especialidadeValor.Location = new System.Drawing.Point(186, 311);
            this.especialidadeValor.Multiline = true;
            this.especialidadeValor.Name = "especialidadeValor";
            this.especialidadeValor.Size = new System.Drawing.Size(223, 25);
            this.especialidadeValor.TabIndex = 16;
            this.especialidadeValor.TextChanged += new System.EventHandler(this.cpfValor_TextChanged);
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(92, 275);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(30, 13);
            this.cpf_label.TabIndex = 21;
            this.cpf_label.Text = "CPF:";
            this.cpf_label.Click += new System.EventHandler(this.cpf_label_Click);
            // 
            // cpfValor
            // 
            this.cpfValor.Location = new System.Drawing.Point(186, 272);
            this.cpfValor.Multiline = true;
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(223, 25);
            this.cpfValor.TabIndex = 16;
            this.cpfValor.TextChanged += new System.EventHandler(this.cidadeValor_TextChanged);
            // 
            // especalidade_label
            // 
            this.especalidade_label.AutoSize = true;
            this.especalidade_label.Location = new System.Drawing.Point(92, 314);
            this.especalidade_label.Name = "especalidade_label";
            this.especalidade_label.Size = new System.Drawing.Size(76, 13);
            this.especalidade_label.TabIndex = 19;
            this.especalidade_label.Text = "Especialidade:";
            this.especalidade_label.Click += new System.EventHandler(this.cidade_label_Click);
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(186, 230);
            this.idadeValor.Multiline = true;
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 25);
            this.idadeValor.TabIndex = 16;
            this.idadeValor.TextChanged += new System.EventHandler(this.idadeValor_TextChanged);
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(92, 233);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(37, 13);
            this.idade_label.TabIndex = 17;
            this.idade_label.Text = "Idade:";
            this.idade_label.Click += new System.EventHandler(this.idade_label_Click);
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(186, 186);
            this.nomeValor.Multiline = true;
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 25);
            this.nomeValor.TabIndex = 16;
            this.nomeValor.TextChanged += new System.EventHandler(this.nomeValor_TextChanged);
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(92, 189);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 15;
            this.nome_label.Text = "Nome:";
            this.nome_label.Click += new System.EventHandler(this.nome_label_Click);
            // 
            // codigoValor
            // 
            this.codigoValor.Location = new System.Drawing.Point(186, 141);
            this.codigoValor.Multiline = true;
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(223, 25);
            this.codigoValor.TabIndex = 14;
            this.codigoValor.TextChanged += new System.EventHandler(this.codigoValor_TextChanged);
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(92, 144);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 13;
            this.codigo_label.Text = "Codigo:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.codigo_label.Click += new System.EventHandler(this.codigo_label_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ambulatorio:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ambulatorioValor
            // 
            this.ambulatorioValor.Location = new System.Drawing.Point(186, 396);
            this.ambulatorioValor.Multiline = true;
            this.ambulatorioValor.Name = "ambulatorioValor";
            this.ambulatorioValor.Size = new System.Drawing.Size(223, 25);
            this.ambulatorioValor.TabIndex = 16;
            // 
            // SalvarMedico
            // 
            this.SalvarMedico.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SalvarMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvarMedico.Location = new System.Drawing.Point(204, 474);
            this.SalvarMedico.Name = "SalvarMedico";
            this.SalvarMedico.Size = new System.Drawing.Size(188, 24);
            this.SalvarMedico.TabIndex = 40;
            this.SalvarMedico.Text = "Salvar";
            this.SalvarMedico.UseVisualStyleBackColor = false;
            this.SalvarMedico.Click += new System.EventHandler(this.SalvarMedico_Click);
            // 
            // MedicosCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 543);
            this.Controls.Add(this.SalvarMedico);
            this.Controls.Add(this.ambulatorioValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.especialidadeValor);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.especalidade_label);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigo_label);
            this.Controls.Add(this.voltarMedico);
            this.Name = "MedicosCriar";
            this.Text = "MedicosCriar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltarMedico;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.TextBox especialidadeValor;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.Label especalidade_label;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ambulatorioValor;
        private System.Windows.Forms.Button SalvarMedico;
    }
}