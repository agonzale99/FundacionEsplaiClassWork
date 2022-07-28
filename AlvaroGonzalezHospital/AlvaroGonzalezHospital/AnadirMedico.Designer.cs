
namespace AlvaroGonzalezHospital
{
    partial class AnadirMedico
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
            this.codMedicoAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apellidoMedicoAdd = new System.Windows.Forms.TextBox();
            this.nombrePacienteIntro = new System.Windows.Forms.Label();
            this.nombreMedicoAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitAddMedico
            // 
            this.submitAddMedico.Location = new System.Drawing.Point(202, 108);
            this.submitAddMedico.Name = "submitAddMedico";
            this.submitAddMedico.Size = new System.Drawing.Size(75, 23);
            this.submitAddMedico.TabIndex = 19;
            this.submitAddMedico.Text = "Submit";
            this.submitAddMedico.UseVisualStyleBackColor = true;
            this.submitAddMedico.Click += new System.EventHandler(this.submitAddMedico_Click);
            // 
            // cancelAddMedico
            // 
            this.cancelAddMedico.Location = new System.Drawing.Point(65, 108);
            this.cancelAddMedico.Name = "cancelAddMedico";
            this.cancelAddMedico.Size = new System.Drawing.Size(75, 23);
            this.cancelAddMedico.TabIndex = 18;
            this.cancelAddMedico.Text = "Cancel";
            this.cancelAddMedico.UseVisualStyleBackColor = true;
            this.cancelAddMedico.Click += new System.EventHandler(this.cancelAddMedico_Click);
            // 
            // codMedicoAdd
            // 
            this.codMedicoAdd.Location = new System.Drawing.Point(324, 53);
            this.codMedicoAdd.Name = "codMedicoAdd";
            this.codMedicoAdd.Size = new System.Drawing.Size(145, 22);
            this.codMedicoAdd.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cod. Medico Asociado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Apellido";
            // 
            // apellidoMedicoAdd
            // 
            this.apellidoMedicoAdd.Location = new System.Drawing.Point(193, 53);
            this.apellidoMedicoAdd.Name = "apellidoMedicoAdd";
            this.apellidoMedicoAdd.Size = new System.Drawing.Size(100, 22);
            this.apellidoMedicoAdd.TabIndex = 12;
            // 
            // nombrePacienteIntro
            // 
            this.nombrePacienteIntro.AutoSize = true;
            this.nombrePacienteIntro.Location = new System.Drawing.Point(37, 30);
            this.nombrePacienteIntro.Name = "nombrePacienteIntro";
            this.nombrePacienteIntro.Size = new System.Drawing.Size(58, 17);
            this.nombrePacienteIntro.TabIndex = 11;
            this.nombrePacienteIntro.Text = "Nombre";
            // 
            // nombreMedicoAdd
            // 
            this.nombreMedicoAdd.Location = new System.Drawing.Point(40, 53);
            this.nombreMedicoAdd.Name = "nombreMedicoAdd";
            this.nombreMedicoAdd.Size = new System.Drawing.Size(100, 22);
            this.nombreMedicoAdd.TabIndex = 10;
            // 
            // AnadirMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 156);
            this.Controls.Add(this.submitAddMedico);
            this.Controls.Add(this.cancelAddMedico);
            this.Controls.Add(this.codMedicoAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apellidoMedicoAdd);
            this.Controls.Add(this.nombrePacienteIntro);
            this.Controls.Add(this.nombreMedicoAdd);
            this.Name = "AnadirMedico";
            this.Text = "AnadirMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitAddMedico;
        private System.Windows.Forms.Button cancelAddMedico;
        private System.Windows.Forms.TextBox codMedicoAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apellidoMedicoAdd;
        private System.Windows.Forms.Label nombrePacienteIntro;
        private System.Windows.Forms.TextBox nombreMedicoAdd;
    }
}