using ProjectProAuto.Models;

namespace ProjectProAuto.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoAssociado(AssociadoModel associado);
        void RemoverSessaoAssociado();
        AssociadoModel BuscarSessaoAssociado();
    }
}
