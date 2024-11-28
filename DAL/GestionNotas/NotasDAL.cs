using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using ENTITY;

namespace DAL
{
    public class NotasDAL
    {
        private readonly string _connectionString = OracleConnectionString.CadenaConexion;

        public async Task<int> InsertarNotaAsync(decimal nota, int materiaId, int periodoId, string numeroIdentificacion)
        {
            using (var conn = new OracleConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new OracleCommand("pq_Notas.pr_Insertar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Nota", OracleDbType.Decimal).Value = nota;
                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;
                    cmd.Parameters.Add("p_PeriodoId", OracleDbType.Int32).Value = periodoId;
                    cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = numeroIdentificacion;

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            return 0; 
        }

        public async Task<int> ActualizarNotaAsync(int notaId, decimal nuevaNota)
        {
            using (var conn = new OracleConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new OracleCommand("pq_Notas.pr_Actualizar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_NotaId", OracleDbType.Int32).Value = notaId;
                    cmd.Parameters.Add("p_Nota", OracleDbType.Decimal).Value = nuevaNota;

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            return 0; 
        }

        public async Task<DataTable> TraerNotasAsync(string numeroIdentificacion, int materiaId, int periodoId)
        {
            using (var conn = new OracleConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new OracleCommand("pq_Notas.pr_TraerNotas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = numeroIdentificacion;
                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;
                    cmd.Parameters.Add("p_PeriodoId", OracleDbType.Int32).Value = periodoId;

                    var refCursor = new OracleParameter("p_Resultado", OracleDbType.RefCursor)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(refCursor);

                    var dataTable = new DataTable();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        dataTable.Load(reader);
                    }

                    return dataTable;
                }
            }
        }
    }
}