namespace WebApp.Data.Domain
{
    public class UserExamAnswer:BaseEntity
    {
        public virtual UserExam Exam { get; set; }
        public virtual Question Question { get; set; }
        public virtual QuestionOption QuestionOption { get; set; }
        public string AnswerText { get; set; }

    }
}
