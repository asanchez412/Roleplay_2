// Se agrego esta interfase que implementa un tipo genérico dado que 
// todos los personajes comparten estos distintos métodos.
// Por otra parte, Wizard tiene más métodos pero sigue perteneciendo 
// al tipo genérico ICharacter.

// Se establece el equiparse, desequiparse items y los necesarios
// cálculos de armadura, daño, vida luego de recibir daño y la
// capacidad de curarse completamente.

// Aclaramos que el método ReceiveAttack no retorna un valor de cuánto
// daño se recibió sino de la vida restante de los personajes.

namespace RoleplayGame

{
    public interface ICharacter
    {

        int Health { get; set; }

        string Name { get; set; }

        void EquipItem(Items item);

        void UnEquipItem(Items item);

        int GetTotalAttackValue();

        int GetTotalDefenseValue();

        int ReceiveAttack(int damage);

        int Cure();
    }
}