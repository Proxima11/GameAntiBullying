using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    public StateMachine stateMachine;
    public abstract void Enter();
    public abstract void Exit();
    public abstract void Perform();
}
