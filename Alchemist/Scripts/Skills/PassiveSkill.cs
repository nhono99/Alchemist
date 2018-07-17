using System;
using System.Collections.Generic;
using System.Text;
using Alchemist.Scripts.Elements;

namespace Alchemist.Scripts.Skills
{
    public abstract class PassiveSkill : Skill
    {
        public PassiveSkill(string name, string description, ElementType elementType, TargetingType targetingType, int targets) : 
            base(name, description, elementType, targetingType, targets)
        {
        }

        public override void Cast()
        {
            throw new NotImplementedException();
        }
    }
}
