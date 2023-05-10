using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
//�A�C�e���V���b�v�ɕ��ԃA�C�e���̔z��
public class ShopDataBase : ScriptableObject
{
    public List<ConsumableObject> _consumablesItemList = new List<ConsumableObject>();
    public List<EquipmentObject> _equipmentObjects = new List<EquipmentObject>();
}
