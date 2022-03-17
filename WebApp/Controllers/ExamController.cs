using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Data.Domain;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ExamController : Controller
    {

        private readonly IMyDbRepository _myDbRepository;
        
        public ExamController(IMyDbRepository myDbRepository )
        {
            _myDbRepository = myDbRepository;
         
        }
        public async Task<IActionResult> Index(int id)
        {
            var exams = new List<Exam>();
            if (id == 0)
                exams = await _myDbRepository.GetAllExamAsync();
            else
                exams = await _myDbRepository.GetExamsByCategoryIdAsync(id);

            var examCategories = await _myDbRepository.GetAllExamCategoryAsync();

            var examModel = new ExamModel()
            {
                Exams = exams,
                ExamCategories = examCategories,
            };

            return View(examModel);
        }
        public async Task<IActionResult> ExamCatList()
        {
            var examCategories = await _myDbRepository.GetAllExamCategoryAsync();

            var examModel = new ExamModel()
            {
                ExamCategories = examCategories,
            };

            return View(examModel);
        }
        public async Task<IActionResult> ExamCatDelete()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ExamCatDelete(int id)
        {
            await _myDbRepository.DeleteExamCategoryByIdAsync(id);
            return View();
        }
        public async Task<IActionResult> ExamCatCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ExamCatCreate(ExamCategory examCat)
        {
            await _myDbRepository.InsertExamCategoryAsync(examCat);
            return View(examCat);
        }

    }
}
