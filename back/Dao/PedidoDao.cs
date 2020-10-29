using ProjetoSDQwertyDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSDQwertyDashboard.Dao
{
    public class PedidoDao : IData<Pedido>
    {
        private static List<Pedido> Pedidos;

        public Pedido Get(int id)
        {
            fill();
            return Pedidos.FirstOrDefault(p => p.Id == id);
        }

        public List<Pedido> GetAll()
        {
            fill();
            return Pedidos.ToList();
        }

        public void Save(Pedido e)
        {
            fill();
            Pedidos.Add(e);
        }

        private void fill()
        {
            if (Pedidos != null) return;
            Pedidos = new List<Pedido>();
            for (int i = 0; i < 10; i++)
            {
                List<Produto> produtos = new List<Produto>();
                for (int p = 0; p < new Random().Next(1, 10); p++)
                {
                    produtos.Add(new ProdutoDao().GetAll()[new Random().Next(0, 9)]);
                }
                Pedidos.Add(new Pedido(i, DateTime.Now.AddDays(-i), new ClienteDao().GetAll()[new Random().Next(0, 9)], produtos, i * 20, "Pendente"));
            }
        }
    }
}
