namespace SQLConnection
{
    partial class UserControlJob
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMaxSalary = new System.Windows.Forms.TextBox();
            this.textBoxMinSalary = new System.Windows.Forms.TextBox();
            this.labelMaxSalary = new System.Windows.Forms.Label();
            this.labelMinSalary = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMaxSalary
            // 
            this.textBoxMaxSalary.Location = new System.Drawing.Point(48, 206);
            this.textBoxMaxSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaxSalary.Name = "textBoxMaxSalary";
            this.textBoxMaxSalary.Size = new System.Drawing.Size(296, 26);
            this.textBoxMaxSalary.TabIndex = 27;
            // 
            // textBoxMinSalary
            // 
            this.textBoxMinSalary.Location = new System.Drawing.Point(48, 138);
            this.textBoxMinSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMinSalary.Name = "textBoxMinSalary";
            this.textBoxMinSalary.Size = new System.Drawing.Size(296, 26);
            this.textBoxMinSalary.TabIndex = 26;
            // 
            // labelMaxSalary
            // 
            this.labelMaxSalary.AutoSize = true;
            this.labelMaxSalary.Location = new System.Drawing.Point(44, 183);
            this.labelMaxSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxSalary.Name = "labelMaxSalary";
            this.labelMaxSalary.Size = new System.Drawing.Size(86, 20);
            this.labelMaxSalary.TabIndex = 25;
            this.labelMaxSalary.Text = "Max Salary";
            // 
            // labelMinSalary
            // 
            this.labelMinSalary.AutoSize = true;
            this.labelMinSalary.Location = new System.Drawing.Point(44, 106);
            this.labelMinSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinSalary.Name = "labelMinSalary";
            this.labelMinSalary.Size = new System.Drawing.Size(82, 20);
            this.labelMinSalary.TabIndex = 24;
            this.labelMinSalary.Text = "Min Salary";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(44, 38);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(68, 20);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Job Title";
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(48, 63);
            this.textBoxJobTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(296, 26);
            this.textBoxJobTitle.TabIndex = 22;
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
            this.dataGridViewJobs.Location = new System.Drawing.Point(400, 63);
            this.dataGridViewJobs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.ReadOnly = true;
            this.dataGridViewJobs.RowHeadersWidth = 62;
            this.dataGridViewJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJobs.Size = new System.Drawing.Size(687, 169);
            this.dataGridViewJobs.TabIndex = 28;
            this.dataGridViewJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellClick);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(642, 17);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(112, 35);
            this.buttonGuardar.TabIndex = 31;
            this.buttonGuardar.Text = "Save";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.MouseCaptureChanged += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(400, 18);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(112, 35);
            this.buttonBorrar.TabIndex = 30;
            this.buttonBorrar.Text = "Delete";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(521, 18);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(112, 35);
            this.buttonNuevo.TabIndex = 29;
            this.buttonNuevo.Text = "New";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // UserControlJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.dataGridViewJobs);
            this.Controls.Add(this.textBoxMaxSalary);
            this.Controls.Add(this.textBoxMinSalary);
            this.Controls.Add(this.labelMaxSalary);
            this.Controls.Add(this.labelMinSalary);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxJobTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlJob";
            this.Size = new System.Drawing.Size(1106, 278);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMaxSalary;
        private System.Windows.Forms.TextBox textBoxMinSalary;
        private System.Windows.Forms.Label labelMaxSalary;
        private System.Windows.Forms.Label labelMinSalary;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonNuevo;
    }
}
