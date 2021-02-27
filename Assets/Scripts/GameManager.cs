using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _equipObserversObj; 

    void Awake()
    {
        //通知を送受するためにObserver(受信者)をobservable(送信者)に登録
        IObserver[] equipObservers = new IObserver[_equipObserversObj.Length];
        for(int i = 0; i < equipObservers.Length; i++)
        {
            equipObservers[i] = _equipObserversObj[i].GetComponent<IObserver>();
        }
        DestructibleEquip.SetObservers(equipObservers);
    }

    void Update()
    {
        
    }
}
