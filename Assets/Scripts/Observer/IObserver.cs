using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    /// <summary>
    /// オブサーバーがオブサーバブルから通知を受け取る
    /// </summary>
    /// <param name="value"></param>
    void Notify(object value);
}
