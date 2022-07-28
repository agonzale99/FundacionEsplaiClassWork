
namespace AlvaroGonzalezHospital
{
    partial class MuestraExistentes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaMedicos = new System.Windows.Forms.ListBox();
            this.ListaPacientes = new System.Windows.Forms.ListBox();
            this.LabelLIstaMEdicos = new System.Windows.Forms.Label();
            this.labelListaPacientes = new System.Windows.Forms.Label();
            this.agregarMedico = new System.Windows.Forms.Button();
            this.modMedico = new System.Windows.Forms.Button();
            this.deleteMedico = new System.Windows.Forms.Button();
            this.eliminarPaciente = new System.Windows.Forms.Button();
            this.editarPaciente = new System.Windows.Forms.Button();
            this.addPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaMedicos
            // 
            this.ListaMedicos.FormattingEnabled = true;
            this.ListaMedicos.ItemHeight = 16;
            this.ListaMedicos.Location = new System.Drawing.Point(65, 69);
            this.ListaMedicos.Name = "ListaMedicos";
            this.ListaMedicos.Size = new System.Drawing.Size(224, 84);
            this.ListaMedicos.TabIndex = 0;
            // 
            // ListaPacientes
            // 
            this.ListaPacientes.FormattingEnabled = true;
            this.ListaPacientes.ItemHeight = 16;
            this.ListaPacientes.Location = new System.Drawing.Point(65, 241);
            this.ListaPacientes.Name = "ListaPacientes";
            this.ListaPacientes.Size = new System.Drawing.Size(224, 100);
            this.ListaPacientes.TabIndex = 1;
            // 
            // LabelLIstaMEdicos
            // 
            this.LabelLIstaMEdicos.AutoSize = true;
            this.LabelLIstaMEdicos.Location = new System.Drawing.Point(65, 30);
            this.LabelLIstaMEdicos.Name = "LabelLIstaMEdicos";
            this.LabelLIstaMEdicos.Size = new System.Drawing.Size(114, 17);
            this.LabelLIstaMEdicos.TabIndex = 2;
            this.LabelLIstaMEdicos.Text = "Lista de Médicos";
            // 
            // labelListaPacientes
            // 
            this.labelListaPacientes.AutoSize = true;
            this.labelListaPacientes.Location = new System.Drawing.Point(68, 204);
            this.labelListaPacientes.Name = "labelListaPacientes";
            this.labelListaPacientes.Size = new System.Drawing.Size(124, 17);
            this.labelListaPacientes.TabIndex = 3;
            this.labelListaPacientes.Text = "Lista de Pacientes";
            // 
            // agregarMedico
            // 
            this.agregarMedico.BackColor = System.Drawing.Color.Lime;
            this.agregarMedico.Location = new System.Drawing.Point(467, 103);
            this.agregarMedico.Name = "agregarMedico";
            this.agregarMedico.Size = new System.Drawing.Size(75, 23);
            this.agregarMedico.TabIndex = 4;
            this.agregarMedico.Text = "Add";
            this.agregarMedico.UseVisualStyleBackColor = false;
            this.agregarMedico.Click += new System.EventHandler(this.agregarMedico_Click);
            // 
            // modMedico
            // 
            this.modMedico.BackColor = System.Drawing.Color.Yellow;
            this.modMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modMedico.Location = new System.Drawing.Point(338, 81);
            this.modMedico.Name = "modMedico";
            this.modMedico.Size = new System.Drawing.Size(75, 23);
            this.modMedico.TabIndex = 5;
            this.modMedico.Text = "Editar";
            this.modMedico.UseVisualStyleBackColor = false;
            this.modMedico.Click += new System.EventHandler(this.modMedico_Click);
            // 
            // deleteMedico
            // 
            this.deleteMedico.BackColor = System.Drawing.Color.Red;
            this.deleteMedico.Location = new System.Drawing.Point(338, 121);
            this.deleteMedico.Name = "deleteMedico";
            this.deleteMedico.Size = new System.Drawing.Size(75, 23);
            this.deleteMedico.TabIndex = 6;
            this.deleteMedico.Text = "Eliminar";
            this.deleteMedico.UseVisualStyleBackColor = false;
            this.deleteMedico.Click += new System.EventHandler(this.deleteMedico_Click);
            // 
            // eliminarPaciente
            // 
            this.eliminarPaciente.BackColor = System.Drawing.Color.Red;
            this.eliminarPaciente.Location = new System.Drawing.Point(338, 306);
            this.eliminarPaciente.Name = "eliminarPaciente";
            this.eliminarPaciente.Size = new System.Drawing.Size(75, 23);
            this.eliminarPaciente.TabIndex = 9;
            this.eliminarPaciente.Text = "Eliminar";
            this.eliminarPaciente.UseVisualStyleBackColor = false;
            this.eliminarPaciente.Click += new System.EventHandler(this.eliminarPaciente_Click);
            // 
            // editarPaciente
            // 
            this.editarPaciente.BackColor = System.Drawing.Color.Yellow;
            this.editarPaciente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editarPaciente.Location = new System.Drawing.Point(338, 266);
            this.editarPaciente.Name = "editarPaciente";
            this.editarPaciente.Size = new System.Drawing.Size(75, 23);
            this.editarPaciente.TabIndex = 8;
            this.editarPaciente.Text = "Editar";
            this.editarPaciente.UseVisualStyleBackColor = false;
            this.editarPaciente.Click += new System.EventHandler(this.editarPaciente_Click);
            // 
            // addPaciente
            // 
            this.addPaciente.BackColor = System.Drawing.Color.Lime;
            this.addPaciente.Location = new System.Drawing.Point(467, 287);
            this.addPaciente.Name = "addPaciente";
            this.addPaciente.Size = new System.Drawing.Size(75, 23);
            this.addPaciente.TabIndex = 7;
            this.addPaciente.Text = "Add";
            this.addPaciente.UseVisualStyleBackColor = false;
            this.addPaciente.Click += new System.EventHandler(this.addPaciente_Click);
            // 
            // MuestraExistentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 404);
            this.Controls.Add(this.eliminarPaciente);
            this.Controls.Add(this.editarPaciente);
            this.Controls.Add(this.addPaciente);
            this.Controls.Add(this.deleteMedico);
            this.Controls.Add(this.modMedico);
            this.Controls.Add(this.agregarMedico);
            this.Controls.Add(this.labelListaPacientes);
            this.Controls.Add(this.LabelLIstaMEdicos);
            this.Controls.Add(this.ListaPacientes);
            this.Controls.Add(this.ListaMedicos);
            this.Name = "MuestraExistentes";
            this.Text = "MuestraExistentes";
            this.Load += new System.EventHandler(this.MuestraExistentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaMedicos;
        private System.Windows.Forms.ListBox ListaPacientes;
        private System.Windows.Forms.Label LabelLIstaMEdicos;
        private System.Windows.Forms.Label labelListaPacientes;
        private System.Windows.Forms.Button agregarMedico;
        private System.Windows.Forms.Button modMedico;
        private System.Windows.Forms.Button deleteMedico;
        private System.Windows.Forms.Button eliminarPaciente;
        private System.Windows.Forms.Button editarPaciente;
        private System.Windows.Forms.Button addPaciente;
    }
}

