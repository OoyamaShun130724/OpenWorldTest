using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
public class Inventory : MonoBehaviour
{
    ShopDataBase _dataBase;
    [SerializeField] Button _button;
    [SerializeField] GameObject _inventoryLis;
    public List<InventoryItem> _inventories;
    public Dictionary<int, Button> _buttonDic;
    public void Start()
    {
        _dataBase = GameObject.FindObjectOfType<ShopDataBase>();
        _buttonDic = new Dictionary<int, Button>();
        //for (int i = 0; i < _dataBase._itemObjs.Count; i++)
        //{
        //    if (_dataBase._itemObjs[i]._itemcount>0)
        //    {
        //        var tmpitem = Instantiate(_button);
        //        tmpitem.transform.SetParent(_inventoryLis.transform);
        //        _buttonDic.Add(i,tmpitem);
        //        Text str = tmpitem.GetComponentInChildren<Text>();
        //        str.text = _dataBase._itemObjs[i].ItemName + "Å~" + _dataBase._itemObjs[i]._itemcount;
        //    }
        //}
    }
    public void AddItem(ItemObj _getItem, int _count)
    {
        for (int i = 0; i < _inventories.Count; i++)
        {
            if (_inventories[i]._haveItem == _getItem || _inventories.Count == 0)
            {
                _inventories[i].CountUp(_count);
                break;
            }
            else if (i == _inventories.Count - 1 && _inventories[i]._haveItem != _getItem)
            {
                _inventories.Add(new InventoryItem(_getItem, _count));
            }
        }
    }
    public void usedItem(ItemObj _usedItem)
    {
        for (int i = 0; i < _inventories.Count; i++)
        {
            if (_inventories[i]._haveItem == _usedItem)
            {
                _inventories[i]._itemCount--;
                if (_inventories[i]._itemCount == 0)
                {
                    _inventories.RemoveAt(i);
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

