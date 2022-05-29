using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Bus : Transport
    {

        public Bus(int NumeroPasajeros) : base(NumeroPasajeros)
        {
        }

        public override string Report()
        {
            return String.Format("-Colectivo con {1} pasajeros.", NumeroPasajeros);
        }

    }
}
