using System.Collections.Generic;

namespace RoleplayGame
{
    public class Wizard : Character
    {
        public Wizard(string name) : base(name) { }

        private IList<SpellsBook> spellsBookList = new List<SpellsBook>();

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

        public override int GetTotalAttackValue()
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

        public override int GetTotalDefenseValue()
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
    }
}