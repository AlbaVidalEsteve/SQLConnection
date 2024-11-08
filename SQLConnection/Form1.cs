using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SQLConnection
{
    public partial class Form1 : Form
    {
        //public SqlConnection connection { get; }
        public DBConnect dbConnection;
        public DALJob dalJob;
        public Form1()
        {
            InitializeComponent();
            this.Enabled = true;
            this.dbConnection = new DBConnect();
            this.dalJob = new DALJob();
        }
            
        private bool ValidateNumInput(string text, out decimal? result)
        {
            result = null;  // Inicializamos el resultado como null.

            // Si el texto está vacío, no hacemos nada y lo dejamos como null.
            if (string.IsNullOrWhiteSpace(text))
            {
                return true; // Es válido si está vacío, se asignará null.
            }

            // Intentamos convertir el texto en un decimal
            if (decimal.TryParse(text, out decimal value))
            {
                result = value; // Asignamos el valor numérico si la conversión es exitosa.
                return true; // Es válido si es un número.
            }
            else
            {
                // Mostrar mensaje de error y retornar false si el texto no es un número válido.
                MessageBox.Show("Ingrese un valor numérico válido para el salario.");
                return false; // No válido si no es un número.
            }
        }
        public void MostrarControl(UserControl control, Panel panel)
        {
            panel.Controls.Clear();

            control.Dock = DockStyle.Fill;

            panel.Controls.Add(control);
        }
        private void buttonJobs_Click(object sender, EventArgs e)
        {
            var userControlJob = new UserControlJob();
            MostrarControl(userControlJob,panelInputs);
        }
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            var userControlEmployee = new UserControlEmployee();
            MostrarControl(userControlEmployee, panelInputs);
        }
    }
}