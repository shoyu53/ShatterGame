using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseWeapon
{
    private GameObject _weapon;

    /// <summary>
    /// 装備する武器を指定
    /// </summary>
    /// <param name="weapon"></param>
    public void SetWeapon(GameObject weapon)
    {
        _weapon = weapon;
        DestructibleEquip.SetWeapon(_weapon);//破壊対象物側に今使っている武器を渡す
    }
}
