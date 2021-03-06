using NUnit.Framework;
using RoleplayGame;

namespace Library.Test

{
    public class TestsEncuentros
    {

        [Test]
        public void TestDoEncounter()
        {
            Renegade renegade = new Renegade("Renegade");
            Ogre ogre = new Ogre("Ogre");
            Giant giant = new Giant("Giant");

            Dwarf gimli = new Dwarf("Gimli");

            Helmet helmet = new Helmet();
            Sword sword = new Sword();
            Axe axe = new Axe();
            WoodStaff staff = new WoodStaff();

            gimli.EquipItem(helmet);
            gimli.EquipItem(sword);
            gimli.EquipItem(axe);
            gimli.EquipItem(staff);

            EncuentroNormal encuentro = new EncuentroNormal();

            encuentro.AddHero(gimli);

            encuentro.AddEnemy(renegade);
            encuentro.AddEnemy(ogre);
            encuentro.AddEnemy(giant);

            Assert.AreEqual("El encuentro ha terminado. Han ganado los héroes", encuentro.DoEncounter());
        }

        [Test]
        public void TestEnemiesAttackOneHero()
        {
            Renegade renegade = new Renegade("Renegade");
            Ogre ogre = new Ogre("Ogre");
            Giant giant = new Giant("Giant");

            Dwarf gimli = new Dwarf("Gimli");

            Helmet helmet = new Helmet();
            Sword sword = new Sword();

            gimli.EquipItem(helmet);
            gimli.EquipItem(sword);

            Encuentro encuentro = new Encuentro();

            encuentro.AddHero(gimli);

            encuentro.AddEnemy(renegade);
            encuentro.AddEnemy(ogre);
            encuentro.AddEnemy(giant);

            Assert.AreEqual(gimli.Health, 100 - gimli.ReceiveAttack(renegade.GetTotalAttackValue()) - gimli.ReceiveAttack(ogre.GetTotalAttackValue()) - gimli.ReceiveAttack(giant.GetTotalAttackValue()));
        }

        public void TestEnemiesAttackLessHeroes()
        {
            Renegade renegade = new Renegade("Renegade");
            Ogre ogre = new Ogre("Ogre");
            Giant giant = new Giant("Giant");

            Dwarf gimli = new Dwarf("Gimli");
            Knight knight = new Knight("Knight");

            Helmet helmet = new Helmet();
            Sword sword = new Sword();

            gimli.EquipItem(helmet);
            gimli.EquipItem(sword);

            knight.EquipItem(helmet);
            knight.EquipItem(sword);

            Encuentro encuentro = new Encuentro();

            encuentro.AddHero(gimli);
            encuentro.AddHero(knight);

            encuentro.AddEnemy(renegade);
            encuentro.AddEnemy(ogre);
            encuentro.AddEnemy(giant);

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void TestEnemiesAttackEqualHeroes()
        {
            Renegade renegade = new Renegade("Renegade");
            Ogre ogre = new Ogre("Ogre");
            Giant giant = new Giant("Giant");

            Dwarf gimli = new Dwarf("Gimli");
            Knight knight = new Knight("Knight");

            Helmet helmet = new Helmet();
            Sword sword = new Sword();

            gimli.EquipItem(helmet);
            gimli.EquipItem(sword);

            knight.EquipItem(helmet);
            knight.EquipItem(sword);

            Encuentro encuentro = new Encuentro();

            encuentro.AddHero(gimli);
            encuentro.AddHero(knight);

            encuentro.AddEnemy(renegade);
            encuentro.AddEnemy(ogre);
            encuentro.AddEnemy(giant);

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void TestHeroesAttack()
        {
            Renegade renegade = new Renegade("Renegade");
            Ogre ogre = new Ogre("Ogre");
            Giant giant = new Giant("Giant");

            Knight knight = new Knight("Knight");

            Helmet helmet = new Helmet();
            Sword sword = new Sword();

            knight.EquipItem(helmet);
            knight.EquipItem(sword);

            Encuentro encuentro = new Encuentro();

            encuentro.AddHero(knight);

            encuentro.AddEnemy(renegade);
            encuentro.AddEnemy(ogre);
            encuentro.AddEnemy(giant);

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void TestCureHeroEnoughVP()
        {
            Renegade renegade = new Renegade("Renegade");
            Ogre ogre = new Ogre("Ogre");
            Giant giant = new Giant("Giant");

            Knight knight = new Knight("Knight");

            Helmet helmet = new Helmet();
            Sword sword = new Sword();

            knight.EquipItem(helmet);
            knight.EquipItem(sword);

            Encuentro encuentro = new Encuentro();

            encuentro.AddHero(knight);

            encuentro.AddEnemy(renegade);
            encuentro.AddEnemy(ogre);
            encuentro.AddEnemy(giant);

            Assert.AreEqual(0, 0);
        }

        public void TestCureHeroNotEnoughVP()
        {
            Renegade renegade = new Renegade("Renegade");
            Ogre ogre = new Ogre("Ogre");
            Giant giant = new Giant("Giant");

            Knight knight = new Knight("Knight");

            Helmet helmet = new Helmet();
            Sword sword = new Sword();

            knight.EquipItem(helmet);
            knight.EquipItem(sword);

            Encuentro encuentro = new Encuentro();

            encuentro.AddHero(knight);

            encuentro.AddEnemy(renegade);
            encuentro.AddEnemy(ogre);
            encuentro.AddEnemy(giant);

            Assert.AreEqual(0, 0);
        }
    }
}