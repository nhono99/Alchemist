using System;
using System.Collections.Generic;
using System.Text;
using Alchemist.Scripts.Elements;

namespace Alchemist.Scripts.Skills
{
    //battle system must have battle phases, 1=buff/debuff, 2=combat, 3=buff/debuff
    public enum SkillType { Active, Passive }
    //Ally and Enemy can be more than one
    //for multiple row turn based include front, back row, column and adjacent targeting.
    //there should be targeting priority Like Ally=> DyingAlly, NextAlly, DebuffedAlly, StrongestAllyBasedOnHP,MP,ATK,DEF ETC.
    public enum TargetingType { Self, Ally, Enemy, RandomAlly, RandomEnemy, All }
                                
    //for turn based tactics or real time rpg
    //include range, walls, area, pierce

    public abstract class Skill : ISkill
    {
        public ElementType ElementType { get; }
        public SkillType SkillType { get; protected set; }
        public string Name { get; }
        public string Description { get; }
        public TargetingType TargetingType { get; protected set; }
        public int NumberOfTarget {
            get;set;
        }
        public Skill(string name, string description, ElementType elementType, TargetingType targetingType, int targets)
        {
            Name = name;
            Description = description;
            ElementType = ElementType;
            TargetingType = targetingType;

           
            if(TargetingType == TargetingType.Self)
            {
                NumberOfTarget = 1;
            }
            else
            {
                NumberOfTarget = targets;
            }
          
        }
        public abstract void Cast();
    }
}
