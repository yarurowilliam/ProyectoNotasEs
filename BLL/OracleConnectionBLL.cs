using DAL;

namespace BLL;

public class OracleConnectionBLL
{
    private readonly OracleConnectionDAL _oracleConnectionDAL;

    public OracleConnectionBLL()
    {
        _oracleConnectionDAL = new OracleConnectionDAL();
    }

    public Task<bool> TestConnectionAsync()
    {
        return _oracleConnectionDAL.TestConnectionAsync();
    }
}