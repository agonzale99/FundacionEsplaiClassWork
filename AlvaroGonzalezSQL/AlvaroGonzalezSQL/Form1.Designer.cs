
namespace AlvaroGonzalezSQL
{
    partial class BaseDeDatosForm
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
            this.conectarServidor = new System.Windows.Forms.Button();
            this.cerrarConexionGlobal = new System.Windows.Forms.Button();
            this.insertarValor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.maxSalary = new System.Windows.Forms.NumericUpDown();
            this.minSalary = new System.Windows.Forms.NumericUpDown();
            this.listaDeSelects = new System.Windows.Forms.ListBox();
            this.deletePrueba = new System.Windows.Forms.Button();
            this.deleteList = new System.Windows.Forms.ComboBox();
            this.pruebaUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // conectarServidor
            // 
            this.conectarServidor.Location = new System.Drawing.Point(12, 100);
            this.conectarServidor.Name = "conectarServidor";
            this.conectarServidor.Size = new System.Drawing.Size(199, 23);
            this.conectarServidor.TabIndex = 0;
            this.conectarServidor.Text = "Conectar Servidor";
            this.conectarServidor.UseVisualStyleBackColor = true;
            this.conectarServidor.Click += new System.EventHandler(this.ConectarServidor_Click);
            // 
            // cerrarConexionGlobal
            // 
            this.cerrarConexionGlobal.Enabled = false;
            this.cerrarConexionGlobal.Location = new System.Drawing.Point(257, 100);
            this.cerrarConexionGlobal.Name = "cerrarConexionGlobal";
            this.cerrarConexionGlobal.Size = new System.Drawing.Size(172, 23);
            this.cerrarConexionGlobal.TabIndex = 2;
            this.cerrarConexionGlobal.Text = "Cerrar Conexion Global";
            this.cerrarConexionGlobal.UseVisualStyleBackColor = true;
            this.cerrarConexionGlobal.Click += new System.EventHandler(this.cerrarConexionGlobal_Click);
            // 
            // insertarValor
            // 
            this.insertarValor.Enabled = false;
            this.insertarValor.Location = new System.Drawing.Point(142, 171);
            this.insertarValor.Name = "insertarValor";
            this.insertarValor.Size = new System.Drawing.Size(195, 23);
            this.insertarValor.TabIndex = 3;
            this.insertarValor.Text = "Insertar Valor";
            this.insertarValor.UseVisualStyleBackColor = true;
            this.insertarValor.Click += new System.EventHandler(this.insertarValor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Trabajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario Maximo";
            // 
            // jobTitle
            // 
            this.jobTitle.Enabled = false;
            this.jobTitle.Location = new System.Drawing.Point(12, 270);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(100, 22);
            this.jobTitle.TabIndex = 7;
            // 
            // maxSalary
            // 
            this.maxSalary.Enabled = false;
            this.maxSalary.Location = new System.Drawing.Point(176, 271);
            this.maxSalary.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.maxSalary.Name = "maxSalary";
            this.maxSalary.Size = new System.Drawing.Size(120, 22);
            this.maxSalary.TabIndex = 8;
            // 
            // minSalary
            // 
            this.minSalary.Enabled = false;
            this.minSalary.Location = new System.Drawing.Point(344, 271);
            this.minSalary.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.minSalary.Name = "minSalary";
            this.minSalary.Size = new System.Drawing.Size(120, 22);
            this.minSalary.TabIndex = 9;
            // 
            // listaDeSelects
            // 
            this.listaDeSelects.Enabled = false;
            this.listaDeSelects.FormattingEnabled = true;
            this.listaDeSelects.ItemHeight = 16;
            this.listaDeSelects.Location = new System.Drawing.Point(609, 87);
            this.listaDeSelects.Name = "listaDeSelects";
            this.listaDeSelects.Size = new System.Drawing.Size(473, 196);
            this.listaDeSelects.TabIndex = 10;
            // 
            // deletePrueba
            // 
            this.deletePrueba.Enabled = false;
            this.deletePrueba.Location = new System.Drawing.Point(503, 362);
            this.deletePrueba.Name = "deletePrueba";
            this.deletePrueba.Size = new System.Drawing.Size(106, 23);
            this.deletePrueba.TabIndex = 12;
            this.deletePrueba.Text = "Delete";
            this.deletePrueba.UseVisualStyleBackColor = true;
            this.deletePrueba.Click += new System.EventHandler(this.deletePrueba_Click);
            // 
            // deleteList
            // 
            this.deleteList.Enabled = false;
            this.deleteList.FormattingEnabled = true;
            this.deleteList.Location = new System.Drawing.Point(660, 381);
            this.deleteList.Name = "deleteList";
            this.deleteList.Size = new System.Drawing.Size(438, 24);
            this.deleteList.TabIndex = 13;
            this.deleteList.Text = "Seleccione uno";
            // 
            // pruebaUpdate
            // 
            this.pruebaUpdate.Location = new System.Drawing.Point(503, 403);
            this.pruebaUpdate.Name = "pruebaUpdate";
            this.pruebaUpdate.Size = new System.Drawing.Size(103, 23);
            this.pruebaUpdate.TabIndex = 14;
            this.pruebaUpdate.Text = "Upadte";
            this.pruebaUpdate.UseVisualStyleBackColor = true;
            this.pruebaUpdate.Click += new System.EventHandler(this.pruebaUpdate_Click);
            // 
            // BaseDeDatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 460);
            this.Controls.Add(this.pruebaUpdate);
            this.Controls.Add(this.deleteList);
            this.Controls.Add(this.deletePrueba);
            this.Controls.Add(this.listaDeSelects);
            this.Controls.Add(this.minSalary);
            this.Controls.Add(this.maxSalary);
            this.Controls.Add(this.jobTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertarValor);
            this.Controls.Add(this.cerrarConexionGlobal);
            this.Controls.Add(this.conectarServidor);
            this.Name = "BaseDeDatosForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseDeDatosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conectarServidor;
        private System.Windows.Forms.Button cerrarConexionGlobal;
        private System.Windows.Forms.Button insertarValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jobTitle;
        private System.Windows.Forms.NumericUpDown maxSalary;
        private System.Windows.Forms.NumericUpDown minSalary;
        private System.Windows.Forms.ListBox listaDeSelects;
        private System.Windows.Forms.Button deletePrueba;
        private System.Windows.Forms.ComboBox deleteList;
        private System.Windows.Forms.Button pruebaUpdate;
    }
}

