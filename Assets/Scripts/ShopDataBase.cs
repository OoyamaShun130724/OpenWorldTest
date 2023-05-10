using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
//アイテムショップに並ぶアイテムの配列
public class ShopDataBase : ScriptableObject
{
    public List<ConsumableObject> _consumablesItemList = new List<ConsumableObject>();
    public List<EquipmentObject> _equipmentObjects = new List<EquipmentObject>();
}
