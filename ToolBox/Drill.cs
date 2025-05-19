using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Drill:ToolBox
    {
        public Drill(int weightKG):base ("Drill", weightKG)
        { }
        
        public override void Describe()
        {
            Console.WriteLine("Drill – A power tool with a rotating bit for making holes.");
        }
        public override void Use()
        {
            Console.WriteLine("Drill – Drilling holes in walls to hang shelves or fixtures.");
        }
    }
}
