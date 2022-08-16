namespace Clinica.View
{
    partial class FuncionarioCriar
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
            this.salvarfuncionario = new System.Windows.Forms.Button();
            this.titulo_label = new System.Windows.Forms.Label();
            this.cargoValor = new System.Windows.Forms.TextBox();
            this.doenca_label = new System.Windows.Forms.Label();
            this.salarioValor = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salvarfuncionario
            // 
            this.salvarfuncionario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salvarfuncionario.FlatAppearance.BorderSize = 0;
            this.salvarfuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarfuncionario.Location = new System.Drawing.Point(298, 388);
            this.salvarfuncionario.Name = "salvarfuncionario";
            this.salvarfuncionario.Size = new System.Drawing.Size(151, 34);
            this.salvarfuncionario.TabIndex = 27;
            this.salvarfuncionario.Text = "Salvar";
            this.salvarfuncionario.UseVisualStyleBackColor = false;
            this.salvarfuncionario.Click += new System.EventHandler(this.salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(263, 51);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(230, 24);
            this.titulo_label.TabIndex = 26;
            this.titulo_label.Text = "Criar novo Funcionario:";
            // 
            // cargoValor
            // 
            this.cargoValor.Location = new System.Drawing.Point(267, 323);
            this.cargoValor.Name = "cargoValor";
            this.cargoValor.Size = new System.Drawing.Size(223, 20);
            this.cargoValor.TabIndex = 25;
            // 
            // doenca_label
            // 
            this.doenca_label.AutoSize = true;
            this.doenca_label.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doenca_label.Location = new System.Drawing.Point(195, 326);
            this.doenca_label.Name = "doenca_label";
            this.doenca_label.Size = new System.Drawing.Size(38, 13);
            this.doenca_label.TabIndex = 24;
            this.doenca_label.Text = "Cargo:";
            // 
            // salarioValor
            // 
            this.salarioValor.Location = new System.Drawing.Point(267, 281);
            this.salarioValor.Name = "salarioValor";
            this.salarioValor.Size = new System.Drawing.Size(223, 20);
            this.salarioValor.TabIndex = 23;
            this.salarioValor.TextChanged += new System.EventHandler(this.cpfValor_TextChanged);
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cpf_label.Location = new System.Drawing.Point(195, 284);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(42, 13);
            this.cpf_label.TabIndex = 22;
            this.cpf_label.Text = "Salario:";
            // 
            // cidadeValor
            // 
            this.cidadeValor.Location = new System.Drawing.Point(267, 243);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(223, 20);
            this.cidadeValor.TabIndex = 21;
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cidade_label.Location = new System.Drawing.Point(195, 246);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(43, 13);
            this.cidade_label.TabIndex = 20;
            this.cidade_label.Text = "Cidade:";
            // 
            // cpfValor
            // 
            this.cpfValor.Location = new System.Drawing.Point(267, 202);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(223, 20);
            this.cpfValor.TabIndex = 19;
            this.cpfValor.TextChanged += new System.EventHandler(this.idadeValor_TextChanged);
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.idade_label.Location = new System.Drawing.Point(195, 202);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(30, 13);
            this.idade_label.TabIndex = 18;
            this.idade_label.Text = "CPF:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(140, 34);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 17;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(67, 37);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 16;
            this.nome_label.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(267, 163);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 20);
            this.idadeValor.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(195, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Idade:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.nomeValor);
            this.panel1.Controls.Add(this.nome_label);
            this.panel1.Location = new System.Drawing.Point(127, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 367);
            this.panel1.TabIndex = 31;
            // 
            // FuncionarioCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salvarfuncionario);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.cargoValor);
            this.Controls.Add(this.doenca_label);
            this.Controls.Add(this.salarioValor);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.panel1);
            this.Name = "FuncionarioCriar";
            this.Text = "FuncionarioCriar";
            this.Load += new System.EventHandler(this.FuncionarioCriar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvarfuncionario;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox cargoValor;
        private System.Windows.Forms.Label doenca_label;
        private System.Windows.Forms.TextBox salarioValor;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}