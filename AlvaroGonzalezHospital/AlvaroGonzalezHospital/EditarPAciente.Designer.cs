
namespace AlvaroGonzalezHospital
{
    partial class EditarPAciente
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
            this.MedicoAsociadoEdit = new System.Windows.Forms.ComboBox();
            this.submitEditPaciente = new System.Windows.Forms.Button();
            this.cancelEditPAciente = new System.Windows.Forms.Button();
            this.dolorPacienteEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apellidoPAcienteEdit = new System.Windows.Forms.TextBox();
            this.nombrePacienteIntro = new System.Windows.Forms.Label();
            this.nombrePacienteEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MedicoAsociadoEdit
            // 
            this.MedicoAsociadoEdit.FormattingEnabled = true;
            this.MedicoAsociadoEdit.Location = new System.Drawing.Point(479, 71);
            this.MedicoAsociadoEdit.Name = "MedicoAsociadoEdit";
            this.MedicoAsociadoEdit.Size = new System.Drawing.Size(121, 24);
            this.MedicoAsociadoEdit.TabIndex = 20;
            this.MedicoAsociadoEdit.Text = "Seleccione uno";
            // 
            // submitEditPaciente
            // 
            this.submitEditPaciente.Location = new System.Drawing.Point(271, 126);
            this.submitEditPaciente.Name = "submitEditPaciente";
            this.submitEditPaciente.Size = new System.Drawing.Size(75, 23);
            this.submitEditPaciente.TabIndex = 19;
            this.submitEditPaciente.Text = "Submit";
            this.submitEditPaciente.UseVisualStyleBackColor = true;
            this.submitEditPaciente.Click += new System.EventHandler(this.submitEditPaciente_Click);
            // 
            // cancelEditPAciente
            // 
            this.cancelEditPAciente.Location = new System.Drawing.Point(134, 126);
            this.cancelEditPAciente.Name = "cancelEditPAciente";
            this.cancelEditPAciente.Size = new System.Drawing.Size(75, 23);
            this.cancelEditPAciente.TabIndex = 18;
            this.cancelEditPAciente.Text = "Cancel";
            this.cancelEditPAciente.UseVisualStyleBackColor = true;
            this.cancelEditPAciente.Click += new System.EventHandler(this.cancelEditPAciente_Click);
            // 
            // dolorPacienteEdit
            // 
            this.dolorPacienteEdit.Location = new System.Drawing.Point(290, 70);
            this.dolorPacienteEdit.Name = "dolorPacienteEdit";
            this.dolorPacienteEdit.Size = new System.Drawing.Size(148, 22);
            this.dolorPacienteEdit.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cod. Medico Asociado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dolor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apellido";
            // 
            // apellidoPAcienteEdit
            // 
            this.apellidoPAcienteEdit.Location = new System.Drawing.Point(155, 70);
            this.apellidoPAcienteEdit.Name = "apellidoPAcienteEdit";
            this.apellidoPAcienteEdit.Size = new System.Drawing.Size(100, 22);
            this.apellidoPAcienteEdit.TabIndex = 13;
            // 
            // nombrePacienteIntro
            // 
            this.nombrePacienteIntro.AutoSize = true;
            this.nombrePacienteIntro.Location = new System.Drawing.Point(34, 48);
            this.nombrePacienteIntro.Name = "nombrePacienteIntro";
            this.nombrePacienteIntro.Size = new System.Drawing.Size(58, 17);
            this.nombrePacienteIntro.TabIndex = 12;
            this.nombrePacienteIntro.Text = "Nombre";
            // 
            // nombrePacienteEdit
            // 
            this.nombrePacienteEdit.Location = new System.Drawing.Point(34, 71);
            this.nombrePacienteEdit.Name = "nombrePacienteEdit";
            this.nombrePacienteEdit.Size = new System.Drawing.Size(100, 22);
            this.nombrePacienteEdit.TabIndex = 11;
            // 
            // EditarPAciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 181);
            this.Controls.Add(this.MedicoAsociadoEdit);
            this.Controls.Add(this.submitEditPaciente);
            this.Controls.Add(this.cancelEditPAciente);
            this.Controls.Add(this.dolorPacienteEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apellidoPAcienteEdit);
            this.Controls.Add(this.nombrePacienteIntro);
            this.Controls.Add(this.nombrePacienteEdit);
            this.Name = "EditarPAciente";
            this.Text = "EditarPAciente";
            this.Load += new System.EventHandler(this.EditarPAciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MedicoAsociadoEdit;
        private System.Windows.Forms.Button submitEditPaciente;
        private System.Windows.Forms.Button cancelEditPAciente;
        private System.Windows.Forms.TextBox dolorPacienteEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apellidoPAcienteEdit;
        private System.Windows.Forms.Label nombrePacienteIntro;
        private System.Windows.Forms.TextBox nombrePacienteEdit;
    }
}