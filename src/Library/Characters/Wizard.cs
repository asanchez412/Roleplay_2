using System.Collections.Generic;

namespace RoleplayGame
{
    public class Wizard : Heroes
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
            int result = base.GetTotalAttackValue();
            
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
            int result = base.GetTotalAttackValue();

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