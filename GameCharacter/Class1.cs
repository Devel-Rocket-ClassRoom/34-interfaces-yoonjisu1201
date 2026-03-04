using System;
using System.Collections.Generic;
using System.Text;

class Character : IAttacker, IDefender
{
    public string Name;
    public int CurrentHp { get; set; } = 100;
    public int MaxHp { get; } = 100;
    public bool IsDead { get; set; }
    public int AttackPower { get; } = 20;

    public override string ToString()
    {
        return Name;
    }

    public void Attak(IDefender target)
    {
        if (!target.IsDead)
        {
            Console.Write($"{Name}(이/가) {target}에게 {AttackPower} 대미지! ");
            target.TakeDamage(AttackPower);
        }
    }

    public void TakeDamage(int damage)
    {
        if (CurrentHp > damage)
        {
            CurrentHp -= damage;
            Console.WriteLine($"({Name} HP: {CurrentHp}/{MaxHp})");
        }
        else
        {
            CurrentHp = 0;
            IsDead = true;
            Console.WriteLine($"({Name} HP: 0/{MaxHp})");
            Console.WriteLine($"{Name}(이/가) 쓰러졌습니다!");
        }
    }
}
