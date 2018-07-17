using System;
using System.Collections.Generic;
using System.Text;

namespace Alchemist.Scripts.Elements
{
    public static class ElementFactory
    {
        public static ElementType GetNewElementType(ElementType a, ElementType b)
        {
            if (a.Equals(ElementType.Fire) && b.Equals(ElementType.Fire)) return ElementType.Fire;
            if (a.Equals(ElementType.Earth) && b.Equals(ElementType.Earth)) return ElementType.Earth;
            if (a.Equals(ElementType.Water) && b.Equals(ElementType.Water)) return ElementType.Water;
            if (a.Equals(ElementType.Wind) && b.Equals(ElementType.Wind)) return ElementType.Wind;
            //advanced
            if(a.Equals(ElementType.Fire) && b.Equals(ElementType.Water))
            {
                return ElementType.Steam;
            }
            else if (a.Equals(ElementType.Fire) && b.Equals(ElementType.Wind))
            {
                return ElementType.Blaze;
            }
            else if (a.Equals(ElementType.Water) && b.Equals(ElementType.Earth))
            {
                return ElementType.Wood;
            }
            else if (a.Equals(ElementType.Water) && b.Equals(ElementType.Wind))
            {
                return ElementType.Ice;
            }
            //secret arts
            //if(c != null)
            //{
            //    if (a.Equals(ElementType.Steam) && b.Equals(ElementType.Water) && c.Equals(ElementType.Ice))
            //    {
            //        return ElementType.Lightning;
            //    }
            //    else if (a.Equals(ElementType.Wood) && b.Equals(ElementType.Water) && c.Equals(ElementType.Earth))
            //    {
            //        return ElementType.Breeze;
            //    }
            //    else if ((a.Equals(ElementType.Fire) || a.Equals(ElementType.Blaze)) && b.Equals(ElementType.Water) && c.Equals(ElementType.Earth))
            //    {
            //        return ElementType.Lava;
            //    }
            //}
         

            return ElementType.Aether;
        }
    }
}
