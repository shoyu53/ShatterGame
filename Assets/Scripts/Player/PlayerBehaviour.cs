using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PlayerBehaviour : MonoBehaviour
{

    //プレイヤーのステート
    private IPlayerState _currentState; 
    private static readonly PlayerStateMoving _stateMoving = new PlayerStateMoving();
    private static readonly PlayerStateIdling _stateIdling = new PlayerStateIdling();

    private Rigidbody _rBody;

    // Start is called before the first frame update
    void Start()
    {
        _rBody = this.gameObject.GetComponent<Rigidbody>();
        _currentState = _stateMoving;//初動から動作可能
        _currentState.OnEnter(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// プレイヤーのステート変更
    /// </summary>
    /// <param name="nextState"></param>
    private void ChangeState(IPlayerState nextState)
    {
        _currentState.OnExit(this);
        _currentState = nextState;
        _currentState.OnEnter(this);
        
    }
}
