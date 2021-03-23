using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class Planning_Master
    {
        private string identf1;
        private string identf2;
        private bool checkUp;

        Dictionary<string, string> GoBackToTheShadows = new Dictionary<string, string>();

        public Planning_Master(string a, string b)
        {
            this.identf1 = a;
            this.identf2 = b;
        }

        public bool checkIdentif()
        {
            foreach(KeyValuePair<string, string> test in GoBackToTheShadows)
            {
                if(test.Key == identf1 && test.Value == identf2)
                {
                    checkUp = true;
                }
                else
                {
                    checkUp = false;
                }
            }
            return checkUp;
           
        }

    }
}
