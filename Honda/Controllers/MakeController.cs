using Honda.Data;
using Microsoft.AspNetCore.Mvc;

namespace Honda.Controllers
{
	public class MakeController : Controller
	{
		private readonly ApplicationDbContext _context;

		public MakeController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()

		{
			return View(_context.Make.ToList());
		}
	}
}
