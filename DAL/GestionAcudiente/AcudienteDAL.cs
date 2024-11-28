using System;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using Entity.GestionAcudiente;
using DAL.GestionDocente;

namespace DAL
{
    public class AcudienteDAL
    {
        private readonly string _cadenaConexion = OracleConnectionString.CadenaConexion;

        public async Task<bool> InsertarAcudienteAsync(Acudiente acudiente)
        {
            try
            {
                using var conn = new OracleConnection(_cadenaConexion);
                using var cmd = new OracleCommand("pq_Acudientes.pr_Insertar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_IdAcudiente", OracleDbType.Int32).Value = acudiente.IdAcudiente;
                cmd.Parameters.Add("p_PrimerNombre", OracleDbType.NVarchar2).Value = acudiente.PrimerNombre;
                cmd.Parameters.Add("p_SegundoNombre", OracleDbType.NVarchar2).Value = acudiente.SegundoNombre;
                cmd.Parameters.Add("p_PrimerApellido", OracleDbType.NVarchar2).Value = acudiente.PrimerApellido;
                cmd.Parameters.Add("p_SegundoApellido", OracleDbType.NVarchar2).Value = acudiente.SegundoApellido;
                cmd.Parameters.Add("p_Telefono", OracleDbType.NVarchar2).Value = acudiente.Telefono;
                cmd.Parameters.Add("p_Email", OracleDbType.NVarchar2).Value = acudiente.Email;

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                return true;
            }
            catch (OracleException ex) when (ex.Number >= -20000 && ex.Number <= -20999)
            {
                Console.WriteLine($"Oracle Error: {ex.Message} - Error Code: {ex.Number}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return false;
            }
        }

        public async Task<Acudiente> TraerAcudientePorIDAsync(int idAcudiente)
        {
            Acudiente acudiente = null;
            try
            {
                using var conn = new OracleConnection(_cadenaConexion);
                using var cmd = new OracleCommand("pq_Acudientes.pr_TraerPorID", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_IdAcudiente", OracleDbType.Int32).Value = idAcudiente;
                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                await conn.OpenAsync();

                using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    acudiente = new Acudiente
                    {
                        IdAcudiente = reader.GetInt32(0),
                        PrimerNombre = reader.GetString(1),
                        SegundoNombre = reader.IsDBNull(2) ? null : reader.GetString(2),
                        PrimerApellido = reader.GetString(3),
                        SegundoApellido = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Telefono = reader.GetString(5),
                        Email = reader.GetString(6)
                    };
                }

                return acudiente;
            }
            catch (OracleException ex) when (ex.Number >= -20000 && ex.Number <= -20999)
            {
                Console.WriteLine($"Oracle Error: {ex.Message} - Error Code: {ex.Number}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Acudiente>> TraerTodosAcudientesAsync()
        {
            var acudientes = new List<Acudiente>();
            try
            {
                using var conn = new OracleConnection(_cadenaConexion);
                using var cmd = new OracleCommand("pq_Acudientes.pr_TraerTodos", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                await conn.OpenAsync();

                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var acudiente = new Acudiente
                    {
                        IdAcudiente = reader.GetInt32(0),
                        PrimerNombre = reader.GetString(1),
                        SegundoNombre = reader.IsDBNull(2) ? null : reader.GetString(2),
                        PrimerApellido = reader.GetString(3),
                        SegundoApellido = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Telefono = reader.GetString(5),
                        Email = reader.GetString(6)
                    };

                    acudientes.Add(acudiente);
                }

                return acudientes;
            }
            catch (OracleException ex) when (ex.Number >= -20000 && ex.Number <= -20999)
            {
                Console.WriteLine($"Oracle Error: {ex.Message} - Error Code: {ex.Number}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> ModificarAcudienteAsync(Acudiente acudiente)
        {
            try
            {
                using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
                using var cmd = new OracleCommand("pq_Acudientes.pr_Actualizar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_IdAcudiente", OracleDbType.Int32).Value = acudiente.IdAcudiente;
                cmd.Parameters.Add("p_PrimerNombre", OracleDbType.NVarchar2).Value = acudiente.PrimerNombre;
                cmd.Parameters.Add("p_SegundoNombre", OracleDbType.NVarchar2).Value = acudiente.SegundoApellido;
                cmd.Parameters.Add("p_PrimerApellido", OracleDbType.NVarchar2).Value = acudiente.PrimerApellido;
                cmd.Parameters.Add("p_SegundoApellido", OracleDbType.NVarchar2).Value = acudiente.SegundoApellido;
                cmd.Parameters.Add("p_Telefono", OracleDbType.NVarchar2).Value = acudiente.Telefono;
                cmd.Parameters.Add("p_Email", OracleDbType.NVarchar2).Value = acudiente.Email;
                

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                return true;
            }
            catch (OracleException ex) when (ex.Number >= -20000 && ex.Number <= -20999)
            {
                throw new DocenteException(ex.Message, ex.Number);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al modificar el acudiente: {ex.Message}");
                throw;
            }
        }
    }
}
