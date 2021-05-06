using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤー用のステート
/// </summary>
public interface IPlayerState
{
    /// <summary>
    /// ステートを開始した時に呼ぶ
    /// </summary>
    /// <param name="owner"></param>
    /// <param name="prevState"></param>
    void OnEnter(PlayerBehaviour owner, IPlayerState prevState);

    /// <summary>
    /// ステート時にマイフレーム呼ぶ
    /// </summary>
    /// <param name="owner"></param>
    void OnUpdate(PlayerBehaviour owner);

    /// <summary>
    /// ステート終了時に呼ぶ
    /// </summary>
    /// <param name="owner"></param>
    /// <param name="nextState"></param>
    void OnExit(PlayerBehaviour owner,IPlayerState nextState);

}
