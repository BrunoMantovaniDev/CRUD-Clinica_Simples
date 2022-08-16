namespace Clinica.View
{
    partial class ConsultasView
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
            this.button1 = new System.Windows.Forms.Button();
            this.NovoConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeletarConsulta = new System.Windows.Forms.Button();
            this.EditarConsulta = new System.Windows.Forms.Button();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NovoConsulta
            // 
            this.NovoConsulta.Location = new System.Drawing.Point(436, 348);
            this.NovoConsulta.Name = "NovoConsulta";
            this.NovoConsulta.Size = new System.Drawing.Size(75, 23);
            this.NovoConsulta.TabIndex = 1;
            this.NovoConsulta.Text = "Novo";
            this.NovoConsulta.UseVisualStyleBackColor = true;
            this.NovoConsulta.Click += new System.EventHandler(this.NovoConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar:";
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medico,
            this.Paciente,
            this.dataHora,
            this.codm,
            this.codp});
            this.listagem.Location = new System.Drawing.Point(58, 123);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(515, 184);
            this.listagem.TabIndex = 3;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DeletarConsulta
            // 
            this.DeletarConsulta.Location = new System.Drawing.Point(292, 348);
            this.DeletarConsulta.Name = "DeletarConsulta";
            this.DeletarConsulta.Size = new System.Drawing.Size(75, 23);
            this.DeletarConsulta.TabIndex = 5;
            this.DeletarConsulta.Text = "Deletar";
            this.DeletarConsulta.UseVisualStyleBackColor = true;
            this.DeletarConsulta.Click += new System.EventHandler(this.DeletarConsulta_Click);
            // 
            // EditarConsulta
            // 
            this.EditarConsulta.Location = new System.Drawing.Point(126, 348);
            this.EditarConsulta.Name = "EditarConsulta";
            this.EditarConsulta.Size = new System.Drawing.Size(75, 23);
            this.EditarConsulta.TabIndex = 6;
            this.EditarConsulta.Text = "Editar";
            this.EditarConsulta.UseVisualStyleBackColor = true;
            this.EditarConsulta.Click += new System.EventHandler(this.EditarConsulta_Click);
            // 
            // Medico
            // 
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            this.Medico.Width = 150;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.Width = 150;
            // 
            // dataHora
            // 
            this.dataHora.HeaderText = "Data / Hora";
            this.dataHora.Name = "dataHora";
            this.dataHora.Width = 150;
            // 
            // codm
            // 
            this.codm.HeaderText = "codm";
            this.codm.Name = "codm";
            this.codm.Visible = false;
            // 
            // codp
            // 
            this.codp.HeaderText = "codp";
            this.codp.Name = "codp";
            this.codp.Visible = false;
            // 
            // ConsultasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 417);
            this.Controls.Add(this.EditarConsulta);
            this.Controls.Add(this.DeletarConsulta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NovoConsulta);
            this.Controls.Add(this.button1);
            this.Name = "ConsultasView";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.ConsultasView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NovoConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeletarConsulta;
        private System.Windows.Forms.Button EditarConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn codm;
        private System.Windows.Forms.DataGridViewTextBoxColumn codp;
    }
}