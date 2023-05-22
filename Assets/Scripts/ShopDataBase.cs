using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
//�A�C�e���V���b�v�ɕ��ԃA�C�e���̔z��
public class ShopDataBase : MonoBehaviour
{
    public List<ConsumableObject> _consumablesItemList = new List<ConsumableObject>();
    public List<EquipmentObject> _equipmentObjects = new List<EquipmentObject>();
    public List<ItemObj> _itemObjs = new List<ItemObj>();
    public void Awake()
    {
        SetItemObjectList();
    }
    public void SetItemObjectList()
    {
        foreach (var itemdata in _consumablesItemList)
        {
            _itemObjs.Add(itemdata);
        }
        foreach (var itemdata in _equipmentObjects)
        {
            _itemObjs.Add(itemdata);
        }
    }
}

