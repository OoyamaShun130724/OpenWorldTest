using UnityEngine;

public abstract class ItemObj : ScriptableObject
{
    [SerializeField] GameObject _prefab;
    [Tooltip("")]public ItemType _type;
    [Header("�l�i"),Tooltip("")]�@public int _cost;
    [TextArea(10, 10)] public string description;
}
public enum ItemType
{
    Equipment,
    Consumable,
    //Passive
}
