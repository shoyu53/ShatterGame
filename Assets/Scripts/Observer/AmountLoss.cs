using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountLoss : MonoBehaviour,IObserver
{
    //TODO UI表示とか

    public void Notify(object value)
    {
        EquipStatus es = (EquipStatus)value;
        int loss = es._price;
        //TODO 損害額のUI表示
    }

}
