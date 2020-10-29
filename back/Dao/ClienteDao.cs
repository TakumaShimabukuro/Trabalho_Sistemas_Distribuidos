using ProjetoSDQwertyDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSDQwertyDashboard.Dao
{
    public class ClienteDao : IData<Cliente>
    {
        private static List<Cliente> Clientes;


        public Cliente Get(int id)
        {
            fill();
            return Clientes.FirstOrDefault(p => p.Id == id);
        }

        public List<Cliente> GetAll()
        {
            fill();
            return Clientes.ToList();
        }

        public void Save(Cliente e)
        {
            fill();
            Clientes.Add(e);
        }

        private void fill()
        {
            if (Clientes != null) return;
            Clientes = new List<Cliente>();
            for (int i = 0; i < 10; i++)
            {
                Clientes.Add(new Cliente(i, $"Cliente {i}", $"ABCDEF{i}{i + 2}{i + 3}", $"Rua Exemplo {i} N° {new Random().Next(50, 1000)}", $"9{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}-{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}"));
            }
        }
    }
}
