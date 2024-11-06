using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConnection
{
    public class DALJob
    {
        private DBConnect dbConnection;

        public DALJob()
        {
            dbConnection = new DBConnect();
        }
        public List<Job> LoadJobs()
        {
            List<Job> jobs = new List<Job>();
            string query = "SELECT job_id, job_title, min_salary, max_salary FROM jobs";

            using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
            {
                dbConnection.connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Job job = new Job
                        {
                            JobId = reader.GetInt32(0),
                            JobTitle = reader.GetString(1),
                            MinSalary = reader.IsDBNull(2) ? (decimal?)null : reader.GetDecimal(2),
                            MaxSalary = reader.IsDBNull(3) ? (decimal?)null : reader.GetDecimal(3)
                        };
                        jobs.Add(job);
                    }
                }

                dbConnection.connection.Close();
            }

            return jobs;
        }

        // Método para agregar un trabajo en la base de datos
        public void AddJob(Job job)
        {
            string query = @"INSERT INTO jobs (job_title, min_salary, max_salary)
                             VALUES (@ptitle, @pminsalary, @pmaxsalary)";
                                //SELECT SCOPE_IDENTITY();
                                //(ExecuteScalar() -> devuelve object
                                //en este caso haremos cast int para recuperar el id
                                    //int id = (int)ExecuteScalar();

            using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
            {
                // Agregar parámetros con valores
                command.Parameters.Add(new SqlParameter("@ptitle", SqlDbType.VarChar, 35) { Value = job.JobTitle });
                command.Parameters.Add(new SqlParameter("@pminsalary", SqlDbType.Decimal) { Value = NullToDBNull(job.MinSalary) });
                command.Parameters.Add(new SqlParameter("@pmaxsalary", SqlDbType.Decimal) { Value = NullToDBNull(job.MaxSalary) });

                try
                {
                    if (dbConnection.connection.State != ConnectionState.Open)
                        dbConnection.connection.Open();
                    command.ExecuteNonQuery();
                    //int id = (int)command.ExecuteScalar(); // Ejecuta el comando de inserción
                    //command.Parameters.Add(new SqlParameter("@pjobid", SqlDbType.Int) { Value = NullToDBNull(job.JobId) });
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar el trabajo: " + ex.Message);
                }
                finally
                {
                    if (dbConnection.connection.State == ConnectionState.Open)
                        dbConnection.connection.Close();
                }
            }
        }

        public void SelectJob(int jobId)
        {
            string query = @"SELECT *
                     FROM jobs 
                     WHERE job_id = @job_id";

            using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@job_id", jobId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) // Comprobar si se encontraron resultados
                    {
                        string JobTitle = reader.GetString(reader.GetOrdinal("job_title"));
                        decimal? MinSalary = reader.IsDBNull(reader.GetOrdinal("min_salary")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("min_salary"));
                        decimal? MaxSalary = reader.IsDBNull(reader.GetOrdinal("max_salary")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("max_salary"));
                    }
                    else
                    {
                        throw new Exception("No se encontró ningún trabajo con ese ID.");
                    }
                }
            }
        }

        public void UpdateJob(Job job)
        {
            string query = @"UPDATE jobs 
                     SET job_title = @ptitle, 
                         min_salary = @pminsalary, 
                         max_salary = @pmaxsalary 
                     WHERE job_id = @job_id";

            using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@ptitle", job.JobTitle);
                command.Parameters.AddWithValue("@pminsalary", NullToDBNull(job.MinSalary));
                command.Parameters.AddWithValue("@pmaxsalary", NullToDBNull(job.MaxSalary));
                command.Parameters.AddWithValue("@job_id", job.JobId);

                try
                {
                    if (dbConnection.connection.State != ConnectionState.Open)
                        dbConnection.connection.Open();

                    command.ExecuteNonQuery(); // Ejecuta el comando de actualización
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el trabajo: " + ex.Message);
                }
                finally
                {
                    if (dbConnection.connection.State == ConnectionState.Open)
                        dbConnection.connection.Close();
                }
            }
        }
        public void DeleteJob(Job job)
        {
            string query = @"DELETE FROM jobs WHERE job_id = @job_id";

            using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@job_id", job.JobId);

                try
                {
                    if (dbConnection.connection.State != ConnectionState.Open)
                        dbConnection.connection.Open();

                    command.ExecuteNonQuery(); // Ejecuta el comando de eliminación
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el trabajo: " + ex.Message);
                }
                finally
                {
                    if (dbConnection.connection.State == ConnectionState.Open)
                        dbConnection.connection.Close();
                }
            }
        }

        // Método auxiliar para manejar valores NULL
        public static object NullToDBNull(object val)
        {
            return val ?? DBNull.Value;
        }

    }
}
