# C\#-course

**WPROWADZENIE**

Repozytorium zawiera zrealizowane zadania w C\# na przedmiot uniwersytecki "Projektowanie i tworzenie aplikacji obiektowych wysokiego poziomu". Wiedzę zdobytą w trakcie kursu (m.in wzorce projektowe, OOP) można było potem wykorzystać w praktyce tzn. poprzez stworzenie elementów gry RPG w rzeczywistej aplikacji. Podstawowy kod gry pochodzi z https://github.com/JakubChecinski/GameC 

**ZAWARTOŚĆ**

Folder _Lab_ zawiera zadania zrealizowane w ramach laboratorium, natomiast _Zad_ - zadania domowe.

- Lab1/Zad1 - _Podstawy C\#_
- Lab2/Zad2 - _Polimorfizm_
- Lab3/Zad3 - _UML i diagramy klas_
- Lab4/Zad4 - _Programowanie obiektowe w praktyce II_
- Lab5/Zad5 - _Metody fabryczne i fabryki abstrakcyjne_
- Lab6/Zad6 - _Kompozyty i dekoratory_
- Lab7/Zad7 - _Polecenia i adaptery_
- Lab8/Zad8 - _Obserwatorzy i strategie_

 <br /><br />
Folder _RPG_game_ zawiera 2 podfoldery:
- G1_G2 - do bazowej wersji kodu dodano nową grupę potworów, item'ów oraz umiejętności:
1. /Engine/Monsters:
- [ ] ArcherSkeleton
- [ ] ArcherSkeletonEvolved
- [ ] Bear
- [ ] BearEvolved
- [ ] Witch
- [ ] WitchEvolved 
2. /Engine/Monsters/MonsterFactories:
- [ ] ArcherSkeletonFactory
- [ ] BearFactory
- [ ] WitchFactory
3. /Engine/Items:
- [ ] GreatStaff
- [ ] RareStaff
- [ ] EpicStaff
4. /Engine/Items/ItemFactories:
- [ ] StaffFactory
5. /Engine/Skills/ExtraSkills:
- [ ] DamageBoost
- [ ] DamageBoostDecorator
- [ ] Rage
- [ ] RageDecorator
- [ ] ShieldGuard
- [ ] ShieldGuardDecorator
6. /Engine/Skills/SkillFactories:
- [ ] ExtraSkillsFactory


- G3_G4 - do bazowej wersji kodu dodano interakcje oraz fabrykę:
1. /Engine/Interactions/Built-In:
- [ ] BlacksmithEncounter
- [ ] FarmerEncounter
- [ ] IQueenStrategy
- [ ] PolicemanEncounter
- [ ] QueenAngryStrategy
- [ ] QueenEncounter
- [ ] QueenLovelyStrategy
- [ ] QueenNeutralStrategy
2. /Engine/Interactions/InteractionFactories:
- [ ] PeopleFactory
