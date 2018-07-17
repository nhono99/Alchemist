using System;
using System.Collections.Generic;
using System.Text;
using Alchemist.Scripts.Elements;
using Alchemist.Scripts;
namespace Alchemist.Scripts.Skills
{
    public interface ISkill
    {
        ElementType ElementType { get; }
        SkillType SkillType { get; }
        string Name { get; }
        string Description { get; }
        void Cast();
    }

    

    public interface IAttackSkill : ISkill
    {
        double Damage { get; }

       
    }
}
