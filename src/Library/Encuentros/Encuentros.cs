using System.Collections.Generic;
using System.Linq;

namespace RoleplayGame

{
    public class Encuentro : IEncuentros
    {
        protected IList <Enemies> enemies = new List<Enemies>();

        protected IList <Heroes> heroes = new List<Heroes>();

        public void AddEnemy(Enemies enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemies enemy)
        {
            enemies.Remove(enemy);
        }

        public void AddHero(Heroes hero)
        {
            heroes.Add(hero);
        }

        public void RemoveHero(Heroes hero)
        {
            heroes.Add(hero);
        }

        public void EnemiesAttack()
        {   
            if (enemies.Count > heroes.Count && heroes.Count == 1)
            foreach (Heroes hero in heroes)
            {
                foreach (Enemies enemy in enemies)
                {
                    hero.ReceiveAttack(enemy.GetTotalAttackValue());
                }
            }
            if (enemies.Count == heroes.Count)
            {
                for (int idx = 0; idx == heroes.Count-1; idx ++)
                {
                    Heroes hero = heroes.ElementAt(idx);
                    Enemies enemy = enemies.ElementAt(idx);
                    hero.ReceiveAttack(enemy.GetTotalAttackValue());
                }
            }

            if (enemies.Count > heroes.Count && heroes.Count > 1)
            {
                Heroes hero = heroes.ElementAt(0);
                Enemies enemy1 = enemies.ElementAt(0);
                Enemies enemy2 = enemies.ElementAt(1);

                hero.ReceiveAttack(enemy1.GetTotalAttackValue());
                hero.ReceiveAttack(enemy2.GetTotalAttackValue());

                for (int idx = 2; idx == heroes.Count-1; idx ++)
                {
                    hero = heroes.ElementAt(idx -1);
                    enemy1 = enemies.ElementAt(idx);

                    hero.ReceiveAttack(enemy1.GetTotalAttackValue());
                }
            }
        }

        public void HeroesAttack()
        {
            foreach (Heroes hero in heroes)
            {
                foreach (Enemies enemy in enemies)
                {
                    if (hero.Health > 0)
                    {
                        enemy.ReceiveAttack(hero.GetTotalAttackValue());
                    }
                }
            }
        }

        public void CureHeroVP()
        {
            foreach (Heroes hero in heroes)
            {
                if (hero.TotalVP() >= 5)
                {
                    hero.Cure();
                }
            }
        }
    }
}