using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Data.Domain;

namespace WebApp.Data
{
    public partial interface IMyDbRepository
    {
        #region Question Methods
        Task<List<Question>> GetAllQuestionsAsync();// get all Question 
        Task<List<Question>> GetQuestionByIdAsync(int questionId);// get Question 
        Task<Question> DeleteQuestionAsync(Question question); // delete Question
        Task<Question> InsertQuestionAsync(Question question);// create Question
        Task<Question> UpdateQuestionAsync(Question question);// update Question
        #endregion

        #region Exam Methods
        Task<List<Exam>> GetAllExamAsync();// get all Question Categories
        Task<List<Exam>> GetExamsByCategoryIdAsync(int id);
        Task<List<Exam>> GetExamByIdAsync(int examId);// get Question Category
        Task<Exam> DeleteExamAsync(Exam exam); // delete Exam
        Task<Exam> InsertExamAsync(Exam exam);// create Exam
        Task<Exam> UpdateExamAsync(Exam exam);// update Exam
        

        #endregion

        #region Question Categories Methods
        Task<List<QuestionCategory>> GetAllQuestionsCategoryAsync();// get all Question Categories
        Task<List<QuestionCategory>> GetQuestionCategoryByIdAsync(int QuestionCategoryId);// get Question Category
        Task<QuestionCategory> DeleteQuestionCategoryAsync(QuestionCategory questionCategory); // delete Question Category
        Task<QuestionCategory> InsertQuestionCategoryAsync(QuestionCategory questionCategory);// create Question Category
        Task<QuestionCategory> UpdateQuestionCategoryAsync(QuestionCategory questionCategory);// update Question Category
        #endregion 

        #region Exam Categories Methods
        Task<List<ExamCategory>> GetAllExamCategoryAsync();// get all Exams
        Task<List<ExamCategory>> GetExamCategoryByIdAsync(int examCategoryId);// get Exam
        Task<ExamCategory> DeleteExamCategoryByIdAsync(int examCategoryId); // delete Exam
        Task<ExamCategory> InsertExamCategoryAsync(ExamCategory examCategory);// create Exam
        Task<ExamCategory> UpdateExamCategoryAsync(ExamCategory examCategory);// update Exam

        #endregion

        #region Student User Methods 
        Task<List<User>> GetAllUserAsync();// get all Exams
        Task<List<User>> GetUserByIdAsync(int userId);// get Exam
        Task<User> DeleteUserAsync(User user); // delete Question
        Task<User> InsertUserAsync(User user);// create Question
        Task<User> UpdateUserAsync(User user);// update Question
        #endregion
        

    }
}
