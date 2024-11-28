using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{
    public class GradoDAL
    {
        private OracleConnection conexion;

        public GradoDAL()
        {
            conexion = new OracleConnection(OracleConnectionString.CadenaConexion);
        }

        public async Task InsertarAsync(string nombreGrado)
        {
            using (var cmd = new OracleCommand("pq_Grado.pr_Insertar", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_NombreGrado", OracleDbType.Varchar2).Value = nombreGrado;

                try
                {
                    await conexion.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
                finally
                {
                    await conexion.CloseAsync();
                }
            }
        }

        public async Task ActualizarAsync(int gradoId, string nombreGrado)
        {
            using (var cmd = new OracleCommand("pq_Grado.pr_Actualizar", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_GradoId_PK", OracleDbType.Int32).Value = gradoId;
                cmd.Parameters.Add("p_NombreGrado", OracleDbType.Varchar2).Value = nombreGrado;

                try
                {
                    await conexion.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
                finally
                {
                    await conexion.CloseAsync();
                }
            }
        }

        public async Task<List<(int GradoId, string NombreGrado)>> TraerTodosAsync()
        {
            var grados = new List<(int, string)>();
            using (var cmd = new OracleCommand("pq_Grado.pr_TraerTodos", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                try
                {
                    await conexion.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            grados.Add((reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
                finally
                {
                    await conexion.CloseAsync();
                }
            }
            return grados;
        }

        public async Task<(int GradoId, string NombreGrado)> TraerPorIdAsync(int gradoId)
        {
            using (var cmd = new OracleCommand("pq_Grado.pr_TraerPorID", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_GradoId_PK", OracleDbType.Int32).Value = gradoId;
                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                try
                {
                    await conexion.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return (reader.GetInt32(0), reader.GetString(1));
                        }
                        else
                        {
                            throw new Exception("Grado no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
                finally
                {
                    await conexion.CloseAsync();
                }
            }
        }
    }
}
