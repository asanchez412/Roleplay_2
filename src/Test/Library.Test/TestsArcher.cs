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
            
            IAttackItems axe = new Axe();
            IAttackItems sword = new Sword();
            IAttackItems bow = new Bow();

            archer.EquipAttackItem(axe);
            archer.EquipAttackItem(bow);
            archer.EquipAttackItem(sword);

            Assert.AreEqual(25+15+20, archer.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalAttackValueSinItems()
        {
            Archer archer = new Archer("Archer");
            
            Assert.AreEqual(0,archer.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalDefenseValue()
        {
            Archer archer = new Archer("Archer");

            IDefensiveItems armor = new Armor();
            IDefensiveItems helmet = new Helmet();
            IDefensiveItems shield = new Shield();

            archer.EquipDefensiveItem(armor);
            archer.EquipDefensiveItem(helmet);
            archer.EquipDefensiveItem(shield);
            
            Assert.AreEqual(25+18+14,archer.GetTotalDefenseValue());
        }

        [Test]
        public void TestGetTotalDefenseValueSinItems()
        {
            Archer archer = new Archer("Archer");
            
            Assert.AreEqual(0,archer.GetTotalDefenseValue());
        }

        [Test]
        public void TestReceiveAttack()
        {
            Archer archer = new Archer("Archer");
            IDefensiveItems armor = new Armor();
            IDefensiveItems helmet = new Helmet();
            IDefensiveItems shield = new Shield();

            archer.EquipDefensiveItem(armor);
            archer.EquipDefensiveItem(helmet);
            archer.EquipDefensiveItem(shield);

            Assert.AreEqual((100+25+18+14)-(130),archer.ReceiveAttack(130));
        }

        [Test]
        public void ReceiveAttackNegativo()
        {
            Archer archer = new Archer("Archer");

            Assert.AreEqual(100,archer.ReceiveAttack(-55841));
        }

        [Test]
        public void ReceiveAttackGrande()
        {
            Archer archer = new Archer("Archer");

            Assert.AreEqual(0,archer.ReceiveAttack(656615156));  
        }

        [Test]
        public void TestCure()
        {
            Archer archer = new Archer("Archer");

            archer.ReceiveAttack(120);

            Assert.AreEqual(100,archer.Cure());
        }

        [Test]
        public void TestEquipAttackItemAndUnEquip()
        {
            Archer archer = new Archer("Archer");
            
            IAttackItems axe = new Axe();
            IAttackItems sword = new Sword();
            IAttackItems bow = new Bow();

            archer.EquipAttackItem(axe);
            archer.EquipAttackItem(bow);
            archer.EquipAttackItem(sword);

            Assert.AreEqual(25+15+20, archer.GetTotalAttackValue());

            archer.UnEquipAttackItem(axe);
            archer.UnEquipAttackItem(bow);
            Assert.AreEqual(20, archer.GetTotalAttackValue());
        }

        [Test]
        public void TestEquipDefensiveItemAndUnEquip()
        {
            Archer archer = new Archer("Archer");

            IDefensiveItems armor = new Armor();
            IDefensiveItems shield = new Shield();

            archer.EquipDefensiveItem(shield);
            archer.EquipDefensiveItem(armor);

            Assert.AreEqual(25+14,archer.GetTotalDefenseValue());

            archer.UnEquipDefensiveItem(armor);
            archer.UnEquipDefensiveItem(shield);

            Assert.AreEqual(0,archer.GetTotalDefenseValue());
        }
    }
}