using System.Collections.Generic;

namespace RoleplayGame
{
    public class Wizard : ICharacter
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        private IList<IDefensiveItems> defensiveEquipment = new List<IDefensiveItems>();

        private IList<IAttackItems> offensiveEquipment = new List<IAttackItems>();

        private IList<IMixedItems> mixedEquipment = new List<IMixedItems>();

        private IList<SpellsBook> spellsBookList = new List<SpellsBook>();

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

        public void EquipSpellBook(SpellsBook spellsBook)
        {
            if (spellsBookList.Count == 0)
            {
                this.spellsBookList.Add(spellsBook);
            }
        }

        public void UnEquipSpellBook(SpellsBook spellsBook)
        {
            this.spellsBookList.Remove(spellsBook);
        }

        public int GetTotalAttackValue()
        {
            int result = 0;
            foreach (IAttackItems attackItems in offensiveEquipment)
            {
                result += attackItems.AttackValue();
            }
            foreach (IMixedItems mixedItem in mixedEquipment)
            {
                result += mixedItem.AttackValue();
            }
            if (spellsBookList.Count == 1)
            {
                foreach (SpellsBook spellsBook in spellsBookList)
                {
                    result += spellsBook.AttackValue;
                }
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
            foreach (IMixedItems mixedItem in mixedEquipment)
            {
                result += mixedItem.DefenseValue();
            }
            if (spellsBookList.Count == 1)
            {
                foreach (SpellsBook spellsBook in spellsBookList)
                {
                    result += spellsBook.DefenseValue;
                }
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

        public int Cure()
        {
            return this.Health = 100;
        }
    }
}