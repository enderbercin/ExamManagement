using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.Domain;

namespace WebApp.Data
{
    public class MyDbRepository:IMyDbRepository
    {
        private readonly MyDbContext _ctx;

        public MyDbRepository (MyDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Exam> DeleteExamAsync(Exam exam)
        {
           _ctx.Exams.Remove(exam);
            await _ctx.SaveChangesAsync();
            return exam;
        }

        public async Task<ExamCategory> DeleteExamCategoryByIdAsync(int examCategoryId)
        {
            var examCategory = _ctx.ExamCategories.Find(examCategoryId);

            _ctx.ExamCategories.Remove(examCategory);
            _ctx.SaveChanges();
            return examCategory;

        }

        public async Task<Question> DeleteQuestionAsync(Question question)
        {
           _ctx.Questions.Remove(question);
            await _ctx.SaveChangesAsync();
            return question;
        }

        public async Task<QuestionCategory> DeleteQuestionCategoryAsync(QuestionCategory questionCategory)
        {
            _ctx.QuestionCategories.Remove(questionCategory);
            await _ctx.SaveChangesAsync();
            return questionCategory;
        }

        public async Task<User> DeleteUserAsync(User user)
        {
            _ctx.Users.Remove(user);
            await _ctx.SaveChangesAsync();
            return user;
        }

        public async Task<List<Exam>> GetAllExamAsync()
        {
            return await _ctx.Exams
                .OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<List<ExamCategory>> GetAllExamCategoryAsync()
        {
          //  return await _ctx.ExamCategories.ToListAsync();
          return await _ctx.ExamCategories
                .OrderBy(p=>p.Name).ToListAsync();
        }

        public async Task<List<Question>> GetAllQuestionsAsync()
        {
            return await _ctx.Questions
                .OrderBy(p=>p.Id).ToListAsync();
        }

        public async Task<List<QuestionCategory>> GetAllQuestionsCategoryAsync()
        {
            return await _ctx.QuestionCategories
                .OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            return await _ctx.Users
                .OrderBy(p=>p.FirstName).ToListAsync();
        }

        public async Task<List<Exam>> GetExamByIdAsync(int examId)
        {
            return await _ctx.Exams
                .Where(p => p.Id == examId).ToListAsync();
        }

        public async Task<List<ExamCategory>> GetExamCategoryByIdAsync(int examCategoryId)
        {
            return await _ctx.ExamCategories
                .Where(p=>p.Id == examCategoryId).ToListAsync();
        }

        public async Task<List<Exam>> GetExamsByCategoryIdAsync(int id)
        {
            return await _ctx.Exams.Where(x => x.ExamCategory.Id == id).ToListAsync();
        }

        public async Task<List<Question>> GetQuestionByIdAsync(int questionId)
        {
            return await _ctx.Questions
                .Where(p=>p.Id==questionId).ToListAsync();
        }

        public async Task<List<QuestionCategory>> GetQuestionCategoryByIdAsync(int QuestionCategoryId)
        {
            return await _ctx.QuestionCategories
                .Where(p => p.Id == QuestionCategoryId)
                .ToListAsync();
        }
        

        public async Task<List<User>> GetUserByIdAsync(int userId)
        {
            return await _ctx.Users
                .Where(p=>p.Id == userId.ToString()).ToListAsync();
        }

        public async Task<Exam> InsertExamAsync(Exam exam)
        {
            _ctx.Exams.Add(exam);
            await _ctx.SaveChangesAsync();
            return exam;
        }

        public async Task<ExamCategory> InsertExamCategoryAsync(ExamCategory examCategory)
        {
            _ctx.ExamCategories.Add(examCategory);
            await _ctx.SaveChangesAsync();
            return examCategory;
        }

        public async Task<Question> InsertQuestionAsync(Question question)
        {
            _ctx.Questions.Add(question);
            await _ctx.SaveChangesAsync();
            return question;
        }

        public async Task<QuestionCategory> InsertQuestionCategoryAsync(QuestionCategory questionCategory)
        {
            _ctx.QuestionCategories.Add(questionCategory);
            await _ctx.SaveChangesAsync();
            return questionCategory;
        }

        public async Task<User> InsertUserAsync(User user)
        {
            _ctx.Users.Add(user);
            await _ctx.SaveChangesAsync();
            return user;
        }

        public async Task<Exam> UpdateExamAsync(Exam exam)
        {
                _ctx.Exams.Update(exam);
                await _ctx.SaveChangesAsync();
                return exam;
        }

        public async Task<ExamCategory> UpdateExamCategoryAsync(ExamCategory examCategory)
        {
            _ctx.ExamCategories.Update(examCategory);
            await _ctx.SaveChangesAsync();
            return examCategory;
        }

        public async Task<Question> UpdateQuestionAsync(Question question)
        {
            _ctx.Questions.Update(question);
            await _ctx.SaveChangesAsync();
            return question;
        }

        public async Task<QuestionCategory> UpdateQuestionCategoryAsync(QuestionCategory questionCategory)
        {
           _ctx.QuestionCategories.Update(questionCategory);
            await _ctx.SaveChangesAsync();
            return questionCategory;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _ctx.Users.Update(user);
            await _ctx.SaveChangesAsync();
            return user;
        }
    }
}
