using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4.PracticaEF.Logic
{
     public interface IABMLogic<T>
    {
         List<T> GetAll();
        void Add(T newT);

        void Delete(int id);

        void Update(T newT);


    }
}
