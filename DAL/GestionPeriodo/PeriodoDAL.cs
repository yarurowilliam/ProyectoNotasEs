using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using ENTITY;
using System.Threading.Tasks;
using Entity.GestionPeriodo;

namespace DAL
{
    public class PeriodoDAL
    {
        private static readonly string ConnectionString = OracleConnectionString.CadenaConexion;

        public async Task InsertarPeriodoAsync(Periodo periodo)
        {
            using (var connection = new OracleConnection(ConnectionString))
            {
                using (var command = new OracleCommand("pq_Periodo.pr_Insertar", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("p_IdPeriodo", OracleDbType.Int32).Value = periodo.IdPeriodo;
                    command.Parameters.Add("p_FechaInicio", OracleDbType.Date).Value = periodo.FechaInicio;
                    command.Parameters.Add("p_FechaFin", OracleDbType.Date).Value = periodo.FechaFin;
                    command.Parameters.Add("p_Estado", OracleDbType.Varchar2).Value = periodo.Estado;

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task ActualizarPeriodoAsync(Periodo periodo)
        {
            using (var connection = new OracleConnection(ConnectionString))
            {
                using (var command = new OracleCommand("pq_Periodo.pr_Actualizar", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("p_IdPeriodo", OracleDbType.Int32).Value = periodo.IdPeriodo;
                    command.Parameters.Add("p_FechaInicio", OracleDbType.Date).Value = periodo.FechaInicio;
                    command.Parameters.Add("p_FechaFin", OracleDbType.Date).Value = periodo.FechaFin;
                    command.Parameters.Add("p_Estado", OracleDbType.Varchar2).Value = periodo.Estado;

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<DataTable> TraerTodosPeriodosAsync()
        {
            using (var connection = new OracleConnection(ConnectionString))
            {
                using (var command = new OracleCommand("pq_Periodo.pr_TraerTodos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }

        public async Task<Periodo> TraerPeriodoPorIdAsync(int idPeriodo)
        {
            using (var connection = new OracleConnection(ConnectionString))
            {
                using (var command = new OracleCommand("pq_Periodo.pr_TraerPorId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("p_IdPeriodo", OracleDbType.Int32).Value = idPeriodo;
                    command.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Periodo
                            {
                                IdPeriodo = reader.GetInt32(0),
                                FechaInicio = reader.GetDateTime(1),
                                FechaFin = reader.GetDateTime(2),
                                Estado = reader.GetString(3),
                                FechaModificacion = reader.GetDateTime(4)
                            };
                        }
                        return null;
                    }
                }
            }
        }
    }
}