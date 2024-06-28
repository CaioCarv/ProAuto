using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ProjectProAuto.Models;

namespace ProjectProAuto.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;
        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public AssociadoModel BuscarSessaoAssociado()
        {
            string sessaoAssociado = _httpContext.HttpContext.Session.GetString("sessaoAssociadoLogado");

            if (string.IsNullOrEmpty(sessaoAssociado)) return null;

            return JsonConvert.DeserializeObject<AssociadoModel>(sessaoAssociado);
        }

        public void CriarSessaoDoAssociado(AssociadoModel associado)
        {
            string valor = JsonConvert.SerializeObject(associado);
            _httpContext.HttpContext.Session.SetString("sessaoAssociadoLogado", valor);
        }

        public void RemoverSessaoAssociado()
        {
            _httpContext.HttpContext.Session.Remove("sessaoAssociadoLogado");
        }
    }
}
