using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    public ShopDataBase _dataBase;
    Inventory _inventory;
    ItemObj _item;
    public int _id = -1;
    [SerializeField] Text str;
    public void PickItem()
    {
        _item = _dataBase._itemObjs[_id];
        _item.UseItem();
    }
}
