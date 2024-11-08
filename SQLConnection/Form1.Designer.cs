namespace SQLConnection
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.buttonJobs = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelInputs
            // 
            this.panelInputs.Location = new System.Drawing.Point(13, 56);
            this.panelInputs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(1282, 311);
            this.panelInputs.TabIndex = 22;
            // 
            // buttonJobs
            // 
            this.buttonJobs.Location = new System.Drawing.Point(13, 11);
            this.buttonJobs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonJobs.Name = "buttonJobs";
            this.buttonJobs.Size = new System.Drawing.Size(112, 35);
            this.buttonJobs.TabIndex = 0;
            this.buttonJobs.Text = "Jobs";
            this.buttonJobs.UseVisualStyleBackColor = true;
            this.buttonJobs.Click += new System.EventHandler(this.buttonJobs_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(133, 10);
            this.buttonEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(112, 35);
            this.buttonEmployees.TabIndex = 23;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 834);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonJobs);
            this.Controls.Add(this.panelInputs);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Button buttonJobs;
        private System.Windows.Forms.Button buttonEmployees;
    }
}

