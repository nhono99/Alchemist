using System;
using System.Collections.Generic;
using System.Text;
using Alchemist.Scripts.Elements;

namespace Alchemist.Scripts.Skills
{
    //Simple Factory
    public static class SkillFactory
    {
        public static ISkill CreateSkill(ISkill a, ISkill b, ISkill c)
        {
            ElementType type = ElementFactory.GetNewElementType(a.ElementType, b.ElementType, c.ElementType);

            switch (type)
            {
                case ElementType.Fire:
                    //return random fire skill
                    return null;
                   
                case ElementType.Water:
                    //return random water skill
                    return null;
                //case ElementType.Wind:
                //    break;
                //case ElementType.Earth:
                //    break;
                //case ElementType.Space:
                //    break;
                //case ElementType.Aether:
                //    break;
                //case ElementType.Steam:
                //    break;
                //case ElementType.Blaze:
                //    break;
                //case ElementType.Wood:
                //    break;
                //case ElementType.Ice:
                //    break;
                //case ElementType.Lava:
                //    break;
                //case ElementType.Lightning:
                //    break;
                default:
                    return null;

            }
        }
       

    }
}
