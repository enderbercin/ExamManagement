using System.Collections.Generic;
using WebApp.Data.Domain;

namespace WebApp.Models
{
    public class ExamModel
    {
        public List<Exam> Exams { get; set; }
        public  List<ExamCategory> ExamCategories { get; set; }
    }
}
