using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region VARIABLES
    [Header("INVENTORY")]
    [Space(5)]
    public List<ItemData> itemInventory = new List<ItemData>();
    #endregion

    void AddItem(ItemData itemToAdd)
    {
        itemInventory.Add(itemToAdd);
    }

    void RemoveItem(ItemData itemToRemove)
    {
        itemInventory.Add(itemToRemove);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ItemData>())
        {
            AddItem(other.GetComponent<ItemData>());
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<ItemData>())
        {
            RemoveItem(GetComponent<ItemData>());
        }
    }
}
