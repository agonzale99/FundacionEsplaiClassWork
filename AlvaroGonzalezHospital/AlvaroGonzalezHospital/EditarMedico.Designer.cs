
namespace AlvaroGonzalezHospital
{
    partial class EditarMedico
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
            this.submitAddMedico = new System.Windows.Forms.Button();
            this.cancelAddMedico = new System.Windows.Forms.Button();
            this.codMedicoEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apellidoMedicoEdit = new System.Windows.Forms.TextBox();
            this.nombrePacienteIntro = new System.Windows.Forms.Label();
            this.nombreMedicoEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitAddMedico
            // 
            this.submitAddMedico.Location = new System.Drawing.Point(351, 93);
            this.submitAddMedico.Name = "submitAddMedico";
            this.submitAddMedico.Size = new System.Drawing.Size(75, 23);
            this.submitAddMedico.TabIndex = 27;
            this.submitAddMedico.Text = "Submit";
            this.submitAddMedico.UseVisualStyleBackColor = true;
            this.submitAddMedico.Click += new System.EventHandler(this.submitAddMedico_Click);
            // 
            // cancelAddMedico
            // 
            this.cancelAddMedico.Location = new System.Drawing.Point(214, 93);
            this.cancelAddMedico.Name = "cancelAddMedico";
            this.cancelAddMedico.Size = new System.Drawing.Size(75, 23);
            this.cancelAddMedico.TabIndex = 26;
            this.cancelAddMedico.Text = "Cancel";
            this.cancelAddMedico.UseVisualStyleBackColor = true;
            this.cancelAddMedico.Click += new System.EventHandler(this.cancelAddMedico_Click);
            // 
            // codMedicoEdit
            // 
            this.codMedicoEdit.Location = new System.Drawing.Point(473, 38);
            this.codMedicoEdit.Name = "codMedicoEdit";
            this.codMedicoEdit.Size = new System.Drawing.Size(145, 22);
            this.codMedicoEdit.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cod. Medico Asociado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Apellido";
            // 
            // apellidoMedicoEdit
            // 
            this.apellidoMedicoEdit.Location = new System.Drawing.Point(342, 38);
            this.apellidoMedicoEdit.Name = "apellidoMedicoEdit";
            this.apellidoMedicoEdit.Size = new System.Drawing.Size(100, 22);
            this.apellidoMedicoEdit.TabIndex = 22;
            // 
            // nombrePacienteIntro
            // 
            this.nombrePacienteIntro.AutoSize = true;
            this.nombrePacienteIntro.Location = new System.Drawing.Point(186, 15);
            this.nombrePacienteIntro.Name = "nombrePacienteIntro";
            this.nombrePacienteIntro.Size = new System.Drawing.Size(58, 17);
            this.nombrePacienteIntro.TabIndex = 21;
            this.nombrePacienteIntro.Text = "Nombre";
            // 
            // nombreMedicoEdit
            // 
            this.nombreMedicoEdit.Location = new System.Drawing.Point(189, 38);
            this.nombreMedicoEdit.Name = "nombreMedicoEdit";
            this.nombreMedicoEdit.Size = new System.Drawing.Size(100, 22);
            this.nombreMedicoEdit.TabIndex = 20;
            // 
            // EditarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 130);
            this.Controls.Add(this.submitAddMedico);
            this.Controls.Add(this.cancelAddMedico);
            this.Controls.Add(this.codMedicoEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apellidoMedicoEdit);
            this.Controls.Add(this.nombrePacienteIntro);
            this.Controls.Add(this.nombreMedicoEdit);
            this.Name = "EditarMedico";
            this.Text = "EditarMedico";
            this.Load += new System.EventHandler(this.EditarMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitAddMedico;
        private System.Windows.Forms.Button cancelAddMedico;
        private System.Windows.Forms.TextBox codMedicoEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apellidoMedicoEdit;
        private System.Windows.Forms.Label nombrePacienteIntro;
        private System.Windows.Forms.TextBox nombreMedicoEdit;
    }
}