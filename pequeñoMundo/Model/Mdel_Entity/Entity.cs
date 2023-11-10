using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pequeñoMundo.Interactuable;
using pequeñoMundo.Interfaces;
using pequeñoMundo.Static;

namespace pequeñoMundo.Model
{
    internal class Entity: IInteractable
    {
        int Id;
        static int ContId=0;
        string Name;
        IKingdom Kingdom;
        List<IEnvironment> Environment;
        IDiet Diet;
        int MaxEnergy;
        int CurrentEnergy;
        int MaxLife;
        int CurrentLife;
        int AttackPoints;
        int DefensePoints;
        int AttackRange;

        #region Constructores

        public Entity(int id, string name, IKingdom kingdom, List<IEnvironment> environment, IDiet diet, int energyMax, int energyActual,
            int lifeMax, int lifeActual, int attackPoints, int defensePoints, int attackRange)
        {
            Id = id;
            Name = name;
            Kingdom = kingdom;
            Environment = environment;
            Diet = diet;
            MaxEnergy = energyMax;
            CurrentEnergy = energyActual;
            MaxLife = lifeMax;
            CurrentLife = lifeActual;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            AttackRange = attackRange;
        }

        public Entity(string name, IKingdom kingdom, List<IEnvironment> environment, IDiet diet, int energyMax,
          int lifeMax, int attackPoints, int defensePoints, int attackRange)
        {
            Id = ContId++;
            NOMBRE = name;
            KINGDOM = kingdom;
            ENVIRONMENT = environment;
            DIET = diet;
            MAXENERGY = energyMax;
            CurrentEnergy = energyMax;
            MAXLIFE = lifeMax;
            CurrentLife = lifeMax;
            ATTACKPOINTS = attackPoints;
            DEFENSEPOINTS = defensePoints;
            ATTACKRANGE = attackRange;
        }
        #endregion


        #region Propiedades y validaciones


        public int ID
        {
            get { return Id; }
        }
        public string NOMBRE
        {
            get { return Name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                Name = value;
            }
        }

        public IKingdom KINGDOM
        {
            get { return Kingdom; }
            set
            {
                if (value != null)
                    Kingdom = value;
                else
                    throw new ArgumentNullException("Debe seleccionar un REINO.");
            }
        }
        public string NameEnvironment
        {
            get
            {
                string listNameEnvironment = string.Empty;

                foreach(var e in Environment)
                {
                    listNameEnvironment = string.Join(" ,", Environment);
                }
                return listNameEnvironment;
            }
        }
        public List<IEnvironment> ENVIRONMENT
        {
            get { return Environment; }
            set
            {
                if (value != null)
                    Environment = value;
                else
                    throw new ArgumentNullException("Debe seleccionar al menos un HABITAT.");
            }
        }
        public IDiet DIET
        {
            get { return Diet; }
            set
            {
                if (value != null)
                    Diet = value;
                else
                    throw new ArgumentNullException("Debe seleccionar una DIETA.");
            }
        }

        public int MAXENERGY
        {
            get { return MaxEnergy; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("La energía máxima debe ser mayor que 0.");
                else
                    MaxEnergy = value;

            }
        }
        public int CURRENTENERGY
        {
            set { if (value > 0) CurrentEnergy = value; }
            get => CurrentEnergy;
        }
        public int MAXLIFE
        {
            get { return MaxLife; }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("La energía máxima debe ser mayor que 0.");
                else
                    MaxLife = value;
            }
        }
        public int CURRENTLIFE
        {
            set { if (value > 0) CurrentLife = value; }
            get => CurrentLife;
        }

        public int ATTACKPOINTS
        {
            get { return AttackPoints; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("La energía máxima debe ser mayor que 0.");
                else
                    AttackPoints = value;
            }

        }

        public int DEFENSEPOINTS
        {
            get { return DefensePoints; }
            set
            {
                if (value < 0)

                    throw new ArgumentOutOfRangeException("La energía máxima debe ser mayor que 0.");
                else
                    DefensePoints = value;
            }

        }
        public int ATTACKRANGE
        {
            get { return AttackRange; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("La energía máxima debe ser mayor que 0.");
                else
                    AttackRange = value;
            }

        }
        #endregion


        #region Métodos

        public IDiet GetDiet()
        {
            return DIET;
        }
        public bool Eat(IFood food)
        {
              if (Diet.CanEat(food))
                CURRENTENERGY += food.GetCalories();
              return Diet.CanEat(food);
        }
        public bool MoveThrough(ITerrain terrain)
        {
            if (ENVIRONMENT.Count > 0)
            {
                IEnvironment firstEnvironment = ENVIRONMENT[0];

                return firstEnvironment.IsYourEnvironment(terrain);
            }
            else
            {
                return false;
            }
        }
        
        public int Attack()
        {
            return AttackPoints += Dice.TrowDice(6);
        }
        public int BeingAttacked()
        {
            return DefensePoints += Dice.TrowDice(6);
        }
        public void ReceiveDamage(int attack)
        {
            int damageReceived = Math.Max(0, attack - DefensePoints);
            CurrentLife -= damageReceived;
        }
        public void UseItem(Item item)
        {
            item.Interact(this);
        }

        public void Interact(Entity entity)
        {


        }
        
        public int Rest()
        {
            return CURRENTENERGY += MAXENERGY / 2;
        }
        public IEnvironment GetEnvironment()
        {
            return (IEnvironment)ENVIRONMENT;
        }


        public override string? ToString()
        {
            return $"{Name}, {Kingdom}, {NameEnvironment}, {Diet}";
        }

       

        #endregion
    }








}

