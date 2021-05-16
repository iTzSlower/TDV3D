using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program_ : MonoBehaviour
{
    static Inventory_ inventory;


    static string respuesta;

    void Start()
    {
        inventory = new Inventory_();

        MainMenu();
    }

    static void MainMenu()
    {
        Debug.ClearDeveloperConsole();
        Debug.Log("Inventory");
        Debug.Log("=========");
        Debug.Log("1- List");
        Debug.Log("2- Add");
        Debug.Log("3- Remove");
        Debug.Log("0- Exit");
        string opt = respuesta;
        switch (opt)
        {
            case "1":
                inventory.Print();
                opt = respuesta;
                MainMenu();
                break;

            case "2":
                AddItem();
                break;

            case "3":
                RemoveItem();
                break;

            case "0":
                break;
        }
    }
    static void AddItem()
    {
        Sword_ longsword = new Sword_("Longsword", 15, 3);
        Sword_ greatsword = new Sword_("Greatsword", 50, 5);

        Shield_ buckler = new Shield_("Buckler", 5, 1);
        Armor_ chainmail = new Armor_("Chainmail", 15, 3);

        Item_ item = null;

        Debug.ClearDeveloperConsole();
        Debug.Log("Add Item");
        Debug.Log("===========");
        Debug.Log("1- Longsword");
        Debug.Log("2- Greatsword");
        Debug.Log("3- Buckler");
        Debug.Log("4- Chainmail");
        Debug.Log("0- Exit");

        string itemId = respuesta;
        switch (itemId)
        {
            case "1":
                item = longsword;
                break;

            case "2":
                item = greatsword;

                break;

            case "3":
                item = buckler;
                break;

            case "4":
                item = chainmail;
                break;

            case "0":
                break;
        }

        if (item != null)
            inventory.Add(item);

        MainMenu();
    }
    static void RemoveItem()
    {
        Debug.ClearDeveloperConsole();
        Debug.Log("Remove Item");
        Debug.Log("===========");

        Debug.Log("Item id: ");

        int itemId = int.Parse(respuesta);

        inventory.Remove(itemId);
        MainMenu();
    }
}
