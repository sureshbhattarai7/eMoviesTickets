using eMoviesTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMoviesTickets.Controllers
{
    public class DirectorController : Controller
    {
        private readonly AppDbContext _context;

        public DirectorController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allDirectors = await _context.Directors.ToListAsync();
            return View(allDirectors);
        }
    }
}
