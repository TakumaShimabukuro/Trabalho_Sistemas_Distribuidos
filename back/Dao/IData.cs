using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSDQwertyDashboard.Dao
{
    public interface IData<T>
    {
        public List<T> GetAll();
        public T Get(int id);
        public void Save(T e);
    }
}
