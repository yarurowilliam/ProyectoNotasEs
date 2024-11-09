using System;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL;

public class OracleConnectionDAL
{
    private readonly string _connectionString;

    public OracleConnectionDAL()
    {
        _connectionString = "User Id=Administrador;Password=123456;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=34.135.42.7)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));";
    }

    public async Task<bool> TestConnectionAsync()
    {
        try
        {
            await using var connection = new OracleConnection(_connectionString);
            await connection.OpenAsync();
            return connection.State == System.Data.ConnectionState.Open;
        }
        catch (Exception EX)
        {
            return false;
        }
    }
}