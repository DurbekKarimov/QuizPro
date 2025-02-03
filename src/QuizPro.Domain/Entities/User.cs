using QuizPro.Domain.Commons;

namespace QuizPro.Domain.Entities;

public class User : Auditable
{
    public string FullName { get; set; }
    public  string Password { get; set; }
}
