using System.Collections.Generic;

namespace RoleplayGame

{
    public class Character : ICharacter
    {
        private int health = 100;

        public Character(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int Health 
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        protected IList<IDefensiveItems> defensiveEquipment = new List<IDefensiveItems>();

        protected IList<IAttackItems> offensiveEquipment = new List<IAttackItems>();

        protected IList<IMixedItems> mixedEquipment = new List<IMixedItems>();

        public void EquipDefensiveItem(IDefensiveItems defensiveItem)
        {
            this.defensiveEquipment.Add(defensiveItem);
        }

        public void UnEquipDefensiveItem(IDefensiveItems defensiveItem)
        {
            this.defensiveEquipment.Remove(defensiveItem);
        }

        public void EquipAttackItem(IAttackItems attackItem)
        {
            this.offensiveEquipment.Add(attackItem);
        }

        public void UnEquipAttackItem(IAttackItems attackItem)
        {
            this.offensiveEquipment.Remove(attackItem);
        }

        public void EquipMixedItem(IMixedItems mixedItem)
        {
            this.mixedEquipment.Add(mixedItem);
        }

        public void UnEquipMixedItem(IMixedItems mixedItem)
        {
            this.mixedEquipment.Remove(mixedItem);
        }

        public virtual int GetTotalAttackValue()
        {   
            int result = 0;
            foreach (IAttackItems attackItem in offensiveEquipment)
            {
                result += attackItem.AttackValue();
            }
            return result;
        }

        public virtual int GetTotalDefenseValue()
        {
            int result = 0;
            foreach (IDefensiveItems defensiveItem in defensiveEquipment)
            {
                result += defensiveItem.DefenseValue();
            }
            return result;
        }

        public int ReceiveAttack(int damage)
        {
            if (damage - this.GetTotalDefenseValue() > 0)
            {
                this.Health = this.Health - (damage - this.GetTotalDefenseValue());
                return this.Health;
            }
            else
            {
                return this.Health;
            }
        }

        public virtual int Cure()
        {
            return this.Health = 100;
        }

    }
}