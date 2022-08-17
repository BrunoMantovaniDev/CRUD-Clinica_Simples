namespace Clinica.View
{
    partial class DependenteView
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
            this.EditarConsulta = new System.Windows.Forms.Button();
            this.DeletarConsulta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.codd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.NovoConsulta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // EditarConsulta
            // 
            this.EditarConsulta.Location = new System.Drawing.Point(142, 337);
            this.EditarConsulta.Name = "EditarConsulta";
            this.EditarConsulta.Size = new System.Drawing.Size(75, 23);
            this.EditarConsulta.TabIndex = 13;
            this.EditarConsulta.Text = "Editar";
            this.EditarConsulta.UseVisualStyleBackColor = true;
            // 
            // DeletarConsulta
            // 
            this.DeletarConsulta.Location = new System.Drawing.Point(322, 337);
            this.DeletarConsulta.Name = "DeletarConsulta";
            this.DeletarConsulta.Size = new System.Drawing.Size(75, 23);
            this.DeletarConsulta.TabIndex = 12;
            this.DeletarConsulta.Text = "Deletar";
            this.DeletarConsulta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 11;
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codd,
            this.nome,
            this.nascimento,
            this.Funcionario,
            this.codf});
            this.listagem.Location = new System.Drawing.Point(30, 101);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(751, 184);
            this.listagem.TabIndex = 10;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codd
            // 
            this.codd.HeaderText = "Codigo";
            this.codd.Name = "codd";
            this.codd.Width = 150;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // nascimento
            // 
            this.nascimento.HeaderText = "Nascimento";
            this.nascimento.Name = "nascimento";
            this.nascimento.Width = 150;
            // 
            // Funcionario
            // 
            this.Funcionario.HeaderText = "Funcionario";
            this.Funcionario.Name = "Funcionario";
            // 
            // codf
            // 
            this.codf.HeaderText = "Codigo Funcionario";
            this.codf.Name = "codf";
            this.codf.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrar:";
            // 
            // NovoConsulta
            // 
            this.NovoConsulta.Location = new System.Drawing.Point(482, 337);
            this.NovoConsulta.Name = "NovoConsulta";
            this.NovoConsulta.Size = new System.Drawing.Size(75, 23);
            this.NovoConsulta.TabIndex = 8;
            this.NovoConsulta.Text = "Novo";
            this.NovoConsulta.UseVisualStyleBackColor = true;
            this.NovoConsulta.Click += new System.EventHandler(this.NovoConsulta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DependenteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 421);
            this.Controls.Add(this.EditarConsulta);
            this.Controls.Add(this.DeletarConsulta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NovoConsulta);
            this.Controls.Add(this.button1);
            this.Name = "DependenteView";
            this.Text = "Dependente";
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditarConsulta;
        private System.Windows.Forms.Button DeletarConsulta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NovoConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codf;
    }
}