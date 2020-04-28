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
            
            IAttackItems axe = new Axe();
            IAttackItems sword = new Sword();
            IAttackItems bow = new Bow();

            dwarf.EquipAttackItem(axe);
            dwarf.EquipAttackItem(bow);
            dwarf.EquipAttackItem(sword);

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

            IDefensiveItems armor = new Armor();
            IDefensiveItems helmet = new Helmet();
            IDefensiveItems shield = new Shield();

            dwarf.EquipDefensiveItem(armor);
            dwarf.EquipDefensiveItem(helmet);
            dwarf.EquipDefensiveItem(shield);
            
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
            IDefensiveItems armor = new Armor();
            IDefensiveItems helmet = new Helmet();
            IDefensiveItems shield = new Shield();

            dwarf.EquipDefensiveItem(armor);
            dwarf.EquipDefensiveItem(helmet);
            dwarf.EquipDefensiveItem(shield);

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

            // Se establece si el personaje se curó completamente
            
            Assert.AreEqual(100,dwarf.Cure());
        }

        [Test]
        public void TestEquipAttackItemAndUnEquip()
        {
            Dwarf dwarf = new Dwarf("Dwarf");
            
            IAttackItems axe = new Axe();
            IAttackItems sword = new Sword();
            IAttackItems bow = new Bow();

            dwarf.EquipAttackItem(axe);
            dwarf.EquipAttackItem(bow);
            dwarf.EquipAttackItem(sword);

            Assert.AreEqual(25+15+20, dwarf.GetTotalAttackValue());

            dwarf.UnEquipAttackItem(axe);
            dwarf.UnEquipAttackItem(bow);
            Assert.AreEqual(20, dwarf.GetTotalAttackValue());
        }

        [Test]
        public void TestEquipDefensiveItemAndUnEquip()
        {
            Dwarf dwarf = new Dwarf("Dwarf");

            IDefensiveItems armor = new Armor();
            IDefensiveItems shield = new Shield();

            dwarf.EquipDefensiveItem(shield);
            dwarf.EquipDefensiveItem(armor);

            Assert.AreEqual(25+14,dwarf.GetTotalDefenseValue());

            dwarf.UnEquipDefensiveItem(armor);
            dwarf.UnEquipDefensiveItem(shield);

            Assert.AreEqual(0,dwarf.GetTotalDefenseValue());
        }
    }
}