using System;
using System.Collections.Generic;
using System.Text;

namespace Alchemist.Scripts.Elements
{
    public enum ElementType { Fire, Water, Wind, Earth, Space, Aether, //basic
                               Steam, Blaze, Wood, Ice, //advanced
                                Lava, Lightning, Breeze}; //hidden arts
    abstract class Element: IMixable
    {
        public void Mix()
        {

        }
        public string ElementName()
        {
            return "none";
        }

        public virtual string GetName()
        {
            return "none";
        }
    }
}
