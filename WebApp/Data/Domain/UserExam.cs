using System;

namespace WebApp.Data.Domain
{
    public class UserExam:BaseEntity
    {
        public virtual Exam Exam { get; set; }
        public virtual User User { get; set;}
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int GradeScore { get; set; }
    }
}
