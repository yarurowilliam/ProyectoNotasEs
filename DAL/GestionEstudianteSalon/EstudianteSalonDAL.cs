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
                try
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
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al insertar: {ex.Message}");
                }
            }
        }

        // Método para actualizar la relación entre estudiante y salón
        public static async Task ActualizarAsync(string numeroIdentificacion, int salonId, int nuevoSalonId)
        {
            string query = "UPDATE ESTUDIANTE_SALON SET SALON_SalonId = :NuevoSalonId " +
                           "WHERE ESTUDIANTES_NumeroIdentificaion = :NumeroIdentificacion AND SALON_SalonId = :SalonId";

            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                try
                {
                    await connection.OpenAsync();
                    using (var command = new OracleCommand(query, connection))
                    {
                        // Parametrizar la consulta
                        command.Parameters.Add(new OracleParameter("NumeroIdentificacion", numeroIdentificacion));
                        command.Parameters.Add(new OracleParameter("SalonId", salonId));
                        command.Parameters.Add(new OracleParameter("NuevoSalonId", nuevoSalonId));

                        int result = await command.ExecuteNonQueryAsync();
                        if (result > 0)
                        {
                            Console.WriteLine("Relación Estudiante-Salón actualizada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Error al actualizar la relación Estudiante-Salón.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar: {ex.Message}");
                }
            }
        }

        // Método para obtener los estudiantes de un salón
        public static async Task TraerEstudiantesPorSalonAsync(int salonId)
        {
            string query = "SELECT E.NumeroIdentificaion, E.PrimerNombre, E.SegundoNombre, E.PrimerApellido, " +
                           "E.SegundoApellido, E.FechaNacimiento, E.Telefono, E.Direccion, E.Correo, E.Estado, " +
                           "S.NombreSalon, G.NombreGrado " +
                           "FROM ESTUDIANTE_SALON ES " +
                           "JOIN ESTUDIANTE E ON ES.ESTUDIANTES_NumeroIdentificaion = E.NumeroIdentificaion " +
                           "JOIN SALON S ON ES.SALON_SalonId = S.SalonId " +
                           "JOIN GRADO G ON S.GradoId_FK = G.GradoId_PK " +
                           "WHERE ES.SALON_SalonId = :SalonId";

            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                try
                {
                    await connection.OpenAsync();
                    using (var command = new OracleCommand(query, connection))
                    {
                        // Parametrizar la consulta
                        command.Parameters.Add(new OracleParameter("SalonId", salonId));

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                // Imprimir los datos de los estudiantes
                                Console.WriteLine($"Estudiante: {reader["NumeroIdentificaion"]}, " +
                                                  $"{reader["PrimerNombre"]} {reader["PrimerApellido"]}, " +
                                                  $"Correo: {reader["Correo"]}, Estado: {reader["Estado"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al traer estudiantes: {ex.Message}");
                }
            }
        }
    }
}
