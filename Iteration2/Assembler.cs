using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOVELO_PlanningList
{
    class Assembler
    {
        //This assembler class makes it possible to know who is connected as an assembler

        string test0;
        private string nameAssembler;
        private string password;

        private List<string> AssemblersConnected = new List<string>();
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

        public void addAssembler(string assemblerName)
        {
            AssemblersConnected.Add(assemblerName);
        }
    }
}
