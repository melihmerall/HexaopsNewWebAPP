using HexaopsNewWebAPP.Database.Context;
using HexaopsNewWebAPP.Entities;
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




        // OĞUZ

        [Route("/admin/Service/{id?}")]
        [HttpGet]
        public IActionResult Service(int id)
        {
            var mainService = _context.MainServices.Include(x => x.ServiceAssoc).Where(x => x.Id == id).FirstOrDefault();

            return View(mainService);

        }

        [Route("/admin/Service/{id?}")]
        [HttpPost]
        public IActionResult Service(MainService model)
        {
            var main = _context.MainServices.Where(x => x.Id == model.Id).FirstOrDefault();
            main.Title = model.Title;

            _context.MainServices.Update(main);
            _context.SaveChanges();


            return RedirectToAction("ServiceList");

        }



        [Route("/admin/serviceList")]
        [HttpGet]
        public IActionResult ServiceList()

        {
            var serviceList = _context.MainServices.Include(x => x.ServiceAssoc).ToList();


            return View(serviceList);
        }

        [Route("/admin/createService")]
        [HttpGet]
        public IActionResult CreateService()

        {
            return View();
        }
        [Route("/admin/createService")]
        [HttpPost]
        public IActionResult CreateService(MainServiceAssoc mainServiceAssoc)
        {
            var entity = _context.MainServices.FirstOrDefault();
            mainServiceAssoc.MainService = entity;
            _context.MainServiceAssocs.Add(mainServiceAssoc);
            _context.SaveChanges();
            return RedirectToAction("serviceList");

        }

        //ELA
        [Route("/admin/HowWeWork/{id?}")]
        [HttpGet]
        public IActionResult Index(int id)
        {
            var aboutHowWeWorks = _context.AboutHowWeWorks.Include(x => x.HowWeWorksAssoc).Where(x => x.Id == id).FirstOrDefault();

            return View(aboutHowWeWorks);
        }

        [Route("/admin/HowWeWork/{id?}")]
        [HttpPost]
        public IActionResult Index(AboutHowWeWorks model)
        {
            var about = _context.AboutHowWeWorks.Where(x => x.Id == model.Id).FirstOrDefault();

            about.Title = model.Title;


            _context.AboutHowWeWorks.Update(about);
            _context.SaveChanges();

            return RedirectToAction("AboutList");
        }

        [Route("/admin/HowWeWorkList")]
        [HttpGet]
        public IActionResult HowWeWorkList()
        {
            var howWeWorkList = _context.AboutHowWeWorks.ToList();


            return View(howWeWorkList);
        }









    }
}