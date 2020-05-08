using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class TestsArcher
    {
        [Test]
        public void TestGetTotalAttackValue()
        {
            Archer archer = new Archer("Archer");
            
            Items axe = new Axe();
            Items sword = new Sword();
            Items bow = new Bow();

            archer.EquipItem(axe);
            archer.EquipItem(bow);
            archer.EquipItem(sword);

            // Se establece si el cálculo del valor de ataque total es correcto

            Assert.AreEqual(25+15+20, archer.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalAttackValueSinItems()
        {
            Archer archer = new Archer("Archer");
            
            // Se establece que el valor de ataque es 0 en ausencia de items

            Assert.AreEqual(0,archer.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalDefenseValue()
        {
            Archer archer = new Archer("Archer");

            Items armor = new Armor();
            Items helmet = new Helmet();
            Items shield = new Shield();

            archer.EquipItem(armor);
            archer.EquipItem(helmet);
            archer.EquipItem(shield);
            
            // Se establece si el cálculo del valor de armadura total es correcto

            Assert.AreEqual(25+18+14,archer.GetTotalDefenseValue());
        }

        [Test]
        public void TestGetTotalDefenseValueSinItems()
        {
            Archer archer = new Archer("Archer");
            
            // Se establece que el valor de ataque es 0 en ausencia de items

            Assert.AreEqual(0,archer.GetTotalDefenseValue());
        }

        [Test]
        public void TestReceiveAttack()
        {
            Archer archer = new Archer("Archer");
            Items armor = new Armor();
            Items helmet = new Helmet();
            Items shield = new Shield();

            archer.EquipItem(armor);
            archer.EquipItem(helmet);
            archer.EquipItem(shield);

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(27,archer.ReceiveAttack(130));
        }

        [Test]
        public void ReceiveAttackNegativo()
        {
            Archer archer = new Archer("Archer");

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(100,archer.ReceiveAttack(-55841));
        }

        [Test]
        public void ReceiveAttackGrande()
        {
            Archer archer = new Archer("Archer");

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(0,archer.ReceiveAttack(656615156));  
        }

        [Test]
        public void TestCure()
        {
            Archer archer = new Archer("Archer");

            archer.ReceiveAttack(120);

            archer.Cure();

            // Se establece si el personaje se curó completamente

            Assert.AreEqual(archer.Health,archer.Cure());
        }

        [Test]
        public void TestEquiItemAndUnEquip()
        {
            Archer archer = new Archer("Archer");
            
            Items axe = new Axe();
            Items sword = new Sword();
            Items bow = new Bow();

            archer.EquipItem(axe);
            archer.EquipItem(bow);
            archer.EquipItem(sword);

            Assert.AreEqual(25+15+20, archer.GetTotalAttackValue());

            archer.UnEquipItem(axe);
            archer.UnEquipItem(bow);
            Assert.AreEqual(20, archer.GetTotalAttackValue());
        }
    }
}