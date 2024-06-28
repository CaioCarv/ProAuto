using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectProAuto.Models;
using System.Threading.Tasks;

namespace ProjectProAuto.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoAssociado = HttpContext.Session.GetString("sessaoAssociadoLogado");
            if (string.IsNullOrEmpty(sessaoAssociado)) return null;
            AssociadoModel associado = JsonConvert.DeserializeObject<AssociadoModel>(sessaoAssociado);
            return View(associado);
        }
    }
}
