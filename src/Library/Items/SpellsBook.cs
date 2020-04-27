using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook
    {
        private IList<ISpell> availableSpells = new List<ISpell>();
        
        public void AddSpell(ISpell spell)
        {
            this.availableSpells.Add(spell);
        }

        public void RemoveSpell(ISpell spell)
        {
            this.availableSpells.Remove(spell);
        }

        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.availableSpells)
                {
                    value += spell.AttackValue();
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.availableSpells)
                {
                    value += spell.DefenseValue();
                }
                return value;
            }
        }
    }
}