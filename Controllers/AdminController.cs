using HexaopsNewWebAPP.Database.Context;
using HexaopsNewWebAPP.Entities.About;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HexaopsNewWebAPP.Controllers
{
    public class AdminController : Controller
    {
        private readonly SqlServerContext _context;

        public AdminController(SqlServerContext context)
        {
            _context = context;
        }

        [Route("/admin/{id?}")]
        [HttpGet]
        public IActionResult Index(int id)
        {
            var aboutQuestions = _context.AboutQuestions.Include(x => x.QuestionsAssoc).Where(x => x.Id == id).FirstOrDefault();

            return View(aboutQuestions);
        }

        [Route("/admin/{id?}")]
        [HttpPost]
        public IActionResult Index(AboutQuestions model)
        {
            var about = _context.AboutQuestions.Where(x => x.Id == model.Id).FirstOrDefault();

            about.Title = model.Title;
            about.Descripton = model.Descripton;

            _context.AboutQuestions.Update(about);
            _context.SaveChanges();

            return RedirectToAction("AboutList");
        }

        [Route("/admin/aboutList")]
        [HttpGet]
        public IActionResult AboutList()
        {
            var aboutList = _context.AboutQuestions.ToList();


            return View(aboutList);
        }

    }
}
