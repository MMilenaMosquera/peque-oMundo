using pequeñoMundo.Controllers;
using pequeñoMundo.Interfaces;
using pequeñoMundo.Model;
using pequeñoMundo.Model.Model_Kingdom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pequeñoMundo.Data
{
    internal class EntityRepository
    {

        private List<Entity> entities = new List<Entity>();

        Random random = new Random();

        
        public EntityRepository() { 
            for (int i = 1; i <= 10; i++)
            {
                IKingdom randomKingdom = ControllerEntity.Instance.GetKingdoms()[random.Next(ControllerEntity.Instance.GetKingdoms().Count)];
                IEnvironment randomEnvironment = ControllerEntity.Instance.GetEnviroment()[random.Next(ControllerEntity.Instance.GetEnviroment().Count)];
                IDiet randomDiet = ControllerEntity.Instance.GetDiet()[random.Next(ControllerEntity.Instance.GetDiet().Count)];

                int maxEnergy = random.Next(50, 100); 
                int maxLife = random.Next(50, 100); 
                int attackPoints = random.Next(30, 100); 
                int defensePoints = random.Next(50, 100); 
                int attackRange = random.Next(0, 1); 

                Entity entity = new Entity($"Entidad {i}", randomKingdom, new List<IEnvironment> { randomEnvironment }, randomDiet, maxEnergy, maxLife, attackPoints, defensePoints, attackRange);

                entities.Add(entity);
            }



        }
        public List<Entity> GetEntities()
        {
            return entities;
        }

        public Entity GetRandomEntity()
        {
            if (entities.Count == 0)
            {
                return null;
            }

            Random random = new Random();
            int randomIndex = random.Next(entities.Count);

            return entities[randomIndex];
        }

        public List<string> GetEntityNames()
        {
            return entities.Select(entity => entity.NOMBRE).ToList();
        }
    }
}
