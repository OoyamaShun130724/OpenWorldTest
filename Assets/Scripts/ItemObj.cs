using UnityEngine;

public abstract class ItemObj : ScriptableObject
{
    [SerializeField] GameObject _prefab;
    [Tooltip("")]public ItemType _type;
    [Header("’l’i"),Tooltip("")]@public int _cost;
    [TextArea(10, 10)] public string _description;
    [SerializeField] string _itemName;
    public int _itemcount =0;
    public string ItemName => _itemName;
}
public enum ItemType
{
    Equipment,//‘•”õ
    Consumable,//Á”ïŒ^
    //Passive
}
