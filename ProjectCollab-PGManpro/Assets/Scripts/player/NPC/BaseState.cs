using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    public NPCJalan npc;
    public StateMachine stateMachine;
    public abstract void Enter();
    public abstract void Exit();
    public abstract void Perform(Animator m, float timer);
}
