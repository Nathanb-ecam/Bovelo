using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    class Size
    {
        private int size;

        public Size(int size)
        {
            this.size = size;
        }

        public int Sizes
        {
            get { return size; }
            set { size = value; }
        }
    }
}
