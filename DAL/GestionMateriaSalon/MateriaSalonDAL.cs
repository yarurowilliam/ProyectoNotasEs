using System;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using ENTITY;
using Entity;

namespace DAL
{
    public class MateriaSalonDAL
    {
        // Método para insertar un nuevo registro de MateriaSalon
        public static async Task InsertarAsync(MateriaSalon materiaSalon)
        {
            using (OracleConnection conn = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await conn.OpenAsync();

                using (OracleCommand cmd = new OracleCommand("pq_MateriaSalon.pr_Insertar", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaSalon.MateriaId;
                    cmd.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = materiaSalon.SalonId;

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // Método para actualizar un registro de MateriaSalon
        public static async Task ActualizarAsync(MateriaSalon materiaSalon, int nuevoSalonId)
        {
            using (OracleConnection conn = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await conn.OpenAsync();

                using (OracleCommand cmd = new OracleCommand("pq_MateriaSalon.pr_Actualizar", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaSalon.MateriaId;
                    cmd.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = materiaSalon.SalonId;
                    cmd.Parameters.Add("p_NuevoSalonId", OracleDbType.Int32).Value = nuevoSalonId;

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // Método para obtener la relación de materia y salón por MateriaId
        public static async Task TraerPorMateriaIdAsync(int materiaId)
        {
            using (OracleConnection conn = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await conn.OpenAsync();

                using (OracleCommand cmd = new OracleCommand("pq_MateriaSalon.pr_TraerPorMateriaId", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_MateriaId", OracleDbType.Int32).Value = materiaId;
                    cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;

                    using (OracleDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"MateriaId: {reader.GetInt32(0)}, SalonId: {reader.GetInt32(1)}");
                        }
                    }
                }
            }
        }

        // Método para obtener la relación de materia y salón por SalonId
        public static async Task TraerPorSalonIdAsync(int salonId)
        {
            using (OracleConnection conn = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await conn.OpenAsync();

                using (OracleCommand cmd = new OracleCommand("pq_MateriaSalon.pr_TraerPorSalonId", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = salonId;
                    cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;

                    using (OracleDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"MateriaId: {reader.GetInt32(0)}, SalonId: {reader.GetInt32(1)}");
                        }
                    }
                }
            }
        }
    }
}
