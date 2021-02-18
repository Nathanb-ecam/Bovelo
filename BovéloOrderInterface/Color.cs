using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    public class Color
    {
        private string color;

        public Color(string color)
        {
            this.color = color;
        }


        public string Colors
        {
            get { return color; }
            set { color = value; }
        }
    }
}
