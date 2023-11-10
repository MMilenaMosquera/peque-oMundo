using pequeñoMundo.Interfaces;
using pequeñoMundo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Interactuable.Strategy
{
    internal class IncreaseEnergyPoints : IItemStrategy
    { 
        public void ApplyEffect(Entity entity)
        {
            entity.CURRENTENERGY += 30;
        }

        public override string? ToString()
        {
            return "Incrementa puntos de Energia";
        }
    }
}
