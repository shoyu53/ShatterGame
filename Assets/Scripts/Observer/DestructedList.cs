using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructedList : MonoBehaviour,IObserver
{
    private List<DestructibleEquip> list;
    // Start is called before the first frame update
    void Start()
    {
        list = new List<DestructibleEquip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 破壊されたオブジェクトの通知を受け取る
    /// </summary>
    /// <param name="value"></param>
    public void Notify(object value)
    {
        EquipStatus es = (EquipStatus)value;
        Debug.Log(es._objectName+" "+es._price + " " + es._hp +" "+es._id+ " " + "通知を受け取った");
    }
}
