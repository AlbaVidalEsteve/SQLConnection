namespace SQLConnection
{
    partial class UserControlEmployee
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.textBoxMaxSalary = new System.Windows.Forms.TextBox();
            this.textBoxMinSalary = new System.Windows.Forms.TextBox();
            this.labelMaxSalary = new System.Windows.Forms.Label();
            this.labelMinSalary = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(628, 22);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(112, 35);
            this.buttonGuardar.TabIndex = 41;
            this.buttonGuardar.Text = "Save";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(386, 23);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(112, 35);
            this.buttonBorrar.TabIndex = 40;
            this.buttonBorrar.Text = "Delete";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(507, 23);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(112, 35);
            this.buttonNuevo.TabIndex = 39;
            this.buttonNuevo.Text = "New";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
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
            this.dataGridViewJobs.Location = new System.Drawing.Point(386, 68);
            this.dataGridViewJobs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.ReadOnly = true;
            this.dataGridViewJobs.RowHeadersWidth = 62;
            this.dataGridViewJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJobs.Size = new System.Drawing.Size(905, 169);
            this.dataGridViewJobs.TabIndex = 38;
            this.dataGridViewJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellClick);
            // 
            // textBoxMaxSalary
            // 
            this.textBoxMaxSalary.Location = new System.Drawing.Point(34, 211);
            this.textBoxMaxSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaxSalary.Name = "textBoxMaxSalary";
            this.textBoxMaxSalary.Size = new System.Drawing.Size(296, 26);
            this.textBoxMaxSalary.TabIndex = 37;
            // 
            // textBoxMinSalary
            // 
            this.textBoxMinSalary.Location = new System.Drawing.Point(34, 143);
            this.textBoxMinSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMinSalary.Name = "textBoxMinSalary";
            this.textBoxMinSalary.Size = new System.Drawing.Size(296, 26);
            this.textBoxMinSalary.TabIndex = 36;
            // 
            // labelMaxSalary
            // 
            this.labelMaxSalary.AutoSize = true;
            this.labelMaxSalary.Location = new System.Drawing.Point(30, 188);
            this.labelMaxSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxSalary.Name = "labelMaxSalary";
            this.labelMaxSalary.Size = new System.Drawing.Size(86, 20);
            this.labelMaxSalary.TabIndex = 35;
            this.labelMaxSalary.Text = "Max Salary";
            // 
            // labelMinSalary
            // 
            this.labelMinSalary.AutoSize = true;
            this.labelMinSalary.Location = new System.Drawing.Point(30, 111);
            this.labelMinSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinSalary.Name = "labelMinSalary";
            this.labelMinSalary.Size = new System.Drawing.Size(82, 20);
            this.labelMinSalary.TabIndex = 34;
            this.labelMinSalary.Text = "Min Salary";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(30, 43);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(68, 20);
            this.labelTitle.TabIndex = 33;
            this.labelTitle.Text = "Job Title";
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(34, 68);
            this.textBoxJobTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(296, 26);
            this.textBoxJobTitle.TabIndex = 32;
            // 
            // UserControlEmployee
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
            this.Name = "UserControlEmployee";
            this.Size = new System.Drawing.Size(1762, 663);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.TextBox textBoxMaxSalary;
        private System.Windows.Forms.TextBox textBoxMinSalary;
        private System.Windows.Forms.Label labelMaxSalary;
        private System.Windows.Forms.Label labelMinSalary;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxJobTitle;
    }
}
