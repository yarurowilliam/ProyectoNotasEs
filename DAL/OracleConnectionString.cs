using System;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL;

public class OracleConnectionString
{
    public static string CadenaConexion = "User Id=Administrador;Password=123456;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=34.135.42.7)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));";
}