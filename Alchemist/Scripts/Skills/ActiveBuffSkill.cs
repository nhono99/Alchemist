using System;
using System.Collections.Generic;
using System.Text;
using Alchemist.Scripts.Elements;

namespace Alchemist.Scripts.Skills
{
    //we dont want to show damage on skills that does not deal additional damage when used it is considered buff/debuff
    
    public class ActiveBuffSkill : ActiveSkill
    {
       
        public ActiveBuffSkill(string name, string description, ElementType elementType, TargetingType targetingType, int targets) :
            base(name, description, elementType, targetingType, targets)
        {
        }
    }
}
