The game code has been supplemented with the following classes:

1) Engine -> Monsters:
- ArcherSkeleton - weapon type: arrow, damage type: stab
- ArcherSkeletonEvolved - ArcherSkeleton with freeze
- Bear - weapon type: scrach, bite, damage type: incised
- BearEvolved - Bear with fire
- Witch - weapon type: magic wand, damage type: fire
- WitchEvolved - Witch with hurricane

a) Engine -> Monsters -> MonsterFactories:
- ArcherSkeletonFactory - it produces ArcherSkeletons or ArcherSkeletonsEvolved
- BearFactory - it produces Bear or BearEvolved
- WitchFactory - it producec Witch or WitchEvolved

2) Engine -> Items:
- GreatStaff - Magic Power higher by 0.1*strength and 14% lower damage
- RareStaff - Magic Power higher by 0.5*strength and 40% lower fire damage - 5 * magic power damage / 20
- EpicStaff - Magic Power higher by 2*Strength and (10% less damage if magic damage) or (45% less damage if other damage)

Item advantage scale:
GreatStaff < RareStaff < EpicStaff

a) Engine -> Items -> ItemFactories:
- StaffFactory - it produces Staff types /items

3) Engine -> Skills -> ExtraSkills:
- DamageBoost - it increases damage by 15%
- DamageBoostDecorator 
- Rage - 50 more damage with health < 40
- RageDecorator
- ShieldGuard - armor increase by 0.2 * player's stamina if precision is > 30
- ShieldGuardDecorator

a) Engine -> Skills -> SkillFactories:
- ExtraSkillsFactory - it produces skills

Newly created elements have been added, so it is possible to start the game
