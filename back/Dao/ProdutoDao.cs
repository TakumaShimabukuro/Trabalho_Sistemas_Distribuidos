using ProjetoSDQwertyDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSDQwertyDashboard.Dao
{
    public class ProdutoDao : IData<Produto>
    {
        private static List<Produto> Produtos;

        public ProdutoDao()
        {
            Produtos = new List<Produto>();
            for (int i = 0; i < 10; i++)
            {
                Produtos.Add(new Produto(i, $"Produto {i}", new Random().Next(1, 200), new Random().Next(1, 200), "Ativo"));
            }
        }

        public Produto Get(int id)
        {
            return Produtos.FirstOrDefault(p => p.Id == id);
        }

        public List<Produto> GetAll()
        {
            return Produtos.ToList();
        }

        public void Save(Produto e)
        {
            Produtos.Add(e);
        }

        private void fill()
        {
            if (Produtos != null) return;
            Produtos = new List<Produto>();
            for (int i = 0; i < 10; i++)
            {
                Produtos.Add(new Produto(i, $"Produto {i}", new Random().Next(1, 200), new Random().Next(1, 200), "Ativo"));
            }
        }
    }
}
