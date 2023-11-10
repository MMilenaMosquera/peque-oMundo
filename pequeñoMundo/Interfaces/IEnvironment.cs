using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Interfaces
{
    internal interface IEnvironment
    {

        bool IsYourEnvironment(ITerrain terrain);
    }
}
