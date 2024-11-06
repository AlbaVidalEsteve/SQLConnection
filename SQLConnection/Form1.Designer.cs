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
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMinSalary = new System.Windows.Forms.Label();
            this.labelMaxSalary = new System.Windows.Forms.Label();
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxMinSalary = new System.Windows.Forms.TextBox();
            this.textBoxMaxSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(42, 68);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(78, 33);
            this.buttonConectar.TabIndex = 3;
            this.buttonConectar.Text = "Connect";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConnectar_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Location = new System.Drawing.Point(163, 68);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(78, 33);
            this.buttonDesconectar.TabIndex = 4;
            this.buttonDesconectar.Text = "Disconnect";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(42, 42);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(199, 20);
            this.textBoxStatus.TabIndex = 5;
            this.textBoxStatus.Text = "Closed";
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(42, 136);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(199, 20);
            this.textBoxJobTitle.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(39, 120);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Job Title";
            // 
            // labelMinSalary
            // 
            this.labelMinSalary.AutoSize = true;
            this.labelMinSalary.Location = new System.Drawing.Point(39, 164);
            this.labelMinSalary.Name = "labelMinSalary";
            this.labelMinSalary.Size = new System.Drawing.Size(56, 13);
            this.labelMinSalary.TabIndex = 12;
            this.labelMinSalary.Text = "Min Salary";
            // 
            // labelMaxSalary
            // 
            this.labelMaxSalary.AutoSize = true;
            this.labelMaxSalary.Location = new System.Drawing.Point(39, 214);
            this.labelMaxSalary.Name = "labelMaxSalary";
            this.labelMaxSalary.Size = new System.Drawing.Size(59, 13);
            this.labelMaxSalary.TabIndex = 13;
            this.labelMaxSalary.Text = "Max Salary";
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.AllowUserToAddRows = false;
            this.dataGridViewJobs.AllowUserToDeleteRows = false;
            this.dataGridViewJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJobs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewJobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewJobs.Location = new System.Drawing.Point(284, 42);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.ReadOnly = true;
            this.dataGridViewJobs.RowHeadersWidth = 62;
            this.dataGridViewJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJobs.Size = new System.Drawing.Size(565, 236);
            this.dataGridViewJobs.TabIndex = 15;
            this.dataGridViewJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellClick);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(365, 13);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 17;
            this.buttonNuevo.Text = "New";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(284, 13);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 18;
            this.buttonBorrar.Text = "Delete";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(446, 12);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "Save";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxMinSalary
            // 
            this.textBoxMinSalary.Location = new System.Drawing.Point(42, 185);
            this.textBoxMinSalary.Name = "textBoxMinSalary";
            this.textBoxMinSalary.Size = new System.Drawing.Size(199, 20);
            this.textBoxMinSalary.TabIndex = 20;
            // 
            // textBoxMaxSalary
            // 
            this.textBoxMaxSalary.Location = new System.Drawing.Point(42, 229);
            this.textBoxMaxSalary.Name = "textBoxMaxSalary";
            this.textBoxMaxSalary.Size = new System.Drawing.Size(199, 20);
            this.textBoxMaxSalary.TabIndex = 21;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonDesconectar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 296);
            this.Controls.Add(this.textBoxMaxSalary);
            this.Controls.Add(this.textBoxMinSalary);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.dataGridViewJobs);
            this.Controls.Add(this.labelMaxSalary);
            this.Controls.Add(this.labelMinSalary);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxJobTitle);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.buttonConectar);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMinSalary;
        private System.Windows.Forms.Label labelMaxSalary;
        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxMinSalary;
        private System.Windows.Forms.TextBox textBoxMaxSalary;
    }
}

