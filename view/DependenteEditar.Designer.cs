namespace Clinica.View
{
    partial class DependenteEditar
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
            this.titulo_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.funcionario_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDependente = new System.Windows.Forms.DateTimePicker();
            this.salvar = new System.Windows.Forms.Button();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(318, 46);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(191, 24);
            this.titulo_label.TabIndex = 56;
            this.titulo_label.Text = "Editar Dependente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Funcionario Titular:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // funcionario_combo
            // 
            this.funcionario_combo.FormattingEnabled = true;
            this.funcionario_combo.Location = new System.Drawing.Point(503, 151);
            this.funcionario_combo.Name = "funcionario_combo";
            this.funcionario_combo.Size = new System.Drawing.Size(239, 21);
            this.funcionario_combo.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Nascimento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataDependente
            // 
            this.dataDependente.CustomFormat = "dd-MM-yyyy ";
            this.dataDependente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDependente.Location = new System.Drawing.Point(157, 197);
            this.dataDependente.Name = "dataDependente";
            this.dataDependente.Size = new System.Drawing.Size(223, 20);
            this.dataDependente.TabIndex = 79;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(349, 284);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(110, 32);
            this.salvar.TabIndex = 78;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(157, 152);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 77;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(74, 155);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 76;
            this.nome_label.Text = "Nome:";
            // 
            // DependenteEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.funcionario_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDependente);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titulo_label);
            this.Name = "DependenteEditar";
            this.Text = "DependenteEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox funcionario_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataDependente;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
    }
}