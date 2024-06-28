using Microsoft.AspNetCore.Mvc;
using ProjectProAuto.Helper;
using ProjectProAuto.Models;
using ProjectProAuto.Repositorio;

namespace ProjectProAuto.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAssociadoRepositorio _associadoRepositorio;
        private readonly ISessao _sessao;
        public LoginController(IAssociadoRepositorio associadoRepositorio, ISessao sessao)
        {
            _associadoRepositorio = associadoRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            if (_sessao.BuscarSessaoAssociado() != null) return RedirectToAction("Index", "Home");
            return View();
        }

        public IActionResult Sair()
        {   
            HttpContext.Session.Clear();
            _sessao.RemoverSessaoAssociado();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    AssociadoModel associado = _associadoRepositorio.BuscarPorLogin(loginModel.Login);

                    if(associado != null)
                    {
                        if (associado.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoDoAssociado(associado);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Senha inválida.";

                    }
                    TempData["MensagemErro"] = $"CPF inválido.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimoes realizar seu login, tente novamente. (Não utilize caracteres especiais) {erro.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
