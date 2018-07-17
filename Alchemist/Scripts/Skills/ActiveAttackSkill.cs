using System;
using System.Collections.Generic;
using System.Text;
using Alchemist.Scripts.Elements;

namespace Alchemist.Scripts.Skills
{

    class ActiveAttackSkill : ActiveSkill, IAttackSkill
    {
        public double Damage { get; }
        //test
        public int hp = 10;
        public ActiveAttackSkill(string name, string description, ElementType elementType, double damage, TargetingType targetingType, int targets) :
            base(name, description, elementType, targetingType, targets)
        {
            Damage = damage;
          
        }

        //not useful here
        public ActiveAttackSkill Clone()
        {
            return new ActiveAttackSkill(Name, Description, ElementType, Damage, TargetingType, NumberOfTarget);
        }

      
    }
}
