using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class PipeCutter: ToolBox
    {
        public PipeCutter(int weightKG) : base("PipeCutter", weightKG)
        { }

        public override void Describe()
        {
            Console.WriteLine("Pipe Cutter – A tool designed to cleanly cut through pipes.");
        }
        public override void Use()
        {
            Console.WriteLine("Pipe Cutter – Cutting PVC or copper pipes when installing plumbing.");
        }
    }
}
