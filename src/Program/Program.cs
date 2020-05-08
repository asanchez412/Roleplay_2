using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            FireSpell spell1 = new FireSpell();
            WindSpell spell2 = new WindSpell();
            book.AddSpell(spell1);
            book.AddSpell(spell2);

            Wizard gandalf = new Wizard("Gandalf");
            RunicStaff staff = new RunicStaff(); 
            gandalf.EquipItem(staff); 
            gandalf.EquipSpellBook(book);

            Knight knight = new Knight("Knight");
            Sword sword = new Sword();
            Armor armor = new Armor();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();
            knight.EquipItem(sword);
            knight.EquipItem(armor);
            knight.EquipItem(helmet);
            knight.EquipItem(shield);

            Dwarf gimli = new Dwarf("Gimli");
            Axe axe = new Axe();
            Helmet helmet1 = new Helmet();
            gimli.EquipItem(axe);
            gimli.EquipItem(helmet1);

            // Gandalf ataca a Gimli

            Console.WriteLine("Gandalf atacará a Gimli");

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");
            Console.WriteLine($"{gandalf.Name} attacks {gimli.Name} with ⚔️ {gandalf.GetTotalAttackValue()}");

            gimli.ReceiveAttack(gandalf.GetTotalAttackValue());

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");

            // Knight ataca a Gimli

            Console.WriteLine("Knight atacará a Gimli");

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");
            Console.WriteLine($"{knight.Name} attacks {gimli.Name} with ⚔️ {knight.GetTotalAttackValue()}");

            gimli.ReceiveAttack(knight.GetTotalAttackValue());

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"{gimli.Name} has ❤️ {gimli.Health}");
        }
    }
}
