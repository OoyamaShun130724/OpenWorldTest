using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateShopItemList : MonoBehaviour
{
    ShopDataBase _dataBase;
    [SerializeField] Button _button;
    [SerializeField] GameObject _shopDataLis;
    public void Start()
    {
        _dataBase = GameObject.FindObjectOfType<ShopDataBase>();
        for (int i = 0; i < _dataBase._itemObjs.Count; i++)
        {
            var tmpitem = Instantiate(_button);
            tmpitem.transform.SetParent(_shopDataLis.transform);
            Text str = tmpitem.GetComponentInChildren<Text>();
            str.text = _dataBase._itemObjs[i].ItemName;
        }
    }
}
