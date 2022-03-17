using System;

namespace WebApp.Data.Domain
{
    public class Exam : BaseEntity
    {
        public virtual ExamCategory ExamCategory { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public int SuccessGrade { get; set; }

    }
}
