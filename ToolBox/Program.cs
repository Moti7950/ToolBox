using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer Hammeri = new Hammer(2);
            Wrench Wrenchi = new Wrench(2);
            Drill Drilli = new Drill(2);
            Saw Sawi = new Saw(2);
            Screwdriver Screwdriveri = new Screwdriver(2);
            PipeCutter PipeCutteri = new PipeCutter(2);
            WireStripper WireStripperi = new WireStripper(2);
            NailGun NailGuni = new NailGun(2);
            ToolBox[] tolllisti = {Hammeri, Wrenchi, Drilli, Sawi, Screwdriveri, PipeCutteri, NailGuni,WireStripperi};
            foreach (ToolBox tool in tolllisti)
            {
                tool.Describe();
                tool.Use();
            }
        }
    }
}
