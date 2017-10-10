using ProjetoModeloDDD.Domain.Contracts;
using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return context.Produtos.Where(p => p.Nome == nome);
        }
    }
}
