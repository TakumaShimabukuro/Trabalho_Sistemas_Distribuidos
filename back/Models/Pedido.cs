using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSDQwertyDashboard.Models
{
    public class Pedido
    {
        public int Id;
        public DateTime Data;
        public Cliente Cliente;
        public List<Produto> Produtos;
        public double Preco;
        public string Status;

        public Pedido(int id, DateTime data, Cliente cliente, List<Produto> produtos, double preco, string status)
        {
            this.Id = id;
            this.Data = data;
            this.Cliente = cliente;
            this.Produtos = produtos;
            this.Preco = preco;
            this.Status = status;
        }
    }
}
