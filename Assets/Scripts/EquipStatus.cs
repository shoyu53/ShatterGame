using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///破壊可能なオブジェクトに設定された情報
/// </summary>
public struct EquipStatus
{
    public string _objectName;
    public int _price;
    public int _hp;
    public ushort _id;

    public EquipStatus(string name, int price, int hp, ushort id)
    {
        this._objectName = name;
        this._price = price;
        this._hp = hp;
        this._id = id;
    }
}
