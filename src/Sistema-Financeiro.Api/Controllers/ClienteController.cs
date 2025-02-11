using Microsoft.AspNetCore.Mvc;

namespace Sistema_Financeiro.Api.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
