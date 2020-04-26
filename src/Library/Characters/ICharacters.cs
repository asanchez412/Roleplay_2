using System.Collections.Generic;

public interface ICharacter
{
    void EquipDefensiveItem(IDefensiveItems defensiveItem);

    void UnEquipDefensiveItem(IDefensiveItems defensiveItem);

    void EquipAttackItem(IAttackItems attackItem);

    void UnEquipAttackItem(IAttackItems attackItem);

    int GetTotalAttackValue();

    int GetTotalDefenseValue();

    void ReceiveAttack(int damage);

    void Cure();
}