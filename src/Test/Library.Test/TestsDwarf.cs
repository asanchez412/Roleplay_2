using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class TestDwarf
    {
        [Test]
        public void TestGetTotalAttackValue()
        {
            Dwarf dwarf = new Dwarf("Dwarf");
            
            Items axe = new Axe();
            Items sword = new Sword();
            Items bow = new Bow();

            dwarf.EquipItem(axe);
            dwarf.EquipItem(bow);
            dwarf.EquipItem(sword);

            // Se establece si el cálculo del valor de ataque total es correcto

            Assert.AreEqual(25+15+20, dwarf.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalAttackValueSinItems()
        {
            Dwarf dwarf = new Dwarf("Dwarf");
            
            // Se establece que el valor de ataque es 0 en ausencia de items

            Assert.AreEqual(0, dwarf.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalDefenseValue()
        {
            Dwarf dwarf = new Dwarf("Dwarf");

            Items armor = new Armor();
            Items helmet = new Helmet();
            Items shield = new Shield();

            dwarf.EquipItem(armor);
            dwarf.EquipItem(helmet);
            dwarf.EquipItem(shield);
            
            // Se establece si el cálculo del valor de armadura total es correcto

            Assert.AreEqual(25+18+14, dwarf.GetTotalDefenseValue());
        }

        [Test]
        public void TestGetTotalDefenseValueSinItems()
        {
            Dwarf dwarf = new Dwarf("Dwarf");
            
            // Se establece que el valor de ataque es 0 en ausencia de items

            Assert.AreEqual(0, dwarf.GetTotalDefenseValue());
        }

        [Test]
        public void TestReceiveAttack()
        {
            Dwarf dwarf = new Dwarf("Dwarf");
            Items armor = new Armor();
            Items helmet = new Helmet();
            Items shield = new Shield();

            dwarf.EquipItem(armor);
            dwarf.EquipItem(helmet);
            dwarf.EquipItem(shield);

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(27, dwarf.ReceiveAttack(130));
        }

        [Test]
        public void ReceiveAttackNegativo()
        {
            Dwarf dwarf = new Dwarf("Dwarf");

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(100,dwarf.ReceiveAttack(-55841));
        }

        [Test]
        public void ReceiveAttackGrande()
        {
            Dwarf dwarf = new Dwarf("Dwarf");

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(0,dwarf.ReceiveAttack(656615156));  
        }

        [Test]
        public void TestCure()
        {
            Dwarf dwarf = new Dwarf("Dwarf");

            dwarf.ReceiveAttack(120);

            dwarf.Cure();

            // Se establece si el personaje se curó completamente
            
            Assert.AreEqual(dwarf.Health,dwarf.Cure());
        }

        [Test]
        public void TestEquipItemAndUnEquip()
        {
            Dwarf dwarf = new Dwarf("Dwarf");
            
            Items axe = new Axe();
            Items sword = new Sword();
            Items bow = new Bow();

            dwarf.EquipItem(axe);
            dwarf.EquipItem(bow);
            dwarf.EquipItem(sword);

            Assert.AreEqual(25+15+20, dwarf.GetTotalAttackValue());

            dwarf.UnEquipItem(axe);
            dwarf.UnEquipItem(bow);
            Assert.AreEqual(20, dwarf.GetTotalAttackValue());
        }
    }
}