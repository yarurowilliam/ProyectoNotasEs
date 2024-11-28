using System;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using ENTITY;

namespace DAL
{
    public class DocenteMateriaDAL
    {
        private readonly string _connectionString;

        public DocenteMateriaDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método para insertar un registro en DOCENTE_MATERIA
        public async Task InsertarAsync(string docenteNumeroIdentificacion, int materiaId)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_Insertar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docenteNumeroIdentificacion;
                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // Método para actualizar un registro en DOCENTE_MATERIA
        public async Task ActualizarAsync(string docenteNumeroIdentificacion, int materiaId, int nuevoMateriaId)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_Actualizar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docenteNumeroIdentificacion;
                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;
                    cmd.Parameters.Add("p_NuevoMateriaId", OracleDbType.Int32).Value = nuevoMateriaId;

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // Método para obtener las materias de un docente
        public async Task<DataTable> TraerMateriasPorDocenteAsync(string docenteNumeroIdentificacion)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_TraerMateriasPorDocente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docenteNumeroIdentificacion;
                    cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        // Método para obtener los docentes de una materia
        public async Task<DataTable> TraerDocentesPorMateriaAsync(int materiaId)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_TraerDocentesPorMateria", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;
                    cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        // Método para consultar todos los registros de DOCENTE_MATERIA
        public async Task<DataTable> ConsultarAsync()
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_Consultar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }
    }
}
