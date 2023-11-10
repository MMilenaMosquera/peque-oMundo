using pequeñoMundo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Model.Model_Habitat
{
    internal class Terrestrial: IEnvironment
    {
        public bool IsYourEnvironment(ITerrain terrain)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Terrestre";
        }

    }
}
