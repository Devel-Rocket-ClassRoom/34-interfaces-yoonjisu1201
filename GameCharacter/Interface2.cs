using System;
using System.Collections.Generic;
using System.Text;

interface IAttacker
{
    int AttackPower { get; }

    void Attak(IDefender target);
}

