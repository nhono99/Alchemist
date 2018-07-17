using Alchemist.Scripts.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alchemist.Scripts
{
    interface ICharacter: IDamageable
    {
        double MP { get; set; }
        double Atk { get; set; }
        double Def { get; set; }
        double Spd { get; set; } //who attacks first

        List<ISkill> Skills { get; set; }
        void Attack(IDamageable target);
        //block
        //defend
        //dodge
        //retaliate
        void Dead();
    }
    //can be non living objects
    interface IDamageable
    {
        double HP { get; set; }
    }
   
}
