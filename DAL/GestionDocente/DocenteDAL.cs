using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GestionDocente;

public class DocenteDAL
{
    public async Task<bool> InsertarDocenteAsync(Docente docente)
    {
        try
        {
            using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
            using var cmd = new OracleCommand("GestionDocente.InsertarDocente", conn)
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
            cmd.Parameters.Add("p_Direccion", OracleDbType.Varchar2).Value = docente.Direccion;
            cmd.Parameters.Add("p_Correo", OracleDbType.Varchar2).Value = docente.Correo;
            cmd.Parameters.Add("p_Practicante", OracleDbType.Int32).Value = docente.Practicante ? 1 : 0;
            cmd.Parameters.Add("p_UltimoUsuario", OracleDbType.Varchar2).Value = docente.UltimoUsuario;

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
        catch (Exception ex)
        {
            Console.WriteLine($"Error al insertar el docente: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> ExisteDocenteAsync(string numeroIdentificacion)
    {
        using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
        using var cmd = new OracleCommand("SELECT COUNT(*) FROM Docente WHERE NumeroIdentificacion = :numeroIdentificacion", conn);
        cmd.Parameters.Add("numeroIdentificacion", OracleDbType.Varchar2).Value = numeroIdentificacion;

        await conn.OpenAsync();
        int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
        return count > 0;
    }

    public async Task<List<Docente>> ConsultarDocenteAsync(string numeroIdentificacion, bool aplicarFiltros)
    {
        List<Docente> docentes = new List<Docente>();

        using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
        using var cmd = new OracleCommand("GestionDocente.ConsultarDocente", conn)
        {
            CommandType = CommandType.StoredProcedure
        };

       cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = aplicarFiltros && !string.IsNullOrEmpty(numeroIdentificacion) ? (object)numeroIdentificacion : DBNull.Value;

        // Definir el parámetro de salida como cursor
        cmd.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

        await conn.OpenAsync();

        using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            Docente docente = new Docente
            {
                TipoIdentificacion = reader["TipoIdentificacion"].ToString(),
                NumeroIdentificacion = reader["NumeroIdentificacion"].ToString(),
                PrimerNombre = reader["PrimerNombre"].ToString(),
                SegundoNombre = reader["SegundoNombre"].ToString() ?? "",
                PrimerApellido = reader["PrimerApellido"].ToString(),
                SegundoApellido = reader["SegundoApellido"].ToString() ?? "",
                FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                Edad = reader.GetInt32(reader.GetOrdinal("Edad")),
                Telefono = reader["Telefono"].ToString(),
                Direccion = reader["Direccion"].ToString(),
                Correo = reader["Correo"].ToString(),
                Practicante = reader.GetInt32(reader.GetOrdinal("Practicante")) == 1,
                FechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaCreacion")),
                FechaModificacion = reader.IsDBNull(reader.GetOrdinal("FechaModificacion")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("FechaModificacion")),
                UltimoUsuario = reader["UltimoUsuario"].ToString(),
                Estado = reader["Estado"].ToString()
            };

            docentes.Add(docente);
        }

        return docentes;
    }

    public async Task<bool> ModificarDocenteAsync(Docente docente)
    {
        using var conn = new OracleConnection(OracleConnectionString.CadenaConexion);
        using var cmd = new OracleCommand("GestionDocente.ModificarDocente", conn)
        {
            CommandType = CommandType.StoredProcedure
        };

        // Agregar parámetros para la modificación
        cmd.Parameters.Add("p_NumeroIdentificacion", OracleDbType.Varchar2).Value = docente.NumeroIdentificacion;
        cmd.Parameters.Add("p_TipoIdentificacion", OracleDbType.Varchar2).Value = docente.TipoIdentificacion;
        cmd.Parameters.Add("p_PrimerNombre", OracleDbType.Varchar2).Value = docente.PrimerNombre;
        cmd.Parameters.Add("p_SegundoNombre", OracleDbType.Varchar2).Value = docente.SegundoNombre;
        cmd.Parameters.Add("p_PrimerApellido", OracleDbType.Varchar2).Value = docente.PrimerApellido;
        cmd.Parameters.Add("p_SegundoApellido", OracleDbType.Varchar2).Value = docente.SegundoApellido;
        cmd.Parameters.Add("p_FechaNacimiento", OracleDbType.Date).Value = docente.FechaNacimiento;
        cmd.Parameters.Add("p_Telefono", OracleDbType.Varchar2).Value = docente.Telefono;
        cmd.Parameters.Add("p_Direccion", OracleDbType.Varchar2).Value = docente.Direccion;
        cmd.Parameters.Add("p_Correo", OracleDbType.Varchar2).Value = docente.Correo;
        cmd.Parameters.Add("p_Practicante", OracleDbType.Int32).Value = docente.Practicante ? 1 : 0;
        cmd.Parameters.Add("p_Estado", OracleDbType.Varchar2).Value = docente.Estado;
        cmd.Parameters.Add("p_UltimoUsuario", OracleDbType.Varchar2).Value = docente.UltimoUsuario;

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
