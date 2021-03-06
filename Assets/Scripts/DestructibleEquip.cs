﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//破壊可能なオブジェクト用
public class DestructibleEquip :MonoBehaviour,IObservable,IGetEquipStatus
{
    [SerializeField] private string _objectName;
    [SerializeField] private int _price;
    [SerializeField] private int _hp;
    [SerializeField] private ushort _id;

    //GameManagerから代入、プレイヤーが装備している武器を装備
    static private GameObject _weaponObj;
    static private Weapon _weapon;

    //GameManagerから代入、オブジェクトの状態を通知する
    static private IObserver[] _observers;

    /// <summary>
    /// プレイヤーが装備中の武器を保持
    /// </summary>
    /// <param name="gameObject"></param>
    public static void SetWeapon(GameObject gameObject)
    {
        _weaponObj = gameObject;
        _weapon = _weaponObj.GetComponent<Weapon>();
    }

    /// <summary>
    /// static配列にオブサーバーを登録
    /// </summary>
    /// <param name="observers"></param>
    public static void SetObservers(IObserver[] observers)
    {
        _observers = observers;
    }

    /// <summary>
    ///obserberへ通知
    /// </summary>
    public void NotifyObserver()
    {
        foreach (var observer in _observers)
        {
            observer.Notify(GetStatus());
        }
    }

    /// <summary>
    /// 全ステータスを取得
    /// </summary>
    /// <returns></returns>
    public EquipStatus GetStatus()
    {
       return new EquipStatus(_objectName, _price, _hp, _id);
    }


    /// <summary>
    /// ダメージをくらったタイミングでのみ呼び出す
    /// </summary>
    /// <param name="attack"></param>
    private void Damage(int attack)
    {
        _hp -= attack;
    }


    void Start()
    {
        NotifyObserver();//テスト
    }

    private void OnCollisionEnter(Collision collision)
    {
        //攻撃するたびに武器側から破壊対象物(これ)をGetComponentせずに、
        //破壊対象物側に共通(static)で武器を持たせて、破壊対象物でダメージ処理を行う
        //GetComponent回数削減
        if (collision.gameObject==_weaponObj)
        {
            Damage(_weapon.GetAttack());

            if (_hp <= 0)
            {
                NotifyObserver();//壊れたことを通知
            }
        }
    }


}
