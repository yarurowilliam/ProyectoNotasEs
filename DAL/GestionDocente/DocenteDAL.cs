using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DAL.GestionDocente;

public class DocenteDAL
{
    public async Task<bool> InsertarDocenteAsync(Docente docente)
    {
        try
        {
            using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
            using var cmd = new OracleCommand("pq_Docente.pr_Insertar", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("p_TipoIdentificacion", OracleDbType.Varchar2).Value = docente.TipoIdentificacion;
            cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docente.NumeroIdentificacion;
            cmd.Parameters.Add("p_PrimerNombre", OracleDbType.Varchar2).Value = docente.PrimerNombre;
            cmd.Parameters.Add("p_SegundoNombre", OracleDbType.Varchar2).Value = docente.SegundoNombre;
            cmd.Parameters.Add("p_PrimerApellido", OracleDbType.Varchar2).Value = docente.PrimerApellido;
            cmd.Parameters.Add("p_SegundoApellido", OracleDbType.Varchar2).Value = docente.SegundoApellido;
            cmd.Parameters.Add("p_FechaNacimiento", OracleDbType.Date).Value = docente.FechaNacimiento;
            cmd.Parameters.Add("p_Telefono", OracleDbType.Varchar2).Value = docente.Telefono;
            cmd.Parameters.Add("p_Direccion", OracleDbType.NVarchar2).Value = docente.Direccion;
            cmd.Parameters.Add("p_Correo", OracleDbType.NVarchar2).Value = docente.Correo;
            cmd.Parameters.Add("p_Estado", OracleDbType.Varchar2).Value = docente.Estado;
            cmd.Parameters.Add("p_UsuarioIdentificacion", OracleDbType.Varchar2).Value = docente.UsuarioIdentificacion;

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
            Console.WriteLine($"Error inesperado al insertar el docente: {ex.Message}");
            throw;
        }
    }

    public async Task<bool> DesactivarDocenteAsync(string numeroIdentificacion)
    {
        try
        {
            using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
            using var cmd = new OracleCommand("pq_Docente.pr_Desactivar", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = numeroIdentificacion;

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
            Console.WriteLine($"Error inesperado al desactivar el docente: {ex.Message}");
            throw;
        }
    }

    public async Task<bool> ModificarDocenteAsync(Docente docente)
    {
        try
        {
            using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
            using var cmd = new OracleCommand("pq_Docente.pr_Actualizar", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docente.NumeroIdentificacion;
            cmd.Parameters.Add("p_TipoIdentificacion", OracleDbType.Varchar2).Value = docente.TipoIdentificacion;
            cmd.Parameters.Add("p_PrimerNombre", OracleDbType.Varchar2).Value = docente.PrimerNombre;
            cmd.Parameters.Add("p_SegundoNombre", OracleDbType.Varchar2).Value = docente.SegundoNombre;
            cmd.Parameters.Add("p_PrimerApellido", OracleDbType.Varchar2).Value = docente.PrimerApellido;
            cmd.Parameters.Add("p_SegundoApellido", OracleDbType.Varchar2).Value = docente.SegundoApellido;
            cmd.Parameters.Add("p_FechaNacimiento", OracleDbType.Date).Value = docente.FechaNacimiento;
            cmd.Parameters.Add("p_Telefono", OracleDbType.Varchar2).Value = docente.Telefono;
            cmd.Parameters.Add("p_Direccion", OracleDbType.NVarchar2).Value = docente.Direccion;
            cmd.Parameters.Add("p_Correo", OracleDbType.NVarchar2).Value = docente.Correo;
            cmd.Parameters.Add("p_Estado", OracleDbType.Varchar2).Value = docente.Estado;
            cmd.Parameters.Add("p_UsuarioIdentificacion", OracleDbType.Varchar2).Value = docente.UsuarioIdentificacion;

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
            Console.WriteLine($"Error inesperado al modificar el docente: {ex.Message}");
            throw;
        }
    }

    public async Task<Docente> TraerPorIDAsync(string numeroIdentificacion)
    {
        try
        {
            using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
            using var cmd = new OracleCommand("pq_Docente.pr_TraerPorID", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = numeroIdentificacion;
            cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            await conn.OpenAsync();

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Docente
                {
                    TipoIdentificacion = reader["TipoIdentificacion"].ToString(),
                    NumeroIdentificacion = reader["NumeroIdentificacion"].ToString(),
                    PrimerNombre = reader["PrimerNombre"].ToString(),
                    SegundoNombre = reader["SegundoNombre"].ToString(),
                    PrimerApellido = reader["PrimerApellido"].ToString(),
                    SegundoApellido = reader["SegundoApellido"].ToString(),
                    FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                    Telefono = reader["Telefono"].ToString(),
                    Direccion = reader["Direccion"].ToString(),
                    Correo = reader["correo"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    UsuarioIdentificacion = reader["USUARIO_Identificacion"].ToString()
                };
            }

            return null;
        }
        catch (OracleException ex) when (ex.Number >= -20000 && ex.Number <= -20999)
        {
            throw new DocenteException(ex.Message, ex.Number);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado al traer el docente por ID: {ex.Message}");
            throw;
        }
    }

    public async Task<List<Docente>> TraerTodosAsync()
    {
        var docentes = new List<Docente>();

        try
        {
            using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
            using var cmd = new OracleCommand("pq_Docente.pr_TraerTodos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("p_Resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            await conn.OpenAsync();

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var docente = new Docente
                {
                    TipoIdentificacion = reader["TipoIdentificacion"].ToString(),
                    NumeroIdentificacion = reader["NumeroIdentificacion"].ToString(),
                    PrimerNombre = reader["PrimerNombre"].ToString(),
                    SegundoNombre = reader["SegundoNombre"].ToString(),
                    PrimerApellido = reader["PrimerApellido"].ToString(),
                    SegundoApellido = reader["SegundoApellido"].ToString(),
                    FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                    Telefono = reader["Telefono"].ToString(),
                    Direccion = reader["Direccion"].ToString(),
                    Correo = reader["correo"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    UsuarioIdentificacion = reader["USUARIO_Identificacion"].ToString()
                };

                docentes.Add(docente);
            }

            return docentes;
        }
        catch (OracleException ex) when (ex.Number >= -20000 && ex.Number <= -20999)
        {
            throw new DocenteException(ex.Message, ex.Number);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado al traer todos los docentes: {ex.Message}");
            return docentes;
        }
    }
}