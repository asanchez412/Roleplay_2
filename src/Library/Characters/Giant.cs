namespace RoleplayGame

{

    public class Giant : Enemies
    {
        public Giant(string name) : base(name){}

        public override int VictoryPoints()
        {
            return 2;
        }
    }
}