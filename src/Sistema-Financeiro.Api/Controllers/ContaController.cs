using Microsoft.AspNetCore.Mvc;

namespace Sistema_Financeiro.Api.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
