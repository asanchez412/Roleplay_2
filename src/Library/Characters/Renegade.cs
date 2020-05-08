namespace RoleplayGame
{
    public class Renegade : Enemies
    {
        public Renegade(string name) : base(name) {}

        public override int VictoryPoints()
        {
            return 2;
        }
    }
}