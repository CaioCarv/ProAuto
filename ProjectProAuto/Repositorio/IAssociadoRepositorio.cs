using ProjectProAuto.Models;

namespace ProjectProAuto.Repositorio
{
    public interface IAssociadoRepositorio
    {
        AssociadoModel BuscarPorLogin(string login);
        List<AssociadoModel> BuscarTodos();
        AssociadoModel ListarPorId(int Id);
        AssociadoModel Adicionar(AssociadoModel associado);
        AssociadoModel Atualizar(AssociadoModel associado);
    }
}
