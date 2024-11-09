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
    private readonly OracleConnectionDAL _oracleConnectionDAL;

    public DocenteDAL(OracleConnectionDAL oracleConnectionDAL)
    {
        _oracleConnectionDAL = oracleConnectionDAL;
    }

    public async Task<bool> InsertarDocenteAsync(Docente docente)
    {
        try
        {
            using var conn = new OracleConnection(_oracleConnectionDAL.ConnectionString);
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
            return result > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al insertar el docente: {ex.Message}");
            return false;
        }
    }
}
