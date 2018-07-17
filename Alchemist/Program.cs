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
            skill1.hp += 1;
            skill2.hp -= 1;
            Console.WriteLine(skill1.hp);
            Console.WriteLine(skill2.hp);
                
          
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
        }
    }
}
