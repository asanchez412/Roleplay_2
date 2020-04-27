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
        [Test]
        public void TestknightEquipAttackAndUnEquipAttackItem()
        {
            Knight knight = new Knight("Knight");
            Axe axe = new Axe();
            Bow bow = new Bow();
            knight.EquipAttackItem(axe);
            knight.EquipAttackItem(bow);

            Assert.AreEqual(25+15,knight.GetTotalAttackValue());

            knight.UnEquipAttackItem(axe);
            knight.UnEquipAttackItem(bow);

            Assert.AreEqual(0,knight.GetTotalAttackValue());
        }
        public void TestWizzardEquipAttackAndUnEquipAttackItem()
        {
            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff();
            Bow bow = new Bow();
            gandalf.EquipMixedItem(staff);
            gandalf.EquipAttackItem(bow);

            Assert.AreEqual(100+15,gandalf.GetTotalAttackValue());

            gandalf.UnEquipMixedItem(staff);
            gandalf.UnEquipAttackItem(bow);

            Assert.AreEqual(0,gandalf.GetTotalAttackValue());
        }
        [Test]
        public void TestArcherEquipAttackAndUnEquipAttackItem()
        {
            Archer archer = new Archer("Archer");
            Axe axe = new Axe();
            Bow bow = new Bow();
            archer.EquipAttackItem(axe);
            archer.EquipAttackItem(bow);

            Assert.AreEqual(25+15,archer.GetTotalAttackValue());

            archer.UnEquipAttackItem(axe);
            archer.UnEquipAttackItem(bow);

            Assert.AreEqual(0,archer.GetTotalAttackValue());
        }
        [Test]
        public void TestDwarfEquipAttackAndUnEquipAttackItem()
        {
            Dwarf dwarf = new Dwarf("Dwarf");
            Axe axe = new Axe();
            Bow bow = new Bow();
            dwarf.EquipAttackItem(axe);
            dwarf.EquipAttackItem(bow);

            Assert.AreEqual(25+15,dwarf.GetTotalAttackValue());

            dwarf.UnEquipAttackItem(axe);
            dwarf.UnEquipAttackItem(bow);

            Assert.AreEqual(0,dwarf.GetTotalAttackValue());
        }
        [Test]
        public void TestEquipDefensiveItemAndUnEquip()
        {
            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff();
            Shield shield = new Shield();
            gandalf.EquipMixedItem(staff);
            gandalf.EquipDefensiveItem(shield);

            Assert.AreEqual(100+14,gandalf.GetTotalDefenseValue());

            gandalf.UnEquipMixedItem(staff);
            gandalf.UnEquipDefensiveItem(shield);

            Assert.AreEqual(0,gandalf.GetTotalDefenseValue());
        }
    }
}