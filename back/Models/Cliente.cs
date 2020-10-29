using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSDQwertyDashboard.Models
{
    public class Cliente
    {
        public int Id;
        public string Nome;
        public string Documento;
        public string Endereco;
        public string Telefone;

        public Cliente(int id, string nome, string documento, string endereco, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Documento = documento;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
    }
}
