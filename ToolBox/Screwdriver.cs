using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Screwdriver: ToolBox
    {
        public Screwdriver(int weightKG) : base("Screwdriver", weightKG)
        { }

        public override void Describe()
        {
            Console.WriteLine("Screwdriver – A tool used to turn screws with a matching head.");
        }
        public override void Use()
        {
            Console.WriteLine("Screwdriver – Assembling furniture or opening battery compartments.");
        }
    }
}
