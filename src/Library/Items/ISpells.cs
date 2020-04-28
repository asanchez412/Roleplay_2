// Para los hechizos también se implementó una interfase de
// spell debido a que todos los hechizos comparten dos operaciones
// básicas. Esto permite agregar y remover hechizos de distintos tipos
// sin problemas en el libro de hechizos.

public interface ISpell
{
    int AttackValue();

    int DefenseValue();
}