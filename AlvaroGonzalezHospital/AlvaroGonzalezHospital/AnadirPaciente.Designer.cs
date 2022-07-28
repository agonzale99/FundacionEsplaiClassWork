
namespace AlvaroGonzalezHospital
{
    partial class AnadirPaciente
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
            this.nombrePacienteAdd = new System.Windows.Forms.TextBox();
            this.nombrePacienteIntro = new System.Windows.Forms.Label();
            this.apellidoPAcienteAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dolorPacienteAdd = new System.Windows.Forms.TextBox();
            this.cancelAddPAciente = new System.Windows.Forms.Button();
            this.submitAddPaciente = new System.Windows.Forms.Button();
            this.MedicoAsociado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nombrePacienteAdd
            // 
            this.nombrePacienteAdd.Location = new System.Drawing.Point(38, 63);
            this.nombrePacienteAdd.Name = "nombrePacienteAdd";
            this.nombrePacienteAdd.Size = new System.Drawing.Size(100, 22);
            this.nombrePacienteAdd.TabIndex = 0;
            // 
            // nombrePacienteIntro
            // 
            this.nombrePacienteIntro.AutoSize = true;
            this.nombrePacienteIntro.Location = new System.Drawing.Point(38, 40);
            this.nombrePacienteIntro.Name = "nombrePacienteIntro";
            this.nombrePacienteIntro.Size = new System.Drawing.Size(58, 17);
            this.nombrePacienteIntro.TabIndex = 1;
            this.nombrePacienteIntro.Text = "Nombre";
            // 
            // apellidoPAcienteAdd
            // 
            this.apellidoPAcienteAdd.Location = new System.Drawing.Point(159, 62);
            this.apellidoPAcienteAdd.Name = "apellidoPAcienteAdd";
            this.apellidoPAcienteAdd.Size = new System.Drawing.Size(100, 22);
            this.apellidoPAcienteAdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dolor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cod. Medico Asociado";
            // 
            // dolorPacienteAdd
            // 
            this.dolorPacienteAdd.Location = new System.Drawing.Point(294, 62);
            this.dolorPacienteAdd.Name = "dolorPacienteAdd";
            this.dolorPacienteAdd.Size = new System.Drawing.Size(148, 22);
            this.dolorPacienteAdd.TabIndex = 6;
            // 
            // cancelAddPAciente
            // 
            this.cancelAddPAciente.Location = new System.Drawing.Point(138, 118);
            this.cancelAddPAciente.Name = "cancelAddPAciente";
            this.cancelAddPAciente.Size = new System.Drawing.Size(75, 23);
            this.cancelAddPAciente.TabIndex = 8;
            this.cancelAddPAciente.Text = "Cancel";
            this.cancelAddPAciente.UseVisualStyleBackColor = true;
            this.cancelAddPAciente.Click += new System.EventHandler(this.cancelAddPAciente_Click);
            // 
            // submitAddPaciente
            // 
            this.submitAddPaciente.Location = new System.Drawing.Point(275, 118);
            this.submitAddPaciente.Name = "submitAddPaciente";
            this.submitAddPaciente.Size = new System.Drawing.Size(75, 23);
            this.submitAddPaciente.TabIndex = 9;
            this.submitAddPaciente.Text = "Submit";
            this.submitAddPaciente.UseVisualStyleBackColor = true;
            this.submitAddPaciente.Click += new System.EventHandler(this.submitAddPaciente_Click);
            // 
            // MedicoAsociado
            // 
            this.MedicoAsociado.FormattingEnabled = true;
            this.MedicoAsociado.Location = new System.Drawing.Point(483, 63);
            this.MedicoAsociado.Name = "MedicoAsociado";
            this.MedicoAsociado.Size = new System.Drawing.Size(121, 24);
            this.MedicoAsociado.TabIndex = 10;
            this.MedicoAsociado.Text = "Seleccione uno";
            // 
            // AnadirPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 180);
            this.Controls.Add(this.MedicoAsociado);
            this.Controls.Add(this.submitAddPaciente);
            this.Controls.Add(this.cancelAddPAciente);
            this.Controls.Add(this.dolorPacienteAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apellidoPAcienteAdd);
            this.Controls.Add(this.nombrePacienteIntro);
            this.Controls.Add(this.nombrePacienteAdd);
            this.Name = "AnadirPaciente";
            this.Text = "AnadirPaciente";
            this.Load += new System.EventHandler(this.AnadirPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombrePacienteAdd;
        private System.Windows.Forms.Label nombrePacienteIntro;
        private System.Windows.Forms.TextBox apellidoPAcienteAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dolorPacienteAdd;
        private System.Windows.Forms.Button cancelAddPAciente;
        private System.Windows.Forms.Button submitAddPaciente;
        private System.Windows.Forms.ComboBox MedicoAsociado;
    }
}