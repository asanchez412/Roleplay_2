using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetTotalAttackValueGandalf()
        {
           SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff(); 
            gandalf.EquipMixedItem(staff); 
            gandalf.EquipSpellBook(book);
            
            Assert.AreEqual(170,gandalf.GetTotalAttackValue());
        }
        [Test]
        public void TestTestGetTotalDefenseValueGandalf()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff(); 
            gandalf.EquipMixedItem(staff); 
            gandalf.EquipSpellBook(book);
            
            Assert.AreEqual(170,gandalf.GetTotalDefenseValue());
        }
    }
}