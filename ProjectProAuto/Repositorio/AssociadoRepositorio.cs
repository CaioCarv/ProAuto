using ProjectProAuto.Data;
using ProjectProAuto.Models;

namespace ProjectProAuto.Repositorio
{
    public class AssociadoRepositorio : IAssociadoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public AssociadoRepositorio(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }
        public AssociadoModel BuscarPorLogin(string login)
        {
            return _bancoContext.AssociadoModel.FirstOrDefault(x => x.CPF == login);
        }
        public AssociadoModel ListarPorId(int Id)
        {
            return _bancoContext.AssociadoModel.FirstOrDefault(x => x.Id == Id);
        }
        public List<AssociadoModel> BuscarTodos()
        {
            return _bancoContext.AssociadoModel.ToList();
        }
        public AssociadoModel Adicionar(AssociadoModel associado)
        {
            _bancoContext.AssociadoModel.Add(associado);
            _bancoContext.SaveChanges();
            return associado;
        }

        public AssociadoModel Atualizar(AssociadoModel associado)
        {
            AssociadoModel associadoDB = ListarPorId(associado.Id);
            if (associadoDB == null) throw new System.Exception("Houve um erro na atualização do endereço!");

            associadoDB.Endereco = associado.Endereco;
            _bancoContext.AssociadoModel.Update(associadoDB);
            _bancoContext.SaveChanges();
            return associadoDB;
        }

    }
}
