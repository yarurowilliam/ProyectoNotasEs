using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

public class EstudianteDAL
{
    private readonly string _connectionString;

    public EstudianteDAL(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task InsertarEstudianteAsync(Estudiante estudiante)
    {
        using (var connection = new OracleConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new OracleCommand("pq_Estudiantes.pr_Insertar", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_TipoIdentificacion", OracleDbType.Varchar2).Value = estudiante.TipoIdentificacion;
                command.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = estudiante.NumeroIdentificacion;
                command.Parameters.Add("p_PrimerNombre", OracleDbType.Varchar2).Value = estudiante.PrimerNombre;
                command.Parameters.Add("p_SegundoNombre", OracleDbType.Varchar2).Value = estudiante.SegundoNombre;
                command.Parameters.Add("p_PrimerApellido", OracleDbType.Varchar2).Value = estudiante.PrimerApellido;
                command.Parameters.Add("p_SegundoApellido", OracleDbType.Varchar2).Value = estudiante.SegundoApellido;
                command.Parameters.Add("p_FechaNacimiento", OracleDbType.Date).Value = estudiante.FechaNacimiento;
                command.Parameters.Add("p_Telefono", OracleDbType.Varchar2).Value = estudiante.Telefono;
                command.Parameters.Add("p_Direccion", OracleDbType.NVarchar2).Value = estudiante.Direccion;
                command.Parameters.Add("p_Correo", OracleDbType.Varchar2).Value = estudiante.Correo;
                command.Parameters.Add("p_Estado", OracleDbType.Varchar2).Value = estudiante.Estado;
                command.Parameters.Add("p_AcudienteId", OracleDbType.Int32).Value = estudiante.AcudienteId;

                await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task ActualizarEstudianteAsync(Estudiante estudiante)
    {
        using (var connection = new OracleConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new OracleCommand("pq_Estudiantes.pr_Actualizar", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = estudiante.NumeroIdentificacion;
                command.Parameters.Add("p_TipoIdentificacion", OracleDbType.Varchar2).Value = estudiante.TipoIdentificacion;
                command.Parameters.Add("p_PrimerNombre", OracleDbType.Varchar2).Value = estudiante.PrimerNombre;
                command.Parameters.Add("p_SegundoNombre", OracleDbType.Varchar2).Value = estudiante.SegundoNombre;
                command.Parameters.Add("p_PrimerApellido", OracleDbType.Varchar2).Value = estudiante.PrimerApellido;
                command.Parameters.Add("p_SegundoApellido", OracleDbType.Varchar2).Value = estudiante.SegundoApellido;
                command.Parameters.Add("p_FechaNacimiento", OracleDbType.Date).Value = estudiante.FechaNacimiento;
                command.Parameters.Add("p_Telefono", OracleDbType.Varchar2).Value = estudiante.Telefono;
                command.Parameters.Add("p_Direccion", OracleDbType.NVarchar2).Value = estudiante.Direccion;
                command.Parameters.Add("p_Correo", OracleDbType.Varchar2).Value = estudiante.Correo;
                command.Parameters.Add("p_Estado", OracleDbType.Varchar2).Value = estudiante.Estado;
                command.Parameters.Add("p_AcudienteId", OracleDbType.Int32).Value = estudiante.AcudienteId;

                await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task DesactivarEstudianteAsync(string numeroIdentificacion)
    {
        using (var connection = new OracleConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new OracleCommand("pq_Estudiantes.pr_Desactivar", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = numeroIdentificacion;

                await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<Estudiante> ObtenerEstudiantePorIdentificacionAsync(string numeroIdentificacion)
    {
        using (var connection = new OracleConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new OracleCommand("pq_Estudiantes.pr_TraerPorIdentificacion", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = numeroIdentificacion;
                command.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new Estudiante
                        {
                            NumeroIdentificacion = reader.GetString(0),
                            PrimerNombre = reader.GetString(1),
                            SegundoNombre = reader.GetString(2),
                            PrimerApellido = reader.GetString(3),
                            SegundoApellido = reader.GetString(4),
                            FechaNacimiento = reader.GetDateTime(5),
                            Telefono = reader.GetString(6),
                            Direccion = reader.GetString(7),
                            Correo = reader.GetString(8),
                            Estado = reader.GetString(9),
                            AcudienteId = reader.GetInt32(10),
                            Edad = reader.GetInt32(11) // Edad calculada por el procedimiento
                        };
                    }
                }
            }
        }
        return null;
    }

    public async Task<List<Estudiante>> ObtenerTodosLosEstudiantesAsync()
    {
        var estudiantes = new List<Estudiante>();

        using (var connection = new OracleConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new OracleCommand("pq_Estudiantes.pr_TraerTodos", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        estudiantes.Add(new Estudiante
                        {
                            TipoIdentificacion = reader["TipoIdentificacion"].ToString(),
                            NumeroIdentificacion = reader.GetString(1),
                            PrimerNombre = reader.GetString(2),
                            SegundoNombre = reader.GetString(3),
                            PrimerApellido = reader.GetString(4),
                            SegundoApellido = reader.GetString(5),
                            FechaNacimiento = reader.GetDateTime(6),
                            Telefono = reader.GetString(7),
                            Direccion = reader.GetString(8),
                            Correo = reader.GetString(9),
                            Estado = reader.GetString(10),
                            AcudienteId = reader.GetInt32(11),
                            Edad = reader.GetInt32(12) // Edad calculada por el procedimiento
                        });
                    }
                }
            }
        }

        return estudiantes;
    }
}
