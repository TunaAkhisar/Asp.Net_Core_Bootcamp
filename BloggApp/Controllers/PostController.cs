using BloggApp.Data.Concrate.EfCore;
using Microsoft.AspNetCore.Mvc;

namespace BloggApp.Controllers
{
    public class PostController : Controller
    {
        private readonly BlogContext _context;

        public PostController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult Index(){
            return View();
        }
    }
}