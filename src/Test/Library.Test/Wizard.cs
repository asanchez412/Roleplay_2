using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class TestsWizzard 
    {
        [Test]
        public void TestGetTotalAttackValue()
        {
            SpellsBook book = new SpellsBook();
            ISpell spell1 = new FireSpell();
            book.AddSpell(spell1);

            Wizard gandalf = new Wizard("Gandalf");
            IMixedItems staff = new RunicStaff(); 
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
            ISpell spell2 = new WindSpell();
            book.AddSpell(spell2);

            Wizard gandalf = new Wizard("Gandalf");
            IMixedItems staff = new RunicStaff(); 
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
            ISpell spell2 = new WindSpell();
            book.AddSpell(spell2);

            Wizard gandalf = new Wizard("Gandalf");
            IMixedItems staff = new RunicStaff(); 
            gandalf.EquipMixedItem(staff); 
            gandalf.EquipSpellBook(book);

            Knight knight = new Knight("Knight");
            IAttackItems sword = new Sword();
            IDefensiveItems armor = new Armor();
            IDefensiveItems helmet = new Helmet();
            IDefensiveItems shield = new Shield();

            knight.EquipAttackItem(sword);
            knight.EquipDefensiveItem(armor);
            knight.EquipDefensiveItem(helmet);
            knight.EquipDefensiveItem(shield);

            Assert.AreEqual(100,gandalf.ReceiveAttack(knight.GetTotalAttackValue()));
            Assert.AreEqual(0,knight.ReceiveAttack(gandalf.GetTotalAttackValue()));
        }

        [Test]
        public void ReceiveAttackNegativo()
        {
            Wizard gandalf = new Wizard("Gandalf");

            Assert.AreEqual(100,gandalf.ReceiveAttack(-55841));
        }

        [Test]
        public void ReceiveAttackGrande()
        {
            Wizard gandalf = new Wizard("Gandalf");

            Assert.AreEqual(0,gandalf.ReceiveAttack(656615156));  
        }

        [Test]
        public void TestCure()
        {
            Wizard gandalf = new Wizard("Gandalf");

            gandalf.ReceiveAttack(gandalf.ReceiveAttack(120));

            Assert.AreEqual(100,gandalf.Cure());
        }

        [Test]
        public void TestEquipAttackItemAndUnEquip()
        {
            Wizard gandalf = new Wizard("Gandalf");

            Archer archer = new Archer("Archer");
            
            IAttackItems axe = new Axe();
            IAttackItems sword = new Sword();
            IAttackItems bow = new Bow();

            gandalf.EquipAttackItem(axe);
            gandalf.EquipAttackItem(bow);
            gandalf.EquipAttackItem(sword);


            Assert.AreEqual(25+15+20,gandalf.GetTotalAttackValue());

            gandalf.UnEquipAttackItem(axe);
            gandalf.UnEquipAttackItem(bow);

            Assert.AreEqual(20,gandalf.GetTotalAttackValue());
        }

        [Test]
        public void TestEquipDefensiveItemAndUnEquip()
        {
            Wizard gandalf = new Wizard("Gandalf");

            IDefensiveItems armor = new Armor();
            IDefensiveItems shield = new Shield();

            gandalf.EquipDefensiveItem(shield);
            gandalf.EquipDefensiveItem(armor);


            Assert.AreEqual(25+14,gandalf.GetTotalDefenseValue());

            gandalf.UnEquipDefensiveItem(armor);
            gandalf.UnEquipDefensiveItem(shield);

            Assert.AreEqual(0,gandalf.GetTotalDefenseValue());
        }

        [Test]
        public void TestEquipMixedItemAndUnequip()
        {
            Wizard gandalf = new Wizard("Gandalf");
            
            IMixedItems staff1 = new RunicStaff();
            IMixedItems staff2 = new WoodStaff();

            gandalf.EquipMixedItem(staff1);

            Assert.AreEqual(100,gandalf.GetTotalAttackValue());
            Assert.AreEqual(100,gandalf.GetTotalDefenseValue());

            gandalf.UnEquipMixedItem(staff1);
            gandalf.EquipMixedItem(staff2);

            Assert.AreEqual(50,gandalf.GetTotalAttackValue());
            Assert.AreEqual(50,gandalf.GetTotalDefenseValue());
        }

        [Test]
        public void TestSpellsBookAttackAndDefenseValue()
        {
            ISpell spell1 = new WindSpell();
            ISpell spell2 = new FireSpell();

            SpellsBook book = new SpellsBook();

            book.AddSpell(spell1);
            
            Assert.AreEqual(80,book.AttackValue);
            Assert.AreEqual(60,book.DefenseValue);

            book.RemoveSpell(spell1);
            book.AddSpell(spell2);

            Assert.AreEqual(70,book.AttackValue);
            Assert.AreEqual(70,book.DefenseValue);
        }
    }
}