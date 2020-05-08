using RoleplayGame;

public interface IEncuentros

{
    void AddEnemy(Enemies enemy);

    void RemoveEnemy(Enemies enemy);

    void AddHero(Heroes hero);

    void RemoveHero(Heroes hero);

    void EnemiesAttack();

    void HeroesAttack();

    void CureHeroVP();
}