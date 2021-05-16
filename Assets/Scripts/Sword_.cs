using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_ : Item_
{
    public int dmg;

    public Sword_(string name, int price, int dmg) : base(name, price)
    {
        this.dmg = dmg;
    }

    public void Attack() { }
}
