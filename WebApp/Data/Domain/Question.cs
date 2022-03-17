namespace WebApp.Data.Domain
{
    public class Question:BaseEntity
    {

        public string QuestionText { get; set; }
        public virtual QuestionCategory Category { get; set; }
        public int TrueOptionId { get; set; }
        public enum QuestionType
        {
            MultipleChoice = 1,
            TextType = 2
        }
    }
}
