namespace DAL.GestionDocente;

public class DocenteException : Exception
{
    public int ErrorCode { get; }

    public DocenteException(string message, int errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }
}