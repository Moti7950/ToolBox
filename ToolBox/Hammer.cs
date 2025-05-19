using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToolBox
{
    internal class Hammer :ToolBox
    {
        public Hammer(int weightKG) : base("Hammer", weightKG)
        { }

        public override void Describe()
        {
            Console.WriteLine("Hammer – A hand tool with a heavy head used for striking.");
        }
        public override void Use()
        {
            Console.WriteLine("Hammer – Driving nails into wood or breaking objects.");
        }
    }
}
