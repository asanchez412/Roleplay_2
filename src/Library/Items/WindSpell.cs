namespace RoleplayGame
{
    public class WindSpell : ISpell
    {
        public int AttackValue()
        {
            return 80;
        }

        public int DefenseValue()
        {
            return 60;
        }
    }
}