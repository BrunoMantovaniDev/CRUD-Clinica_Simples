namespace Clinica.View
{
    partial class AmbulatorioEditar
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
            this.button5 = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.titulo_label = new System.Windows.Forms.Label();
            this.capacidadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.andarValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.nroaValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(234, 291);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(102, 23);
            this.salvar.TabIndex = 37;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(202, 64);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(188, 24);
            this.titulo_label.TabIndex = 36;
            this.titulo_label.Text = "Editar Ambulatorio:";
            // 
            // capacidadeValor
            // 
            this.capacidadeValor.Location = new System.Drawing.Point(182, 213);
            this.capacidadeValor.Name = "capacidadeValor";
            this.capacidadeValor.Size = new System.Drawing.Size(223, 20);
            this.capacidadeValor.TabIndex = 35;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(103, 220);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(67, 13);
            this.idade_label.TabIndex = 34;
            this.idade_label.Text = "Capacidade:";
            // 
            // andarValor
            // 
            this.andarValor.Location = new System.Drawing.Point(182, 169);
            this.andarValor.Name = "andarValor";
            this.andarValor.Size = new System.Drawing.Size(223, 20);
            this.andarValor.TabIndex = 33;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(103, 176);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 32;
            this.nome_label.Text = "Andar:";
            // 
            // nroaValor
            // 
            this.nroaValor.Location = new System.Drawing.Point(182, 124);
            this.nroaValor.Name = "nroaValor";
            this.nroaValor.Size = new System.Drawing.Size(223, 20);
            this.nroaValor.TabIndex = 31;
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(103, 131);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 30;
            this.codigo_label.Text = "Codigo:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AmbulatorioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 397);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.capacidadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.andarValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.nroaValor);
            this.Controls.Add(this.codigo_label);
            this.Name = "AmbulatorioEditar";
            this.Text = "AmbulatorioEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox capacidadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox andarValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox nroaValor;
        private System.Windows.Forms.Label codigo_label;
    }
}