using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Data;

namespace Tp5.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext _context;

        public BaseLogic()
        {
            _context = new NorthwindContext();
        }
    }
}
