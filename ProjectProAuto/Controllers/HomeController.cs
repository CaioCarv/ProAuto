using Microsoft.AspNetCore.Mvc;
using ProjectProAuto.Models;
using ProjectProAuto.Repositorio;
using ProjectProAuto.Helper;
using System.Diagnostics;

namespace ProjectProAuto.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAssociadoRepositorio _associadoRepositorio;
        private readonly ISessao _sessao;

        public HomeController(IAssociadoRepositorio associadoRepositorio, ISessao sessao)
        {
            _associadoRepositorio = associadoRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            var associadoLogado = _sessao.BuscarSessaoAssociado();

            if (associadoLogado == null)
            {
                // Caso n�o haja associado logado, redirecione para a p�gina de login ou realize outra a��o necess�ria
                return RedirectToAction("Index", "Login");
            }

            return View(associadoLogado);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
