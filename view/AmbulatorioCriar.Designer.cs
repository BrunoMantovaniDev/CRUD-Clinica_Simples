namespace Clinica.View
{
    partial class AmbulatorioCriar
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
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(232, 293);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(102, 23);
            this.salvar.TabIndex = 28;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(152, 61);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(274, 24);
            this.titulo_label.TabIndex = 27;
            this.titulo_label.Text = "Cadastrar novo Ambulatorio:";
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(180, 215);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 20);
            this.idadeValor.TabIndex = 20;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(101, 222);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(67, 13);
            this.idade_label.TabIndex = 19;
            this.idade_label.Text = "Capacidade:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(180, 171);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 18;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(101, 178);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 17;
            this.nome_label.Text = "Andar:";
            // 
            // codigoValor
            // 
            this.codigoValor.Location = new System.Drawing.Point(180, 126);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(223, 20);
            this.codigoValor.TabIndex = 16;
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(101, 133);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 15;
            this.codigo_label.Text = "Codigo:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AmbulatorioCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 397);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigo_label);
            this.Name = "AmbulatorioCriar";
            this.Text = "AmbulatorioCriar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigo_label;
    }
}