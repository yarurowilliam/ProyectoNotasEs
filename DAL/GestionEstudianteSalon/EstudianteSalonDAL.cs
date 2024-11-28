using System;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class EstudianteSalonDAL
    {
        // Método para insertar un estudiante en un salón
        public static async Task InsertarAsync(string numeroIdentificacion, int salonId)
        {
            string query = "INSERT INTO ESTUDIANTE_SALON (ESTUDIANTES_NumeroIdentificaion, SALON_SalonId) " +
                           "VALUES (:NumeroIdentificacion, :SalonId)";

            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await connection.OpenAsync();
                using (var command = new OracleCommand(query, connection))
                {
                    // Parametrizar la consulta para evitar inyección SQL
                    command.Parameters.Add(new OracleParameter("NumeroIdentificacion", numeroIdentificacion));
                    command.Parameters.Add(new OracleParameter("SalonId", salonId));

                    int result = await command.ExecuteNonQueryAsync();
                    if (result > 0)
                    {
                        Console.WriteLine("Relación Estudiante-Salón insertada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Error al insertar la relación Estudiante-Salón.");
                    }
                }
            }
        }

        // Método para actualizar la relación entre estudiante y salón
        public static async Task ActualizarAsync(string numeroIdentificacion, int salonId, int nuevoSalonId)
        {
            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await connection.OpenAsync();
                using (var command = new OracleCommand("pq_EstudianteSalon.pr_Actualizar", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = numeroIdentificacion;
                    command.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = salonId;
                    command.Parameters.Add("p_NuevoSalonId", OracleDbType.Int32).Value = nuevoSalonId;

                    await command.ExecuteNonQueryAsync();
                }
            }

        }

        // Método para obtener los estudiantes de un salón
        public static async Task<DataTable> TraerEstudiantesPorSalonAsync(int salonId)
        {
            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await connection.OpenAsync();
                using (var command = new OracleCommand("pq_EstudianteSalon.pr_TraerEstudiantesPorSalon", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = salonId;
                    command.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }

    }
}
