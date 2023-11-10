using pequeñoMundo.Interfaces;
using pequeñoMundo.Model;
using pequeñoMundo.Model.Model_Diet;
using pequeñoMundo.Model.Model_Habitat;
using pequeñoMundo.Model.Model_Kingdom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Controllers
{
    internal class ControllerEntity
    {
        private static List<Entity> entities = new List<Entity>();
        private static ControllerEntity instance;

        private ControllerEntity()
        {
        }

        public static ControllerEntity Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ControllerEntity();
                }
                return instance;
            }
        }


        #region CRUD Entity
        public List<Entity> GetEntities() { 
        
            return entities;
        }

        public Entity CreateEntity(string nombre, IKingdom kingdom, List<IEnvironment> habitat, IDiet diet, int maxEnergy, int maxLife, int attackPoints, int defensePoints, int attackRange)
        {
          
            Entity entity = new Entity( nombre, kingdom, habitat, diet, maxEnergy, maxLife, attackPoints, defensePoints, attackRange);
            entities.Add(entity);
            return entity;
        }

        public Entity GetEntity(int id)
        {
            var entity = entities.FirstOrDefault(e => e.ID == id);
           
            if (entity == null)
            {
                throw new InvalidOperationException("Entidad no encontrada.");
            }
            return entity;
        }

        public void UpdateEntity(int id, string nombre, IKingdom kingdom, List<IEnvironment> habitat, IDiet diet, int maxEnergy, int maxLife, int attackPoints, int defensePoints, int attackRange)
        {
            var entidad = GetEntity(id);

            entidad.NOMBRE = nombre;
            entidad.KINGDOM = kingdom;
            entidad.ENVIRONMENT = habitat;
            entidad.DIET = diet;
            entidad.MAXENERGY = maxEnergy;
            entidad.MAXLIFE = maxLife;
            entidad.ATTACKPOINTS = attackPoints;
            entidad.ATTACKRANGE = attackRange;
            entidad.DEFENSEPOINTS = defensePoints;

        }

        public void DeleteEntity(int id)
        {
            var entity = GetEntity(id);
            entities.Remove(entity);
        }


        #endregion

        #region Metodos entidad
        public  void Fight(Entity attacker, Entity target)
        {
          
            int attackerAttack = attacker.Attack();
            int targetDefense = target.BeingAttacked();

            target.ReceiveDamage(attackerAttack);

            if (targetDefense > attackerAttack)
            {
                attacker.ReceiveDamage(targetDefense);
                MessageBox.Show($"¡El Jugador 2 ha ganado la pelea! con: {targetDefense}puntos ");

            }
            else
            {
                attacker.ReceiveDamage(attackerAttack);
                MessageBox.Show($"¡El Jugador 1 ha ganado la pelea! con: {attackerAttack}puntos");
            }
        }
        public Entity GetRandomEntity()
        {
            Random random = new Random();
            int randomIndex = random.Next(entities.Count);
            return entities[randomIndex];
        }
        #endregion
        #region Interfaces 

        public List<IKingdom> GetKingdoms()
        {
            List<IKingdom> kingdoms = new List<IKingdom>
                {new Alien(),new Animal(),new Machines()};

            return kingdoms;
        }

        public List<IEnvironment> GetEnviroment()
        {
            List<IEnvironment> environment = new List<IEnvironment>
                {new Acuatic(),new Aerial(),new Terrestrial()};

            return environment;
        }

        public List<IDiet> GetDiet()
        {
            List<IDiet> diet = new List<IDiet>
                {new Carnivore(),new Herbivorous(),new Omnivorous()};

            return diet;
        }
        #endregion
    }

}
