using System;
using System.Collections.Generic;
using System.Text;

namespace Alchemist.Scripts.Elements
{
    class Lava:Element
    {
        new public string ElementName()
        {
            return "new Lava";
        }

        public override string GetName()
        {
            return "virtual Lava";
        }

        public void Flow()
        {
            Console.WriteLine("FLOW");
        }
    }
}
