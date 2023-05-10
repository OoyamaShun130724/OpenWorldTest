using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public List<InventoryItem> inventories = new List<InventoryItem>();
    public void AddItem(ItemObj _getItem, int _count)
    {
        for (int i = 0; i < inventories.Count; i++)
        {
            if (inventories[i]._haveItem == _getItem)
            {
                inventories[i].CountUp(_count);
                break;
            }
            else if (inventories[i]._haveItem != _getItem && i == inventories.Count - 1)
            {
                inventories.Add(new InventoryItem(_getItem, _count));
            }
        }
    }
    public void usedItem(ItemObj _usedItem)
    {
        for (int i = 0; i < inventories.Count; i++)
        {
            if (inventories[i]._haveItem == _usedItem)
            {
                inventories[i]._itemCount--;
                if (inventories[i]._itemCount == 0)
                {
                    inventories.RemoveAt(i);
                }
            }
        }
    }
}
[System.Serializable]
public class InventoryItem
{
    public ItemObj _haveItem;
    public int _itemCount;
    public InventoryItem(ItemObj _getItem, int _count)
    {
        _haveItem = _getItem;
        _itemCount = _count;
    }
    public void CountUp(int Value)
    {
        _itemCount += Value;
    }
}

