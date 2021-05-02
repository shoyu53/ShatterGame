using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private int _attack;

    /// <summary>
    /// 武器の一撃分のダメージを返す
    /// </summary>
    /// <returns></returns>
    public int GetAttack()
    {
        return _attack;
    }
}
