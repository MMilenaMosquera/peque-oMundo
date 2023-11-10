using pequeñoMundo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Interfaces
{
    internal interface IItemStrategy
    {
        public void ApplyEffect(Entity entity);
    }
}
