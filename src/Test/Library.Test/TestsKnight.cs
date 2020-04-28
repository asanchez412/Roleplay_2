using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class TestKnight
    {
        [Test]
        public void TestGetTotalAttackValue()
        {
            Knight knight = new Knight("Knight");
            
            IAttackItems axe = new Axe();
            IAttackItems sword = new Sword();
            IAttackItems bow = new Bow();

            knight.EquipAttackItem(axe);
            knight.EquipAttackItem(bow);
            knight.EquipAttackItem(sword);

            // Se establece si el cálculo del valor de ataque total es correcto

            Assert.AreEqual(25+15+20, knight.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalAttackValueSinItems()
        {
            Knight knight = new Knight("Knight");
            
            // Se establece que el valor de ataque es 0 en ausencia de items

            Assert.AreEqual(0,knight.GetTotalAttackValue());
        }

        [Test]
        public void TestGetTotalDefenseValue()
        {
            Knight knight = new Knight("Knight");

            IDefensiveItems armor = new Armor();
            IDefensiveItems helmet = new Helmet();
            IDefensiveItems shield = new Shield();

            knight.EquipDefensiveItem(armor);
            knight.EquipDefensiveItem(helmet);
            knight.EquipDefensiveItem(shield);
            
            // Se establece si el cálculo del valor de armadura total es correcto

            Assert.AreEqual(25+18+14,knight.GetTotalDefenseValue());
        }

        [Test]
        public void TestGetTotalDefenseValueSinItems()
        {
            Knight knight = new Knight("Knight");
            
            // Se establece que el valor de ataque es 0 en ausencia de items

            Assert.AreEqual(0,knight.GetTotalDefenseValue());
        }

        [Test]
        public void TestReceiveAttack()
        {
            Knight knight = new Knight("Knight");
            IDefensiveItems armor = new Armor();
            IDefensiveItems helmet = new Helmet();
            IDefensiveItems shield = new Shield();

            knight.EquipDefensiveItem(armor);
            knight.EquipDefensiveItem(helmet);
            knight.EquipDefensiveItem(shield);

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(27 ,knight.ReceiveAttack(130));
        }

        [Test]
        public void ReceiveAttackNegativo()
        {
            Knight knight = new Knight("Knight");

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(100,knight.ReceiveAttack(-55841));
        }

        [Test]
        public void ReceiveAttackGrande()
        {
            Knight knight = new Knight("Knight");

            // Se establece el daño recibido. Devuelve la vida restante.

            Assert.AreEqual(0,knight.ReceiveAttack(656615156));  
        }

        [Test]
        public void TestCure()
        {
            Knight knight = new Knight("Knight");

            knight.ReceiveAttack(120);
            
            // Se establece si el personaje se curó completamente
            
            Assert.AreEqual(100,knight.Cure());
        }

        [Test]
        public void TestEquipAttackItemAndUnEquip()
        {
            Knight knight = new Knight("Knight");
            
            IAttackItems axe = new Axe();
            IAttackItems sword = new Sword();
            IAttackItems bow = new Bow();

            knight.EquipAttackItem(axe);
            knight.EquipAttackItem(bow);
            knight.EquipAttackItem(sword);

            Assert.AreEqual(25+15+20, knight.GetTotalAttackValue());

            knight.UnEquipAttackItem(axe);
            knight.UnEquipAttackItem(bow);
            Assert.AreEqual(20, knight.GetTotalAttackValue());
        }

        [Test]
        public void TestEquipDefensiveItemAndUnEquip()
        {
            Knight knight = new Knight("Knight");

            IDefensiveItems armor = new Armor();
            IDefensiveItems shield = new Shield();

            knight.EquipDefensiveItem(shield);
            knight.EquipDefensiveItem(armor);

            Assert.AreEqual(25+14,knight.GetTotalDefenseValue());

            knight.UnEquipDefensiveItem(armor);
            knight.UnEquipDefensiveItem(shield);

            Assert.AreEqual(0,knight.GetTotalDefenseValue());
        }
    }
}