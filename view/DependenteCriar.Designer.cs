namespace Clinica.View
{
    partial class DependenteCriar
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
            this.salvar = new System.Windows.Forms.Button();
            this.titulo_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.dataHoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.funcionario_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(345, 325);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(110, 32);
            this.salvar.TabIndex = 68;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(293, 73);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(277, 24);
            this.titulo_label.TabIndex = 67;
            this.titulo_label.Text = "Cadastrar novo Dependente:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(147, 208);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 62;
            this.nomeValor.TextChanged += new System.EventHandler(this.nomeValor_TextChanged);
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(64, 211);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 61;
            this.nome_label.Text = "Nome:";
            // 
            // codigoValor
            // 
            this.codigoValor.Location = new System.Drawing.Point(147, 163);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(223, 20);
            this.codigoValor.TabIndex = 60;
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(64, 166);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 59;
            this.codigo_label.Text = "Codigo:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataHoraConsulta
            // 
            this.dataHoraConsulta.CustomFormat = "dd-MM-yyyy ";
            this.dataHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataHoraConsulta.Location = new System.Drawing.Point(147, 253);
            this.dataHoraConsulta.Name = "dataHoraConsulta";
            this.dataHoraConsulta.Size = new System.Drawing.Size(223, 20);
            this.dataHoraConsulta.TabIndex = 70;
            this.dataHoraConsulta.ValueChanged += new System.EventHandler(this.dataHoraConsulta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Nascimento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // funcionario_combo
            // 
            this.funcionario_combo.FormattingEnabled = true;
            this.funcionario_combo.Location = new System.Drawing.Point(501, 162);
            this.funcionario_combo.Name = "funcionario_combo";
            this.funcionario_combo.Size = new System.Drawing.Size(239, 21);
            this.funcionario_combo.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Funcionario Titular:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DependenteCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.funcionario_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataHoraConsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigo_label);
            this.Name = "DependenteCriar";
            this.Text = "DependenteCriar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.DateTimePicker dataHoraConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox funcionario_combo;
        private System.Windows.Forms.Label label2;
    }
}