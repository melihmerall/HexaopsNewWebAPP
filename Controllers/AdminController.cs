using HexaopsNewWebAPP.Database.Context;
using HexaopsNewWebAPP.Database.DTOs;
using HexaopsNewWebAPP.Entities;
using HexaopsNewWebAPP.Entities.About;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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




        #region OGUZ - mainService 


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

        // oğuz service assoc için update işlemini oluştur.

        [Route("/admin/serviceList")]
        [HttpGet]
        public IActionResult ServiceList()

        {
            var serviceList = _context.MainServices.Include(x => x.ServiceAssoc).ToList();


            return View(serviceList);
        }


        // MAİNSERVİCE VERİ EKLEME //

        [Route("/admin/createService")]
        [HttpGet]
        public IActionResult CreateService()

        {

            return View();
        }

        [Route("/admin/createService")]
        [HttpPost]
        public IActionResult CreateService(MainService mainService)
        {
            _context.MainServices.Add(mainService);
            _context.SaveChanges();
            return RedirectToAction("serviceList");

        }

        [Route("/admin/CreateServiceAssoc/")]
        [HttpGet]
        public IActionResult CreateServiceAssoc()
        {
            return View();
        }


        [Route("/admin/CreateServiceAssoc/")]
        [HttpPost]
        public IActionResult CreateServiceAssoc(MainServiceAssoc mainServiceAssoc)
        {
            _context.MainServiceAssocs.Add(mainServiceAssoc);
            _context.SaveChanges();
            return RedirectToAction("serviceList");

        }








        #endregion


        #region OGUZ - mainPartner



        [Route("/admin/Partner/{id?}")]
        [HttpGet]
        public IActionResult Partner(int id)
        {
            var mainPartner = _context.MainPartners.Include(x => x.MainPartnerAssocs).Where(x => x.Id == id).FirstOrDefault();

            return View(mainPartner);
        }


        [Route("/admin/Partner/{id?}")]
        [HttpPost]
        public IActionResult Partner(MainPartner model)
        {

            var main = _context.MainPartners.Where(x => x.Id == model.Id).FirstOrDefault();
            main.Slogan = model.Slogan;

            _context.MainPartners.Update(main);
            _context.SaveChanges();

            return RedirectToAction("PartnerList");
        }


        [Route("/admin/PartnerList")]
        [HttpGet]
        public IActionResult PartnerList()
        {

            var partnerList = _context.MainPartners.Include(x => x.MainPartnerAssocs).ToList();

            return View(partnerList);

        }


        // MAİNPARTNER VERİ EKLEME


        [Route("/admin/CreatePartner")]
        [HttpGet]
        public IActionResult CreatePartner()
        {
            return View();
        }



        [Route("/admin/CreatePartner")]
        [HttpPost]
        public IActionResult CreatePartner(MainPartnerAssoc mainPartnerAssoc)
        {
            var entity = _context.MainPartners.FirstOrDefault();
            mainPartnerAssoc.MainPartner = entity;
            _context.MainPartnerAssocs.Add(mainPartnerAssoc);
            _context.SaveChanges();
            return RedirectToAction("partnerList");
        }



        #endregion




        #region OGUZ - mainFeatures


        [Route("/admin/Features/{id?}")]
        [HttpGet]
        public IActionResult Features(int id)
        {
            var mainFeatures = _context.MainFeatures.Include(x => x.FeatureAssocs).Where(x => x.Id == id).FirstOrDefault();
            return View();

        }

        [Route("/admin/Features/{id?}")]
        [HttpPost]
        public IActionResult Features(MainFeatures model)
        {
            var main = _context.MainFeatures.Where(x => x.Id == model.Id).FirstOrDefault();

            main.Bigtitle = model.Bigtitle;
            main.Bigdescription = model.Bigdescription;

            _context.MainFeatures.Update(main);
            _context.SaveChanges();

            return RedirectToAction("featuresList");
        }

        [Route("/admin/FeaturesList")]
        [HttpGet]
        public IActionResult FeaturesList()
        {
            var featuresList = _context.MainFeatures.Include(x => x.FeatureAssocs).ToList();

            return View(featuresList);
        }


        //                 MAİNFEATURES VERİ EKLEME               //

        [Route("/admin/CreateFeatures/")]
        [HttpGet]
        public IActionResult CreateFeatures()
        {
            return View();
        }


        [Route("/admin/CreateFeatures/")]
        [HttpPost]
        public IActionResult CreateFeatures(MainFeatures mainFeature)
        {
            _context.MainFeatures.Add(mainFeature);
            _context.SaveChanges();
            return RedirectToAction("FeaturesList");

        }

        #endregion




        #region ELA - AboutHowWeWork

        [Route("/admin/HowWeWork/{id?}")]
        [HttpGet]
        public IActionResult UpdateAboutHowWeWork(int id)
        {
            var aboutHowWeWorks = _context.AboutHowWeWorks.Include(x => x.AboutHowWeWorkAssocs).Where(x => x.Id == id).FirstOrDefault();

            return View(aboutHowWeWorks);
        }

        [Route("/admin/HowWeWork/{id?}")]
        [HttpPost]
        public IActionResult UpdateAboutHowWeWork(AboutHowWeWork model)
        {
            var about = _context.AboutHowWeWorks.Where(x => x.Id == model.Id).FirstOrDefault();

            about.Title = model.Title;
            about.HeaderTitle = model.HeaderTitle;


            _context.AboutHowWeWorks.Update(about);
            _context.SaveChanges();

            return RedirectToAction("HowWeWorkList");
        }

        [Route("/admin/HowWeWorkList")]
        [HttpGet]
        public IActionResult HowWeWorkList()
        {
            var howWeWorkList = _context.AboutHowWeWorks.ToList();


            return View(howWeWorkList);
        }

        [HttpGet]
        [Route("/admin/CreateAboutHowWeWork")]
        public IActionResult CreateAboutHowWeWork()
        {
            return View();
        }

        [HttpPost]
        [Route("/admin/CreateAboutHowWeWork")]

        public IActionResult CreateAboutHowWeWork(AboutHowWeWorkDto model)
        {
            if (model.IsTitleApproved == false)
            {
                model.Title = "";
            }
            var aboutHowWeWork = new AboutHowWeWork()
            {
                HeaderTitle = model.HeaderTitle,
                Title = model.Title,
            };

            _context.AboutHowWeWorks.Add(aboutHowWeWork);
            _context.SaveChanges();

            return RedirectToAction("HowWeWorkList");
        }


        [Route("/admin/DeleteHowWeWork/{id?}")]
        public IActionResult DeleteAboutHowWeWork(int id)
        {

            var entity = _context.AboutHowWeWorks.Where(x => x.Id == id).FirstOrDefault();
            if (entity != null)
            {
                _context.AboutHowWeWorks.Remove(entity);
                _context.SaveChanges();
            }

            return RedirectToAction("HowWeWorkList");
        }


        #endregion
    

        #region Ela - MainFAQ

        [Route("/admin/MainFAQ/{id?}")]
        [HttpGet]
        public IActionResult UpdateMainFAQ(int id)
        {
            var mainFAQs = _context.MainFAQ.Include(x => x.MainFAQAssoc).Where(x => x.Id == id).FirstOrDefault();

            return View(mainFAQs);
        }

        [Route("/admin/MainFAQ/{id?}")]
        [HttpPost]
        public IActionResult UpdateMainFAQ(MainFAQ model)
        {
            var about = _context.MainFAQ.Where(x => x.Id == model.Id).FirstOrDefault();

            about.Title = model.Title;
            about.Description = model.Description;




            _context.MainFAQ.Update(about);
            _context.SaveChanges();

            return RedirectToAction("FAQList");
        }

        [Route("/admin/FAQList")]
        [HttpGet]
        public IActionResult FAQList()
        {
            var FAQList = _context.MainFAQ.ToList();


            return View(FAQList);
        }
        [HttpGet]
        [Route("/admin/CreateMainFAQ")]
        public IActionResult CreateMainFAQ()
        {
            return View();
        }

        [HttpPost]
        [Route("/admin/CreateMainFAQ")]
        public IActionResult CreateMainFAQ(MainFAQ model)
        {
           
            var mainFAQ = new MainFAQ()
            {
                Title = model.Title,
                Description = model.Description
            };

            _context.MainFAQ.Add(mainFAQ);
            _context.SaveChanges();

            return RedirectToAction("FAQList");
        }

        #endregion







    }
}
