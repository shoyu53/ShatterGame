using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PlayerBehaviour
{

    public class PlayerStateMoving : MonoBehaviour, IPlayerState
    {
        public void OnEnter(PlayerBehaviour owner)
        {
            Debug.Log("呼んだ！");
        }

        public void OnExit(PlayerBehaviour owner)
        {
            throw new System.NotImplementedException();
        }

        public void OnUpdate(PlayerBehaviour owner)
        {
            throw new System.NotImplementedException();
        }
    }
}
