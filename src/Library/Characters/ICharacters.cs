public interface ICharacter
{
    void EquipDefensiveItem(IDefensiveItems defensiveItem);

    void UnEquipDefensiveItem(IDefensiveItems defensiveItem);

    void EquipAttackItem(IAttackItems attackItem);

    void UnEquipAttackItem(IAttackItems attackItem);

    int GetTotalAttackValue();

    int GetTotalDefenseValue();

    int ReceiveAttack(int damage);

    int Cure();
}