using System.Collections.Generic;

namespace RoleplayGame
{
    public class Dwarf : ICharacter
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        private IList<IDefensiveItems> defensiveEquipment = new List<IDefensiveItems>();

        private IList<IAttackItems> offensiveEquipment = new List<IAttackItems>();

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
            this.offensiveEquipment.Add(attackItem);
        }

        public int GetTotalAttackValue()
        {   
            int result = 0;
            foreach (IAttackItems attackItem in offensiveEquipment)
            {
                result += attackItem.AttackValue();
            }
            return result;
        }

        public int GetTotalDefenseValue()
        {
            int result = 0;
            foreach (IDefensiveItems defensiveItem in defensiveEquipment)
            {
                result += defensiveItem.DefenseValue();
            }
            return result;
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int damage)
        {
            if (damage - GetTotalDefenseValue() > 0)
            {
                this.Health = this.Health - damage;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}