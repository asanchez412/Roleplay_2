using RoleplayGame

{
    public class Ogre : Enemies
    {
        public Renegade(string name) : base(name) {}

        public override int VictoryPoints()
        {
            return 2;
        }
    }
} 