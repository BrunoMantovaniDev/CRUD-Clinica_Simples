namespace Clinica.View
{
    partial class FuncionarioEditar
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
            this.VoltarFunc = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
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
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VoltarFunc
            // 
            this.VoltarFunc.Location = new System.Drawing.Point(9, 8);
            this.VoltarFunc.Name = "VoltarFunc";
            this.VoltarFunc.Size = new System.Drawing.Size(75, 23);
            this.VoltarFunc.TabIndex = 43;
            this.VoltarFunc.Text = "Voltar";
            this.VoltarFunc.UseVisualStyleBackColor = true;
            this.VoltarFunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(304, 425);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(133, 28);
            this.salvar.TabIndex = 42;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(282, 51);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(188, 24);
            this.titulo_label.TabIndex = 41;
            this.titulo_label.Text = "Editar Funcionario:";
            // 
            // cargoValor
            // 
            this.cargoValor.Location = new System.Drawing.Point(264, 363);
            this.cargoValor.Name = "cargoValor";
            this.cargoValor.Size = new System.Drawing.Size(223, 20);
            this.cargoValor.TabIndex = 40;
            // 
            // doenca_label
            // 
            this.doenca_label.AutoSize = true;
            this.doenca_label.Location = new System.Drawing.Point(185, 363);
            this.doenca_label.Name = "doenca_label";
            this.doenca_label.Size = new System.Drawing.Size(38, 13);
            this.doenca_label.TabIndex = 39;
            this.doenca_label.Text = "Cargo:";
            this.doenca_label.Click += new System.EventHandler(this.doenca_label_Click);
            // 
            // salarioValor
            // 
            this.salarioValor.Location = new System.Drawing.Point(264, 323);
            this.salarioValor.Name = "salarioValor";
            this.salarioValor.Size = new System.Drawing.Size(223, 20);
            this.salarioValor.TabIndex = 38;
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(185, 326);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(42, 13);
            this.cpf_label.TabIndex = 37;
            this.cpf_label.Text = "Salario:";
            // 
            // cidadeValor
            // 
            this.cidadeValor.Location = new System.Drawing.Point(264, 283);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(223, 20);
            this.cidadeValor.TabIndex = 36;
            this.cidadeValor.TextChanged += new System.EventHandler(this.cidadeValor_TextChanged);
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Location = new System.Drawing.Point(185, 286);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(43, 13);
            this.cidade_label.TabIndex = 35;
            this.cidade_label.Text = "Cidade:";
            // 
            // cpfValor
            // 
            this.cpfValor.Location = new System.Drawing.Point(264, 239);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(223, 20);
            this.cpfValor.TabIndex = 34;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(185, 242);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(30, 13);
            this.idade_label.TabIndex = 33;
            this.idade_label.Text = "CPF:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(264, 153);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 32;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(185, 156);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 31;
            this.nome_label.Text = "Nome:";
            // 
            // codigoValor
            // 
            this.codigoValor.Location = new System.Drawing.Point(264, 108);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(223, 20);
            this.codigoValor.TabIndex = 30;
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(185, 115);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 29;
            this.codigo_label.Text = "Codigo:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(264, 195);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 20);
            this.idadeValor.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Idade:";
            // 
            // FuncionarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.VoltarFunc);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.cargoValor);
            this.Controls.Add(this.doenca_label);
            this.Controls.Add(this.salarioValor);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigo_label);
            this.Name = "FuncionarioEditar";
            this.Text = "FuncionarioEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VoltarFunc;
        private System.Windows.Forms.Button salvar;
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
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label label1;
    }
}