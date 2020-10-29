using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSDQwertyDashboard.Models
{
    public class Produto
    {
        public int Id;
        public string Nome;
        public int Quantidade;
        public double Valor;
        public string Status;

        public Produto(int id, string nome, int quantidade, double valor, string status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Quantidade = quantidade;
            this.Valor = valor;
            this.Status = status;
        }
    }
}
