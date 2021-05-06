using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PlayerBehaviour
{

    public class PlayerStateIdling : IPlayerState
    {
        public void OnEnter(PlayerBehaviour owner)
        {
            Debug.Log("停止");
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
