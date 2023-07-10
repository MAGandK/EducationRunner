using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class StateMachine : MonoBehaviour
{
    private List<StateBace> stateBaces;
    private StateBace _currentState; //тукущее состояние

    public void SwitchState(StateType stateType)
    {
        _currentState?.Exit();
    }

    private void Update()
    {
        _currentState?.Tick();
    }
}
