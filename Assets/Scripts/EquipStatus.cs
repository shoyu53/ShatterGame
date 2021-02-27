using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///破壊可能なオブジェクトに設定された情報
/// </summary>
public struct EquipStatus
{
    public string _objectName;
    public string _price;
    public float _hp;
    public ushort _id;

    public EquipStatus(string name, string price, float hp, ushort id)
    {
        this._objectName = name;
        this._price = price;
        this._hp = hp;
        this._id = id;
    }
}
