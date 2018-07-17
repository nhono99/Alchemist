using System;
using Alchemist.Scripts.Elements;
using Alchemist.Scripts.Skills;
namespace Alchemist
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ActiveAttackSkill skill1 = new ActiveAttackSkill("Fireball", "fires ball", ElementType.Fire, 100, TargetingType.Enemy, 2);
            ActiveAttackSkill skill2 = skill1.Clone();
            ISkill skill3 = SkillFactory.CreateSkill(skill1, skill2);
            IAttackSkill skill3_attack = (IAttackSkill)skill3;
            skill1.hp += 1;
            skill2.hp -= 1;
            Console.WriteLine(skill1.hp);
            Console.WriteLine(skill2.hp);
            
            Console.WriteLine(skill3.ElementType);
            Console.WriteLine(skill3.Description);
            Console.WriteLine(skill3_attack.Damage);
            
            //todo create character
            //set character learned skills
            //set character 5 equipped skills
          
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
        }
    }
}
