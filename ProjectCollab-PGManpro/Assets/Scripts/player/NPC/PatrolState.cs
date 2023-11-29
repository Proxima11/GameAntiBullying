using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : BaseState
{
    public int waypointIndex;
    public float waitTimer;


    public override void Enter()
    {
    }
    public override void Exit() {

    }
    public override void Perform(Animator anim)
    {
        PatrolCycle(anim);
    }

    public void PatrolCycle(Animator anim)
    {
        if(npc.Agent.remainingDistance < 0.2f)
        {
            anim.SetTrigger("TrBreath");
            waitTimer += Time.deltaTime;
            if (waitTimer > 5)
            {
                anim.ResetTrigger("TrBreath");
                anim.SetTrigger("TrWalk");
                if (waypointIndex < npc.path.waypoints.Count - 1)
                    waypointIndex++;
                else
                    waypointIndex = 0;
                npc.Agent.SetDestination(npc.path.waypoints[waypointIndex].position);
                waitTimer = 0;
            }
        }
    }
}
