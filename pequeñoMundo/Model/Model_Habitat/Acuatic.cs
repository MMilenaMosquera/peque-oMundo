using pequeñoMundo.Interfaces;
using pequeñoMundo.Model.Model_Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Model.Model_Habitat
{
    internal class Acuatic: IEnvironment
    {
        public bool IsYourEnvironment(ITerrain terrain)
        {
            return terrain is Water; 
        }

        public override string ToString()
        {
            return "Acuatico";
        }

      
    }
}
