using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor_ : Item_
{

    public int AC;

    public enum Type
    {
        Light,
        Medium,
        Heavy
    }
    public Type type = Type.Light;

    public Armor_(string name, int price, int AC) : base(name, price)
    {
        this.AC = AC;
    }
}
