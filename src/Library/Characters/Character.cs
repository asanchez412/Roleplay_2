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

        protected IList<Items> items = new List<Items>();

        public void EquipItem(Items item)
        {
            this.items.Add(item);
        }

        public void UnEquipItem(Items item)
        {
            this.items.Remove(item);
        }

        public virtual int GetTotalAttackValue()
        {   
            int result = 0;
            foreach (Items item in items)
            {
                result += item.AttackValue();
            }
            return result;
        }

        public virtual int GetTotalDefenseValue()
        {
            int result = 0;
            foreach (Items item in items)
            {
                result += item.DefenseValue();
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