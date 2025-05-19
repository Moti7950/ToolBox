using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Wrench: ToolBox
    {
        public Wrench(int weightKG) : base("Wrench", weightKG)
        { }

        public override void Describe()
        {
            Console.WriteLine("Wrench – A tool used to grip and turn objects like nuts and bolts.");
        }
        public override void Use()
        {
            Console.WriteLine("Wrench – Loosening or tightening bolts in plumbing or machinery.");
        }
    }
}
