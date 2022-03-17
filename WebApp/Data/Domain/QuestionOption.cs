namespace WebApp.Data.Domain
{
    public class QuestionOption:BaseEntity
    {
        public string OptionText { get; set; }
        public virtual Question Question { get; set; }
    }
}
