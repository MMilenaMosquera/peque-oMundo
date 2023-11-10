using pequeñoMundo.Interactuable;
using pequeñoMundo.Interfaces;
using pequeñoMundo.Model;
using pequeñoMundo.Model.Model_Diet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Controllers
{
    internal class ControllerItem
    {
        private static ControllerItem instance;
        private List<Item> items = new List<Item>();

        private ControllerItem()

        {
        }

        public static ControllerItem Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ControllerItem();
                }
                return instance;
            }
        }


        #region CRUD

        public List<Item> GetItems()
        {
            
            return items;
        }



        public Item GetItem(int itemId)
        {
            return items.FirstOrDefault(item => item.ID == itemId);
        }

        public void CreateItem(IItemStrategy strategy)
        {
            Item newItem = new Item(strategy);
            items.Add(newItem);
        }

        public void UpdateItem(int itemId, IItemStrategy strategy)
        {
            Item existingItem = GetItem(itemId);
            if (existingItem != null)
            {
                existingItem.STRATEGY = strategy;
            }
        }

        public void DeleteItem(int itemId)
        {
            Item itemToDelete = GetItem(itemId);
            if (itemToDelete != null)
            {
                items.Remove(itemToDelete);
            }
        }

        #endregion





    }

}
