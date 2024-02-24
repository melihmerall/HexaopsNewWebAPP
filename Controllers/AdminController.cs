using HexaopsNewWebAPP.Database.Context;
using Microsoft.AspNetCore.Mvc;

namespace HexaopsNewWebAPP.Controllers
{
    public class AdminController : Controller
    {
        private readonly SqlServerContext _context;

        public AdminController(SqlServerContext context)
        {
            _context = context;
        }

        [Route("/admin")]
        public IActionResult Index()
        {
            var maintSolutions = _context.MainSolutions.ToList();
            return View(maintSolutions);
        }
    }
}
