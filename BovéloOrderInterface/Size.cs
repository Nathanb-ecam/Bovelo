using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    public class Size
    {
        private string size;

        public Size(string size)
        {
            this.size = size;
        }

        public string Sizes
        {
            get { return size; }
            set { size = value; }
        }
    }
}
