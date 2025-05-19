using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class WireStripper: ToolBox
    {
        public WireStripper(int weightKG):base("WireStripper", weightKG)
        { }

        public override void Describe()
        {
            Console.WriteLine("WeakReference - A class in C# that holds a reference to an object without preventing it from being garbage collected.");
        }

        public override void Use()
            
        {
            Console.WriteLine("WeakReference - Used to cache or reference large objects without blocking memory cleanup, helping manage memory efficiently.");
        }

    }
}
