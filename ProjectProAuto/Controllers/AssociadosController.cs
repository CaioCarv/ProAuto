using Microsoft.AspNetCore.Mvc;
using ProjectProAuto.Models ;
using ProjectProAuto.Repositorio;

namespace ProjectProAuto.Controllers
{
    public class AssociadosController : Controller
    {
        private readonly IAssociadoRepositorio _associadoRepositorio;
        public AssociadosController(IAssociadoRepositorio associadoRepositorio)
        {
            _associadoRepositorio = associadoRepositorio;
        }
        public IActionResult Index()
        {
            List<AssociadoModel> associados = _associadoRepositorio.BuscarTodos();
            return View(associados);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int Id)
        {
            AssociadoModel associado = _associadoRepositorio.ListarPorId(Id);
            return View(associado);
        }

        [HttpPost]
        public IActionResult Criar(AssociadoModel associado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _associadoRepositorio.Adicionar(associado);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(associado);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastra seu contato, tente novamente. detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(AssociadoModel associado)
        {
            _associadoRepositorio.Atualizar(associado);
            TempData["MensagemSucesso"] = "Endereço alterado com sucesso";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Editar(AssociadoSemSenhaModel associadoSemSenhaModel)
        {
            try
            {
                AssociadoModel associado = null;

                if (ModelState.IsValid)
                {
                    associado = new AssociadoModel()
                    {
                        Id = associadoSemSenhaModel.Id,
                        Endereco = associadoSemSenhaModel.Endereco,
                    };

                    associado = _associadoRepositorio.Atualizar(associado);
                    TempData["MensagemSucesso"] = "Endereço alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(associado);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu endereço, tente novamente. detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }


    }
}
