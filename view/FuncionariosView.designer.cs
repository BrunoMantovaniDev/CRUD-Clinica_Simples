namespace Clinica.View
{
    partial class FuncionariosView
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
            this.EditarFuncionario = new System.Windows.Forms.Button();
            this.NovoFuncionario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.codf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DeletarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // EditarFuncionario
            // 
            this.EditarFuncionario.Location = new System.Drawing.Point(110, 357);
            this.EditarFuncionario.Name = "EditarFuncionario";
            this.EditarFuncionario.Size = new System.Drawing.Size(103, 23);
            this.EditarFuncionario.TabIndex = 9;
            this.EditarFuncionario.Text = "Editar";
            this.EditarFuncionario.UseVisualStyleBackColor = true;
            this.EditarFuncionario.Click += new System.EventHandler(this.EditarConsulta_Click);
            // 
            // NovoFuncionario
            // 
            this.NovoFuncionario.Location = new System.Drawing.Point(609, 357);
            this.NovoFuncionario.Name = "NovoFuncionario";
            this.NovoFuncionario.Size = new System.Drawing.Size(106, 23);
            this.NovoFuncionario.TabIndex = 7;
            this.NovoFuncionario.Text = "Novo";
            this.NovoFuncionario.UseVisualStyleBackColor = true;
            this.NovoFuncionario.Click += new System.EventHandler(this.NovoConsulta_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 13;
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codf,
            this.nome,
            this.idade,
            this.cpf,
            this.cidade,
            this.salario,
            this.cargo});
            this.listagem.Location = new System.Drawing.Point(28, 117);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(794, 184);
            this.listagem.TabIndex = 12;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codf
            // 
            this.codf.HeaderText = "Codigo";
            this.codf.Name = "codf";
            // 
            // nome
            // 
            this.nome.HeaderText = "Noma";
            this.nome.Name = "nome";
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.Name = "idade";
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // salario
            // 
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtrar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeletarConsulta
            // 
            this.DeletarConsulta.Location = new System.Drawing.Point(336, 357);
            this.DeletarConsulta.Name = "DeletarConsulta";
            this.DeletarConsulta.Size = new System.Drawing.Size(105, 23);
            this.DeletarConsulta.TabIndex = 8;
            this.DeletarConsulta.Text = "Deletar";
            this.DeletarConsulta.UseVisualStyleBackColor = true;
            this.DeletarConsulta.Click += new System.EventHandler(this.DeletarConsulta_Click);
            // 
            // FuncionariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditarFuncionario);
            this.Controls.Add(this.DeletarConsulta);
            this.Controls.Add(this.NovoFuncionario);
            this.Name = "FuncionariosView";
            this.Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditarFuncionario;
        private System.Windows.Forms.Button NovoFuncionario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.Button DeletarConsulta;
    }
}