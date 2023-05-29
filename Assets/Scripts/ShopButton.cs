using UnityEngine;
using UnityEngine.UI;
//データベースの何番目のアイテムのボタンが押されたか判定する
public class ShopButton : MonoBehaviour
{
    public int _ind = -1;
    public int _cost = -1;
    public ShopDataBase _shopDataBase;
    public GenerateShopItemList _gsl;
    [SerializeField] Button _button;
    public int returnindex()
    {
        return _ind;
    }
    public int returncost()
    {
        return _cost;
    }
    public void Pay()
    {
        _gsl._player._gold -= _cost;
        var tmpitem = Instantiate(_button);
        tmpitem.transform.SetParent(_gsl._Inventory.transform);
        Text str = tmpitem.GetComponentInChildren<Text>();
        str.text = _shopDataBase._itemObjs[_ind].ItemName;
    }
}
