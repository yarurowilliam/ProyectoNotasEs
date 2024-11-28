using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using ENTITY;

namespace DAL
{
    public class SalonDAL
    {
        // Método para insertar un salón
        public async Task InsertarAsync(Salon salon)
        {
            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await connection.OpenAsync();
                var command = new OracleCommand("pq_Salon.pr_Insertar", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add("p_NombreSalon", OracleDbType.Varchar2).Value = salon.NombreSalon;
                command.Parameters.Add("p_GradoId_FK", OracleDbType.Int32).Value = salon.GradoId_FK;

                await command.ExecuteNonQueryAsync();
            }
        }

        // Método para actualizar un salón
        public async Task ActualizarAsync(Salon salon)
        {
            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await connection.OpenAsync();
                var command = new OracleCommand("pq_Salon.pr_Actualizar", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = salon.SalonId;
                command.Parameters.Add("p_NombreSalon", OracleDbType.Varchar2).Value = salon.NombreSalon;
                command.Parameters.Add("p_GradoId_FK", OracleDbType.Int32).Value = salon.GradoId_FK;

                await command.ExecuteNonQueryAsync();
            }
        }

        // Método para obtener un salón por ID
        public async Task<Salon> TraerPorIDAsync(int salonId)
        {
            Salon salon = null;

            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await connection.OpenAsync();
                var command = new OracleCommand("pq_Salon.pr_TraerPorID", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add("p_SalonId", OracleDbType.Int32).Value = salonId;
                command.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        salon = new Salon
                        {
                            SalonId = reader.GetInt32(0),
                            NombreSalon = reader.GetString(1),
                            GradoId_FK = reader.GetInt32(2)
                        };
                    }
                }
            }

            return salon;
        }

        // Método para obtener todos los salones
        public async Task<List<Salon>> TraerTodosAsync()
        {
            var salones = new List<Salon>();

            using (var connection = new OracleConnection(OracleConnectionString.CadenaConexion))
            {
                await connection.OpenAsync();
                var command = new OracleCommand("pq_Salon.pr_TraerTodos", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        salones.Add(new Salon
                        {
                            SalonId = reader.GetInt32(0),
                            NombreSalon = reader.GetString(1),
                            GradoId_FK = reader.GetInt32(2)
                        });
                    }
                }
            }

            return salones;
        }
    }
}
