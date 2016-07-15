using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBasic.Controllers {
	public class BlogController : Controller {
		public IActionResult Index() {
			return View();
		}
	}
}