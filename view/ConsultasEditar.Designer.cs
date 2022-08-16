namespace Clinica.View
{
    partial class ConsultasEditar
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
            this.button3 = new System.Windows.Forms.Button();
            this.titulo_label = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientes_combo = new System.Windows.Forms.ComboBox();
            this.medicos_combo = new System.Windows.Forms.ComboBox();
            this.dataHoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 66;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(240, 94);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(157, 24);
            this.titulo_label.TabIndex = 64;
            this.titulo_label.Text = "Editar Consulta:";
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(275, 298);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(90, 28);
            this.salvar.TabIndex = 72;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Medico";
            // 
            // pacientes_combo
            // 
            this.pacientes_combo.FormattingEnabled = true;
            this.pacientes_combo.Location = new System.Drawing.Point(198, 198);
            this.pacientes_combo.Name = "pacientes_combo";
            this.pacientes_combo.Size = new System.Drawing.Size(263, 21);
            this.pacientes_combo.TabIndex = 69;
            // 
            // medicos_combo
            // 
            this.medicos_combo.FormattingEnabled = true;
            this.medicos_combo.Location = new System.Drawing.Point(198, 153);
            this.medicos_combo.Name = "medicos_combo";
            this.medicos_combo.Size = new System.Drawing.Size(263, 21);
            this.medicos_combo.TabIndex = 68;
            // 
            // dataHoraConsulta
            // 
            this.dataHoraConsulta.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dataHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataHoraConsulta.Location = new System.Drawing.Point(198, 239);
            this.dataHoraConsulta.Name = "dataHoraConsulta";
            this.dataHoraConsulta.Size = new System.Drawing.Size(263, 20);
            this.dataHoraConsulta.TabIndex = 67;
            this.dataHoraConsulta.ValueChanged += new System.EventHandler(this.dataHoraConsulta_ValueChanged);
            // 
            // ConsultasEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 429);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pacientes_combo);
            this.Controls.Add(this.medicos_combo);
            this.Controls.Add(this.dataHoraConsulta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.titulo_label);
            this.Name = "ConsultasEditar";
            this.Text = "ConsultasEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pacientes_combo;
        private System.Windows.Forms.ComboBox medicos_combo;
        private System.Windows.Forms.DateTimePicker dataHoraConsulta;
    }
}