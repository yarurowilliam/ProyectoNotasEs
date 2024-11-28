using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace DAL
{
    public class GradoDAL
    {
        private OracleConnection conexion;

        public GradoDAL()
        {
            conexion = new OracleConnection(OracleConnectionString.CadenaConexion);
        }

        public void Insertar(string nombreGrado)
        {
            using (var cmd = new OracleCommand("pq_Grado.pr_Insertar", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_NombreGrado", OracleDbType.Varchar2).Value = nombreGrado;

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void Actualizar(int gradoId, string nombreGrado)
        {
            using (var cmd = new OracleCommand("pq_Grado.pr_Actualizar", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_GradoId_PK", OracleDbType.Int32).Value = gradoId;
                cmd.Parameters.Add("p_NombreGrado", OracleDbType.Varchar2).Value = nombreGrado;

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public List<(int GradoId, string NombreGrado)> TraerTodos()
        {
            var grados = new List<(int, string)>();
            using (var cmd = new OracleCommand("pq_Grado.pr_TraerTodos", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                try
                {
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
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
                    conexion.Close();
                }
            }
            return grados;
        }

        public (int GradoId, string NombreGrado) TraerPorId(int gradoId)
        {
            using (var cmd = new OracleCommand("pq_Grado.pr_TraerPorID", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_GradoId_PK", OracleDbType.Int32).Value = gradoId;
                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                try
                {
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
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
                    conexion.Close();
                }
            }
        }
    }
}
