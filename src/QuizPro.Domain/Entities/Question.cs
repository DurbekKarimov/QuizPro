using QuizPro.Domain.Commons;

namespace QuizPro.Domain.Entities;

public class Question : Auditable
{
    public long TopicId { get; set; }
    public string Text { get; set; }
}
