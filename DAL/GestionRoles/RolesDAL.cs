using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DAL;

public class RolesDAL
{
    // Método para insertar un rol
    public async Task<bool> InsertarRolAsync(string nombreRol)
    {
        using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
        using var cmd = new OracleCommand("GestionRoles.InsertarRol", conn)
        {
            CommandType = CommandType.StoredProcedure
        };

        cmd.Parameters.Add("p_NombreRol", OracleDbType.Varchar2).Value = nombreRol;

        await conn.OpenAsync();
        int result = await cmd.ExecuteNonQueryAsync();
        if (result == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Método para consultar un rol por nombre
    public async Task<Rol> ConsultarRolPorNombreAsync(string nombreRol)
    {
        using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
        using var cmd = new OracleCommand("GestionRoles.ConsultarRolPorNombre", conn)
        {
            CommandType = CommandType.StoredProcedure
        };

        cmd.Parameters.Add("p_NombreRol", OracleDbType.Varchar2).Value = nombreRol;
        cmd.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

        await conn.OpenAsync();
        using var reader = await cmd.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Rol
            {
                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                NombreRol = reader.GetString(reader.GetOrdinal("NombreRol")),
                Estado = reader.GetString(reader.GetOrdinal("Estado"))
            };
        }

        return null; 
    }


    public async Task<bool> InactivarRolAsync(string nombreRol)
    {
        using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
        using var cmd = new OracleCommand("GestionRoles.InactivarRol", conn)
        {
            CommandType = CommandType.StoredProcedure
        };

        cmd.Parameters.Add("p_NombreRol", OracleDbType.Varchar2).Value = nombreRol;

        await conn.OpenAsync();
        int result = await cmd.ExecuteNonQueryAsync();
        if (result == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}