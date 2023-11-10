using pequeñoMundo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Model.Model_Diet
{
    internal class Carnivore: IDiet
    {
        public bool CanEat(IFood food)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Carnivoro";
        }

    }
}
