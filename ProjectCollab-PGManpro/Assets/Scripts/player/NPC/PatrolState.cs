using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : BaseState
{
    public int waypointIndex=0;
    public float waitTimer;

    public override void Enter()
    {
    }
    public override void Exit() {

    }
    public override void Perform(Animator anim, float wait)
    {
        PatrolCycle(anim, wait);
    }

    public void PatrolCycle(Animator anim, float wait)
    {
        if (npc.Agent.remainingDistance < 0.1f)
        {
            anim.SetTrigger("TrBreath");
            waitTimer += Time.deltaTime;
            if (waitTimer > wait && MonoBehaviour.FindObjectOfType<DialogManager>().isDialogRunning == false)
            {
                anim.ResetTrigger("TrBreath");
                anim.SetTrigger("TrWalk");
                if (waypointIndex < npc.path.waypoints.Count - 1)
                    waypointIndex++;
                else
                    waypointIndex = 0;
                npc.Agent.SetDestination(npc.path.waypoints[waypointIndex].position);
                Debug.Log(npc.path.waypoints[waypointIndex].position);
                waitTimer = 0;
            }
        }
    }
}
