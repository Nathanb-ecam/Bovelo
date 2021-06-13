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
        private string password;
        private bool checkUp;

        private List<string> Assemblers = new List<string>();
        private Dictionary<string, string> Identification = new Dictionary<string, string>();
      
        public string getMonteur { get { return nameAssembler; } set { test0 = value; } }

        public Assembler(string AssemblerName)
        {
            this.nameAssembler = AssemblerName;
            addAssembler(AssemblerName);
        }

        public Assembler(string identif , string password)
        {
            this.nameAssembler = identif;
            this.password = password;
        }

        public bool checkIdentif()
        {
            foreach (KeyValuePair<string, string> test in Identification)
            {
                if (test.Key == nameAssembler && test.Value == password)
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
