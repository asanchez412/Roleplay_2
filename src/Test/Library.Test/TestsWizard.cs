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
            Items staff = new RunicStaff(); 
            gandalf.EquipItem(staff); 
            gandalf.EquipSpellBook(book);
            
            // Se establece si el cálculo del valor de ataque total es correcto

            Assert.AreEqual(170,gandalf.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalAttackValueSinItems()
        {
            Wizard gandalf = new Wizard("Gandalf");
            
            // Se establece que el valor de ataque es 0 en ausencia de items

            Assert.AreEqual(0,gandalf.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalDefenseValue()
        {
            SpellsBook book = new SpellsBook();
            ISpell spell2 = new WindSpell();
            book.AddSpell(spell2);

            Wizard gandalf = new Wizard("Gandalf");
            Items staff = new RunicStaff(); 
            gandalf.EquipItem(staff); 
            gandalf.EquipSpellBook(book);
            
            // Se establece si el cálculo del valor de armadura total es correcto

            Assert.AreEqual(160,gandalf.GetTotalDefenseValue());
        }

        [Test]
        public void TestGetTotalDefenseValueSinItems()
        {
            Wizard gandalf = new Wizard("Gandalf");
            
            // Se establece que el valor de ataque es 0 en ausencia de items

            Assert.AreEqual(0,gandalf.GetTotalDefenseValue());
        }

        [Test]
        public void TestReceiveAttack()
        {

            Wizard gandalf = new Wizard("Gandalf");

            Knight knight = new Knight("Knight");
            Items sword = new Sword();

            knight.EquipItem(sword);

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(80,gandalf.ReceiveAttack(knight.GetTotalAttackValue()));
        }

        [Test]
        public void ReceiveAttackNegativo()
        {
            Wizard gandalf = new Wizard("Gandalf");
            
            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(100,gandalf.ReceiveAttack(-55841));
        }

        [Test]
        public void ReceiveAttackGrande()
        {
            Wizard gandalf = new Wizard("Gandalf");

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(0,gandalf.ReceiveAttack(656615156));  
        }

        [Test]
        public void TestCure()
        {
            Wizard gandalf = new Wizard("Gandalf");

            gandalf.ReceiveAttack(gandalf.ReceiveAttack(120));

            gandalf.Cure();

            // Se establece si el personaje se curó completamente

            Assert.AreEqual(gandalf.Health,gandalf.Cure());
        }

        [Test]
        public void TestEquipItemAndUnEquip()
        {
            Wizard gandalf = new Wizard("Gandalf");
            
            Items axe = new Axe();
            Items sword = new Sword();
            Items bow = new Bow();

            gandalf.EquipItem(axe);
            gandalf.EquipItem(bow);
            gandalf.EquipItem(sword);


            Assert.AreEqual(25+15+20,gandalf.GetTotalAttackValue());

            gandalf.UnEquipItem(axe);
            gandalf.UnEquipItem(bow);

            Assert.AreEqual(20,gandalf.GetTotalAttackValue());
        }

        [Test]
        public void TestSpellsBookAttackAndDefenseValue()
        {
            ISpell spell1 = new WindSpell();
            ISpell spell2 = new FireSpell();

            SpellsBook book = new SpellsBook();

            book.AddSpell(spell1);

            // Se verifica cálculo correcto en base a 
            // agregar hechizos

            Assert.AreEqual(80,book.AttackValue);
            Assert.AreEqual(60,book.DefenseValue);

            book.RemoveSpell(spell1);
            book.AddSpell(spell2);

            Assert.AreEqual(70,book.AttackValue);
            Assert.AreEqual(70,book.DefenseValue);
        }
    }
}