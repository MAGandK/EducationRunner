using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBace : MonoBehaviour
{
    public abstract StateType StateType
    {
        get;
    }

    public abstract void Enter(); //нового активного состояния.

    public abstract void Tick();

    public abstract void Exit(); //Когда машина состояний выполняет переход между состояниями, мы вызываем мы вызываем Exit для предыдущего состояния
}
