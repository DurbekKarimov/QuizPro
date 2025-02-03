using QuizPro.Domain.Commons;

namespace QuizPro.Domain.Entities;

public class Result : Auditable
{
    public long UserId { get; set; }
    public long TopicId { get; set; }
    public string Score { get; set; }
}
