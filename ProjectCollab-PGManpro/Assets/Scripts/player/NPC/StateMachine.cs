using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState activeState;
    public PatrolState patrolState;

    [SerializeField]
    private Animator mAnimator;
    [SerializeField]
    private float wait = 0;

    public void Initialise()
    {
        patrolState = new PatrolState();
        ChangeState(patrolState);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeState != null)
        {
            activeState.Perform(mAnimator, wait);
        }
    }
    public void ChangeState(BaseState newstate)
    {
        if (activeState != null)
        {
            activeState.Exit();
        }
        activeState = newstate;
        if (activeState != null)
        {
            activeState.stateMachine = this;
            activeState.npc = GetComponent<NPCJalan>();
            activeState.Enter();
        }
    }
}
