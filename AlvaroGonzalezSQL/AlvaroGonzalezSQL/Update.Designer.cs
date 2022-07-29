
namespace AlvaroGonzalezSQL
{
    partial class Update
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
            this.minSalary = new System.Windows.Forms.NumericUpDown();
            this.maxSalary = new System.Windows.Forms.NumericUpDown();
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // minSalary
            // 
            this.minSalary.Enabled = false;
            this.minSalary.Location = new System.Drawing.Point(390, 77);
            this.minSalary.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.minSalary.Name = "minSalary";
            this.minSalary.Size = new System.Drawing.Size(120, 22);
            this.minSalary.TabIndex = 15;
            // 
            // maxSalary
            // 
            this.maxSalary.Enabled = false;
            this.maxSalary.Location = new System.Drawing.Point(222, 76);
            this.maxSalary.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.maxSalary.Name = "maxSalary";
            this.maxSalary.Size = new System.Drawing.Size(120, 22);
            this.maxSalary.TabIndex = 14;
            // 
            // jobTitle
            // 
            this.jobTitle.Enabled = false;
            this.jobTitle.Location = new System.Drawing.Point(58, 76);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(100, 22);
            this.jobTitle.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salario Maximo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salario Minimo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Trabajo";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(127, 134);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(308, 134);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 17;
            this.submit.Text = "sub";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 197);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.minSalary);
            this.Controls.Add(this.maxSalary);
            this.Controls.Add(this.jobTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown minSalary;
        private System.Windows.Forms.NumericUpDown maxSalary;
        private System.Windows.Forms.TextBox jobTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
    }
}