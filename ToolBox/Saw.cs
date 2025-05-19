using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Saw:ToolBox
    {
        public Saw(int weightKG) : base("Saw", weightKG)
        { }

        public override void Describe()
        {
            Console.WriteLine("Saw – A tool with a serrated blade used for cutting.");
        }
        public override void Use()
        {
            Console.WriteLine("Saw – Cutting wooden boards to size in carpentry projects.");
        }
    }
}
