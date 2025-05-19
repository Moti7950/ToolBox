using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class NailGun: ToolBox
    {
        public NailGun(int weightKG):base ("NailGun",weightKG)
        { }

        public override void Describe()
        {
            Console.WriteLine("NailGun - A power tool that drives nails automatically using air pressure or electricity.");
        }

        public override void Use()
        {
            Console.WriteLine("NailGun - Quickly fastening pieces of wood in construction or carpentry.");
        }
    }
}
