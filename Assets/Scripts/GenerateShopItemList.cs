using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateShopItemList : MonoBehaviour
{
    ShopDataBase _dataBase;
    [SerializeField] Button _button;
    [SerializeField] GameObject _shopDataLis;
    [SerializeField] public GameObject _Inventory;
    ShopButton _gbi;
    public Player _player;
    
    public void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
        _dataBase = GameObject.FindObjectOfType<ShopDataBase>();
        GenerateShopItemButton();
    }
    public void GenerateShopItemButton()
    {
        for (int i = 0; i < _dataBase._itemObjs.Count; i++)
        {
            var tmpitem = Instantiate(_button);
            tmpitem.transform.SetParent(_shopDataLis.transform);
            Text str = tmpitem.GetComponentInChildren<Text>();
            str.text = _dataBase._itemObjs[i].ItemName;
            _gbi = tmpitem.GetComponent<ShopButton>();
            _gbi._shopDataBase = _dataBase;
            _gbi._ind = i;            
            _gbi._cost = _dataBase._itemObjs[i]._cost;
            _gbi._gsl = this;
        }
    }
}
