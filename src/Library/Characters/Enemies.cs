
namespace RoleplayGame

{
    public class Enemies : Character
    {
        public Enemies (string name) : base (name) {}

        public virtual int VictoryPoints ()
        {
            return 0;
        }
    }
}