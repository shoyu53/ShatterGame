using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//破壊可能なオブジェクト用
public class DestructibleEquip :MonoBehaviour,IObservable,IGetEquipStatus
{
    [SerializeField] private string _objectName;
    [SerializeField] private string _price;
    [SerializeField] private float _hp;
    [SerializeField] private ushort _id;

    //GameManagerから代入、オブジェクトの状態を通知する
    static private IObserver[] _observers;

    private bool isShattered=false;

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

    public EquipStatus GetStatus()
    {
       return new EquipStatus(_objectName, _price, _hp, _id);
    }

    void Start()
    {
        NotifyObserver();//テスト
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
