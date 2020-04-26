using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff(); 
            gandalf.EquipMixedItem(staff); 
            gandalf.EquipSpellBook(book);

            Dwarf gimli = new Dwarf("Gimli");
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            gimli.EquipAttackItem(axe);
            gimli.EquipDefensiveItem(helmet);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.GetTotalAttackValue()}");

            gimli.ReceiveAttack(gandalf.GetTotalAttackValue());

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
