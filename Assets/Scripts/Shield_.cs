using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_ : Item_
{
    public int AC;

    public Shield_(string name, int price, int AC) : base(name, price)
    {
        this.AC = AC;
    }
}
