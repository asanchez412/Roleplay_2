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

            Knight knight = new Knight("Knight");
            Sword sword = new Sword();
            Armor armor = new Armor();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();
            knight.EquipAttackItem(sword);
            knight.EquipDefensiveItem(armor);
            knight.EquipDefensiveItem(helmet);
            knight.EquipDefensiveItem(shield);

            Dwarf gimli = new Dwarf("Gimli");
            Axe axe = new Axe();
            Helmet helmet1 = new Helmet();
            gimli.EquipAttackItem(axe);
            gimli.EquipDefensiveItem(helmet1);

            // Gandalf ataca a Gimli

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");
            Console.WriteLine($"{gandalf.Name} attacks {gimli.Name} with ⚔️ {gandalf.GetTotalAttackValue()}");

            gimli.ReceiveAttack(gandalf.GetTotalAttackValue());

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");

            // Knight ataca a Gimli

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");
            Console.WriteLine($"{knight.Name} attacks {gimli.Name} with ⚔️ {knight.GetTotalAttackValue()}");

            gimli.ReceiveAttack(knight.GetTotalAttackValue());

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");
        }
    }
}
