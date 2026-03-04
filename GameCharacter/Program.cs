using System;

// README.md를 읽고 코드를 작성하세요.
Character character = new Character();
character.Name = "용사";

Monster monster = new Monster("슬라임", 30, 5);
Monster monster2 = new Monster("고블린", 50, 10);


Console.WriteLine("=== 전투 시작 ===\n");
ProcessBattle(character, monster);
ProcessBattle(monster, character);
ProcessBattle(character, monster);
Console.WriteLine();

Console.WriteLine("=== 고블린 등장 ===\n");
ProcessBattle(character, monster2);
ProcessBattle(monster2, character);
ProcessBattle(character, monster2);
ProcessBattle(character, monster2);


void ProcessBattle(IAttacker attacker, IDefender defender)
{
        attacker.Attak(defender);
}




