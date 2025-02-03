using QuizPro.Domain.Commons;

namespace QuizPro.Domain.Entities;

public class Topic : Auditable
{
    public string Title { get; set; }
}
