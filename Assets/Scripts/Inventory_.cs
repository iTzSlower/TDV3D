using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_ : MonoBehaviour
{
    private List<Item_> _slots;

    public List<Item_> slots
    {
        get
        {
            return _slots;
        }
    }
    public Inventory_()
    {
        _slots = new List<Item_>();
    }
    public void Add(Item_ item)
    {
        _slots.Add(item);
    }
    public void Remove(int index)
    {
        _slots.RemoveAt(index);
    }
    public void Print()
    {
        Debug.Log("Inventory");

        //for (int i = 0; i < _slots.Count; i++)
        //{
        //    Console.WriteLine(_slots[i].name);
        //}

        foreach (Item_ item in _slots)
        {
            Debug.Log(item.name);
        }
    }
}
