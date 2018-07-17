using System;
using System.Collections.Generic;
using System.Text;
using Alchemist.Scripts.Elements;

namespace Alchemist.Scripts.Skills
{
    public abstract class ActiveSkill : Skill
    {
        public ActiveSkill(string name, string description, ElementType elementType, TargetingType targetingType, int targets) : 
            base(name, description, elementType, targetingType, targets)
        {
            SkillType = SkillType.Active;
        }

        public override void Cast()
        {
            
        }
    }
}
