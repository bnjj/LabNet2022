using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Taxi : Transport
    {

        public Taxi(int NumeroPasajeros) : base(NumeroPasajeros)
        {

        }




        public override string Report()
        {
            return String.Format("-Taxi con {0} personas.", NumeroPasajeros);
        }

    }
}