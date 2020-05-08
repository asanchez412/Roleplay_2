using System.Collections.Generic;

namespace RoleplayGame
{

    public class Heroes : Character
    {
        public Heroes (string name) : base (name) {}

        protected IList <int> VP = new List <int> ();

        public void GainVP (int vp)
        {
            VP.Add(vp);
        }

        public int TotalVP()
        {
            int result = 0;

            foreach (int vp in VP) 
            {
                result += vp;
            }
            return result;
        }
    }
}