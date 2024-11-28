using System;
using System.Data;
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
        public void Insertar(string docenteNumeroIdentificacion, int materiaId)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_Insertar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docenteNumeroIdentificacion;
                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar un registro en DOCENTE_MATERIA
        public void Actualizar(string docenteNumeroIdentificacion, int materiaId, int nuevoMateriaId)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_Actualizar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docenteNumeroIdentificacion;
                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;
                    cmd.Parameters.Add("p_NuevoMateriaId", OracleDbType.Int32).Value = nuevoMateriaId;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener las materias de un docente
        public DataTable TraerMateriasPorDocente(string docenteNumeroIdentificacion)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_TraerMateriasPorDocente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docenteNumeroIdentificacion;
                    cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        // Método para obtener los docentes de una materia
        public DataTable TraerDocentesPorMateria(int materiaId)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_TraerDocentesPorMateria", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;
                    cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        // Método para consultar todos los registros de DOCENTE_MATERIA
        public DataTable Consultar()
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new OracleCommand("pq_DocenteMateria.pr_Consultar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
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
