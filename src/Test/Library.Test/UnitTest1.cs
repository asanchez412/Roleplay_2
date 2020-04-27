using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class Tests
    {
        [Test]
        public void TestGetTotalAttackValue()
        {
            SpellsBook book = new SpellsBook();
            FireSpell spell1 = new FireSpell();
            book.AddSpell(spell1);

            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff(); 
            gandalf.EquipMixedItem(staff); 
            gandalf.EquipSpellBook(book);
            
            Assert.AreEqual(170,gandalf.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalAttackValueSinItems()
        {
            Wizard gandalf = new Wizard("Gandalf");
            
            Assert.AreEqual(0,gandalf.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalDefenseValue()
        {
            SpellsBook book = new SpellsBook();
            WindSpell spell2 = new WindSpell();
            book.AddSpell(spell2);

            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff(); 
            gandalf.EquipMixedItem(staff); 
            gandalf.EquipSpellBook(book);
            
            Assert.AreEqual(160,gandalf.GetTotalDefenseValue());
        }

        [Test]
        public void TestGetTotalDefenseValueSinItems()
        {
            Wizard gandalf = new Wizard("Gandalf");
            
            Assert.AreEqual(0,gandalf.GetTotalDefenseValue());
        }
        

        [Test]
        public void TestReceiveAttack()
        {
            SpellsBook book = new SpellsBook();
            WindSpell spell2 = new WindSpell();
            book.AddSpell(spell2);

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

            Assert.AreEqual(100,gandalf.ReceiveAttack(knight.GetTotalAttackValue()));
            Assert.AreEqual(0,knight.ReceiveAttack(gandalf.GetTotalAttackValue()));
        }
        [Test]
        public void TestCure()
        {
            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff(); 
            gandalf.EquipMixedItem(staff);

            Knight knight = new Knight("Knight");

            knight.ReceiveAttack(gandalf.GetTotalAttackValue());

            Assert.AreEqual(100,knight.Cure());
        }
    }
}