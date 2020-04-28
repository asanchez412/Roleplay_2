// Se agrego esta interfase que implementa un tipo genérico dado que 
// todos los personajes comparten estos distintos métodos.
// Por otra parte, Wizard tiene más métodos pero sigue perteneciendo 
// al tipo genérico ICharacter.

// Se establece el equiparse, desequiparse items y los necesarios
// cálculos de armadura, daño, vida luego de recibir daño y la
// capacidad de curarse completamente.

// Aclaramos que el método ReceiveAttack no retorna un valor de cuánto
// daño se recibió sino de la vida restante de los personajes.

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