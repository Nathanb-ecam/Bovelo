using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class Assembler
    {
        string test0;

        private string nameAssembler;
        private string identif2;
        private bool checkUp;

        private List<string> Assemblers = new List<string>();
        private Dictionary<string, string> Identification = new Dictionary<string, string>();
      
        public string getMonteur { get { return nameAssembler; } set { test0 = value; } }

        public Assembler(string AssemblerName)
        {
            this.nameAssembler = AssemblerName;
            addAssembler(AssemblerName);
        }

        public Assembler(string a , string b)
        {
            this.nameAssembler = a;
            this.identif2 = b;
        }

        public bool checkIdentif()
        {
            foreach (KeyValuePair<string, string> test in Identification)
            {
                if (test.Key == nameAssembler && test.Value == identif2)
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

        public void addAssembler(string assemblerName)
        {
            Assemblers.Add(assemblerName);
        }
    }
}
