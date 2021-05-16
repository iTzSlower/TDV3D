using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_ : MonoBehaviour
{
    public int price;

    public Item_(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
    public Item_()
    {
        Debug.Log(">Item -> constructor");
    }

    public void Use() { }
}
