namespace RoleplayGame

{
    public class Items : IItems
    {
        public virtual int AttackValue()
        {
            return 0;
        }
        public virtual int DefenseValue()
        {
            return 0;
        }
    }
}