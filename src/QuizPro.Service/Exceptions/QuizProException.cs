namespace QuizPro.Service.Exceptions;

public class QuizProException : Exception
{
    public int StatusCode { get; set; }
    public QuizProException(int code, string message) : base(message)
    {
        StatusCode = code;
    }
}
