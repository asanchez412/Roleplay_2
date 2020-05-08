namespace RoleplayGame

{
    public class Ogre : Enemies
    {
        public Ogre(string name) : base(name) {}

        public override int VictoryPoints()
        {
            return 2;
        }
    }
} 