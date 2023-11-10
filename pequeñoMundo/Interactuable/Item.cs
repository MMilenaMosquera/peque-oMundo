using pequeñoMundo.Interactuable.Strategy;
using pequeñoMundo.Interfaces;
using pequeñoMundo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pequeñoMundo.Interactuable
{
    internal class Item: IInteractable
    {
        int Id;
        static int ContId = 0;
        IItemStrategy Strategy;

        public Item(IItemStrategy strategy)
        {
            Id = ContId++;
            STRATEGY = strategy;
        }

        public IItemStrategy STRATEGY
         {
             set => Strategy = value;
             get => Strategy;
         }

        public int ID
        {
            get { return Id; }
        }
        public void Interact(Entity entity)
        {
            Strategy.ApplyEffect(entity);
        }


        public override string? ToString()
        {
            return $"{Strategy}";
        }
    }
}

