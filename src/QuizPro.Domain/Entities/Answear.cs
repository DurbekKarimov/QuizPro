using QuizPro.Domain.Commons;

namespace QuizPro.Domain.Entities;

public class Answear : Auditable
{
    public long QuestionId { get; set; }
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
}
