using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;
using Game.Engine.Skills.ExtraSkills;

namespace Game.Engine.Skills.SkillFactories
{
    class ExtraSkillsFactory : SkillFactory
    {       
        public Skill CreateSkill(Player player)
        {
            List<Skill> playerSkills = player.ListOfSkills;
            Skill known = CheckContent(playerSkills); 
            if (known == null) // no ExtraSkills known - we will return one of them
            {
                DamageBoost s1 = new DamageBoost();
                Rage s2 = new Rage();
                ShieldGuard s3 = new ShieldGuard();
                
                List<Skill> tmp = new List<Skill>();
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1); // check level requirements
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (s3.MinimumLevel <= player.Level) tmp.Add(s3);
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)]; // use Index.RNG for safe random numbers
            }
            else if (known.decoratedSkill == null) // a ExtraSkills has been already learned, use decorator to create a combo
            {
                DamageBoostDecorator s1 = new DamageBoostDecorator(known);
                RageDecorator s2 = new RageDecorator(known);
                ShieldGuardDecorator s3 = new ShieldGuardDecorator(known);
                List<Skill> tmp = new List<Skill>();
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1); // check level requirements
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (s3.MinimumLevel <= player.Level) tmp.Add(s3);
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)];
            }
            else return null; // a combo of ExtraSkills has been already learned - this factory doesn't offer double combos so we stop here
        }
        private Skill CheckContent(List<Skill> skills) // wrapper method for checking
        {
            foreach (Skill skill in skills)
            {
                if (skill is DamageBoost || skill is Rage || skill is ShieldGuard || skill is DamageBoostDecorator || skill is RageDecorator || skill is ShieldGuardDecorator) return skill;
            }
            return null;
        }
    }
}
