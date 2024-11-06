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

        private void buttonConnectar_Click(object sender, EventArgs e)
        {
            if (dbConnection.connection.State == ConnectionState.Closed)
            {
                dbConnection.Connect();
                buttonConectar.Enabled = false;
                buttonDesconectar.Enabled = true;
                textBoxStatus.Text = "Opened";

                // Cargar trabajos en el DataGridView
                LoadJobs();
            }
        }
        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            if (dbConnection.connection.State == ConnectionState.Open)
            {
                dbConnection.Disconnect();
                buttonDesconectar.Enabled = false;
                buttonConectar.Enabled = true;
                textBoxStatus.Text = "Closed";
            }
        }
        private void ClearInputFields()
        {
            textBoxJobTitle.Clear();
            textBoxMinSalary.Clear();
            textBoxMaxSalary.Clear();
        }                
        private void LoadJobs()
        {
            try
            {
                List<Job> listaJobs = dalJob.LoadJobs();
                dataGridViewJobs.DataSource = listaJobs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar trabajos: " + ex.Message);
            }
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
        private void dataGridViewJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewJobs.SelectedRows.Count > 0) // Asegúrate de que la fila es válida
            {
                // Obtener la fila seleccionada
                var jobSeleccionado = dataGridViewJobs.SelectedRows[0].DataBoundItem as Job;

                // Obtener los valores de las celdas de la fila seleccionada
                int jobId = jobSeleccionado.JobId; // Obtener el ID del trabajo

                // Mostrar los datos en los controles de entrada
                textBoxJobTitle.Text = jobSeleccionado.JobTitle; // Asignar el título del trabajo al TextBox
                textBoxMinSalary.Text = jobSeleccionado.MinSalary.ToString(); // Asignar el salario mínimo al NumericUpDown
                textBoxMaxSalary.Text = jobSeleccionado.MaxSalary.ToString(); // Asignar el salario máximo al NumericUpDown
            }
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridViewJobs.SelectedRows.Count > 0)
            {
                var jobSeleccionado = dataGridViewJobs.SelectedRows[0].DataBoundItem as Job;
                if (jobSeleccionado != null)
                {
                    ModificarJob(jobSeleccionado);
                }
            }
            else
            {
                AgregarNuevoJob();
            }
            //dataGridViewJobs.Visible = false;
            //buttonGuardar.Visible = false;
        }
        private void ModificarJob(Job job)
        {
            if (dataGridViewJobs.SelectedRows.Count > 0)
            {
                var jobSeleccionado = dataGridViewJobs.SelectedRows[0].DataBoundItem as Job;

                // Verificar si los salarios son válidos
                if (!ValidateNumInput(textBoxMinSalary.Text, out decimal? minSalary) ||
                    !ValidateNumInput(textBoxMaxSalary.Text, out decimal? maxSalary))
                {
                    // Si cualquiera de los salarios es inválido, no se modifica el trabajo
                    return;
                }

                // Actualizar la instancia de Job
                Job updatedJob = new Job
                {
                    JobId = jobSeleccionado.JobId,
                    JobTitle = textBoxJobTitle.Text,
                    MinSalary = minSalary,  // Se asigna el valor validado
                    MaxSalary = maxSalary
                };

                try
                {
                    dalJob.UpdateJob(updatedJob);
                    MessageBox.Show("Trabajo actualizado con éxito!");
                    LoadJobs();  // Recargar los trabajos
                    ClearInputFields();  // Limpiar campos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el trabajo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un trabajo de la lista.");
            }
        }
        private void AgregarNuevoJob()
        {
            // Captura de datos del formulario           
            string jobTitle = textBoxJobTitle.Text;

            // Validar salario mínimo y máximo
            if (!ValidateNumInput(textBoxMinSalary.Text, out decimal? minSalary) ||
                !ValidateNumInput(textBoxMaxSalary.Text, out decimal? maxSalary))
            {
                // Si cualquiera de los salarios es inválido, no se agrega el trabajo.
                return;
            }

            // Validar que el título del trabajo no esté vacío
            if (string.IsNullOrWhiteSpace(jobTitle))
            {
                MessageBox.Show("El título del trabajo no puede estar vacío.");
                return;
            }

            // Crear una instancia de la clase Job con los datos ingresados
            Job newJob = new Job
            {
                JobTitle = jobTitle,
                MinSalary = minSalary,  // Si la validación fue exitosa, los salarios se asignan aquí
                MaxSalary = maxSalary
            };

            // Llamar al método para agregar el trabajo a la base de datos
            try
            {
                dalJob.AddJob(newJob);
                MessageBox.Show("Trabajo agregado con éxito!");

                // Limpiar los campos después de la inserción
                ClearInputFields();
                LoadJobs();  // Recargar los trabajos para actualizar la vista
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el trabajo: " + ex.Message);
            }
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewJobs.Visible = true;
            buttonGuardar.Visible = true;
            ClearInputFields();
            //dataGridViewJobs.DataSource = null;
            dataGridViewJobs.ClearSelection();
        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewJobs.SelectedRows.Count > 0)
            {
                var jobSeleccionado = dataGridViewJobs.SelectedRows[0].DataBoundItem as Job;
                if (jobSeleccionado != null)
                {
                    dalJob.DeleteJob(jobSeleccionado);
                    LoadJobs();
                }
            }
        }

    }
}