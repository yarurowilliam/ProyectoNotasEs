using System;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using Entity.GestionMateria;

namespace DAL
{
    public class MateriaDAL
    {
        private readonly string _cadenaConexion = OracleConnectionString.CadenaConexion;

        public async Task<bool> InsertarMateriaAsync(Materia materia)
        {
            try
            {
                using var conn = new OracleConnection(_cadenaConexion);
                using var cmd = new OracleCommand("pq_Materia.pr_Insertar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_NombreMateria", OracleDbType.Varchar2).Value = materia.NombreMateria;
                cmd.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = materia.SalonId;

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
                return true;
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error Oracle: {ex.Message} - Código de error: {ex.Number}");
                return false;
            }
        }

        public async Task<bool> ActualizarMateriaAsync(Materia materia)
        {
            try
            {
                using var conn = new OracleConnection(_cadenaConexion);
                using var cmd = new OracleCommand("pq_Materia.pr_Actualizar", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materia.MateriaId;
                cmd.Parameters.Add("p_NombreMateria", OracleDbType.Varchar2).Value = materia.NombreMateria;
                cmd.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = materia.SalonId;

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
                return true;
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error Oracle: {ex.Message} - Código de error: {ex.Number}");
                return false;
            }
        }

        public async Task<Materia> TraerMateriaPorIdAsync(int materiaId)
        {
            try
            {
                using var conn = new OracleConnection(_cadenaConexion);
                using var cmd = new OracleCommand("pq_Materia.pr_TraerPorID", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;
                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                await conn.OpenAsync();

                using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    return new Materia
                    {
                        MateriaId = reader.GetInt32(0),
                        NombreMateria = reader.GetString(1),
                        SalonId = reader.GetInt32(2)
                    };
                }

                return null;
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error Oracle: {ex.Message} - Código de error: {ex.Number}");
                return null;
            }
        }

        public async Task<List<Materia>> TraerTodasLasMateriasAsync()
        {
            try
            {
                var materias = new List<Materia>();
                using var conn = new OracleConnection(_cadenaConexion);
                using var cmd = new OracleCommand("pq_Materia.pr_TraerTodos", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                await conn.OpenAsync();

                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    materias.Add(new Materia
                    {
                        MateriaId = reader.GetInt32(0),
                        NombreMateria = reader.GetString(1),
                        SalonId = reader.GetInt32(2)
                    });
                }

                return materias;
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error Oracle: {ex.Message} - Código de error: {ex.Number}");
                return null;
            }
        }

        public async Task<List<Materia>> TraerMateriasPorSalonAsync(int salonId)
        {
            try
            {
                var materias = new List<Materia>();
                using var conn = new OracleConnection(_cadenaConexion);
                using var cmd = new OracleCommand("pq_Materia.pr_TraerMateriasPorSalon", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = salonId;
                cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                await conn.OpenAsync();

                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    materias.Add(new Materia
                    {
                        MateriaId = reader.GetInt32(0),
                        NombreMateria = reader.GetString(1),
                        SalonId = reader.GetInt32(2)
                    });
                }

                return materias;
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error Oracle: {ex.Message} - Código de error: {ex.Number}");
                return null;
            }
        }
    }
}
