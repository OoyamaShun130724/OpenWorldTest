using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]
public class Inventory : MonoBehaviour
{
    ShopDataBase _dataBase;
    [SerializeField] Button _button;
    [SerializeField] GameObject _inventoryLis;
    //List<Button> _buttonLis = new List<Button>();
    public List<InventoryItem> inventories = new List<InventoryItem>();
    public void Start()
    {
        _dataBase = GameObject.FindObjectOfType<ShopDataBase>();
        //for (int i = 0; i < _dataBase._itemObjs.Count; i++)
        //{
        //    var tmpitem = Instantiate(_button);
        //    tmpitem.transform.SetParent(_inventoryLis.transform);
        //    Text str = tmpitem.GetComponentInChildren<Text>();
        //    str.text = _dataBase._itemObjs[i].ItemName;
        //    _buttonLis.Add(tmpitem);          
        //}
    }

    public void AddItem(ItemObj _getItem, int _count)
    {
        for (int i = 0; i < inventories.Count; i++)
        {
            if (inventories[i]._haveItem == _getItem || inventories.Count == 0)
            {
                inventories[i].CountUp(_count);
                break;
            }
            else if (i == inventories.Count - 1 && inventories[i]._haveItem != _getItem)
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
    public InventoryItem(ItemObj _Item, int _count)
    {
        _haveItem = _Item;
        _itemCount = _count;
    }
    public void CountUp(int Value)
    {
        _itemCount += Value;
    }
}

