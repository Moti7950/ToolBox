using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    abstract class ToolBox
    {
        protected string _name;
        protected int _weightKG;

        public ToolBox(string name, int weightKG)
        {
            this._name = name;
            this._weightKG = weightKG;
        }

        public abstract void Describe();
        public abstract void Use();
        
    }
}
