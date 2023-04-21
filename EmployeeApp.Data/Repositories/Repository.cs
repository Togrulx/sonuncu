using EmployeeApp.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Data.Repositories
{
    public class Repository<T> where T : BaseModels
    {
        private readonly List<T> _item = new List<T>();

        public void Create(T model)
        {
            _item.Add(model);
        }

        public void Delete(T model)
        {
            _item.Remove(model);
        }

        public T Get(Func<T, bool> func)
        {
            return _item.FirstOrDefault(func);

        }

        public List<T> GetAll()
        {
            return _item;
        }



    }
}
