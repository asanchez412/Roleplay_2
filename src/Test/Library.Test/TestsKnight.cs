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
            
            Items axe = new Axe();
            Items sword = new Sword();
            Items bow = new Bow();

            knight.EquipItem(axe);
            knight.EquipItem(bow);
            knight.EquipItem(sword);

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

            Items armor = new Armor();
            Items helmet = new Helmet();
            Items shield = new Shield();

            knight.EquipItem(armor);
            knight.EquipItem(helmet);
            knight.EquipItem(shield);
            
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
            Items armor = new Armor();
            Items helmet = new Helmet();
            Items shield = new Shield();

            knight.EquipItem(armor);
            knight.EquipItem(helmet);
            knight.EquipItem(shield);

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

            knight.Cure();
            
            // Se establece si el personaje se curó completamente
            
            Assert.AreEqual(knight.Health,knight.Cure());
        }

        [Test]
        public void TestEquipItemAndUnEquip()
        {
            Knight knight = new Knight("Knight");
            
            Items axe = new Axe();
            Items sword = new Sword();
            Items bow = new Bow();

            knight.EquipItem(axe);
            knight.EquipItem(bow);
            knight.EquipItem(sword);

            Assert.AreEqual(25+15+20, knight.GetTotalAttackValue());

            knight.UnEquipItem(axe);
            knight.UnEquipItem(bow);
            Assert.AreEqual(20, knight.GetTotalAttackValue());
        }
    }
}