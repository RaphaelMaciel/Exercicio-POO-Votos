using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotosPorEleitores
{
    public class Eleitor
    {
        public int totalDeEleitores { get; set; }

        public Eleitor()
        {
            totalDeEleitores = 1000;
        }

        public Eleitor(int total)
        {
            totalDeEleitores = total;
        }
    }
}
