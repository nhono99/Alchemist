using System;
using System.Collections.Generic;
using System.Text;
using Alchemist.Scripts.Elements;

namespace Alchemist.Scripts.Skills
{
    //Simple Factory
    public static class SkillFactory
    {
        public static ISkill CreateSkill(ISkill a, ISkill b)
        {
            //test
            ElementType type = ElementFactory.GetNewElementType(a.ElementType, b.ElementType);
           
            switch (type)
            {
                case ElementType.Fire:
                    //return random fire skill
                    //test
                    return Fireball();
                    //return null;
                   
                case ElementType.Water:
                    //test
                    return Waterball();
                    //return random water skill
                    return null;
                case ElementType.Wind:
                    return WindSlash();
                case ElementType.Earth:
                    return EarthStomp();
                //case ElementType.Space:
                //    break;
                //case ElementType.Aether:
                //    break;
                case ElementType.Steam:
                    return SteamStream();
                case ElementType.Blaze:
                    return Blazer();
                case ElementType.Wood:
                    return WoodSlap();
                case ElementType.Ice:
                    return IceIceBaby();
                //case ElementType.Lava:
                //    break;
                //case ElementType.Lightning:
                //    break;
                default:
                    return null;

            }
        }

        public static ISkill Fireball()
        {
            return new ActiveAttackSkill("Fireball", "fires ball", ElementType.Fire, 100, TargetingType.Enemy, 2);
        }
        public static ISkill Waterball()
        {
            return new ActiveAttackSkill("Waterball", "waters ball", ElementType.Water, 100, TargetingType.Enemy, 2);
        }
        public static ISkill EarthStomp()
        {
            return new ActiveAttackSkill("EarthStomp", "earth stomp", ElementType.Earth, 100, TargetingType.Enemy, 2);
        }
        public static ISkill WindSlash()
        {
            return new ActiveAttackSkill("WindSlash", "wind slash", ElementType.Wind, 100, TargetingType.Enemy, 2);
        }
        public static ISkill Blazer()
        {
            return new ActiveAttackSkill("Blazer", "Blazerrr", ElementType.Blaze, 100, TargetingType.Enemy, 2);
        }
        public static ISkill SteamStream()
        {
            return new ActiveAttackSkill("SteamStream", "Steaming", ElementType.Steam, 100, TargetingType.Enemy, 2);
        }
        public static ISkill IceIceBaby()
        {
            return new ActiveAttackSkill("IceIceBaby", "IceIceBaby", ElementType.Ice, 100, TargetingType.Enemy, 2);
        }
        public static ISkill WoodSlap()
        {
            return new ActiveAttackSkill("WoodSlap", "Knock on wood", ElementType.Wood, 100, TargetingType.Enemy, 2);
        }
    }
}
