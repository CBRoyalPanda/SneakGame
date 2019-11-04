using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehavior : StateMachineBehaviour
{
   
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Referencing the script of the enemy
        GameObject theEnemy = GameObject.Find("EnemyGuard");
        EnemyBehavior enemyScript = theEnemy.GetComponent<EnemyBehavior>();
    }

    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        //Using the refrenced booleans it is able to change the booleans within the animation controller
        if (enemyScript.PlayerHeard == true)
        {
            animator.SetBool("isSeen"), true;
        }

        if (enemyScript.PlayerHeard == false)
        {
            animator.SetBool("isSeen"), false;
        }

        if (enemyScript.PlayerSeen == true)
        {
            animator.SetBool("IsHeard"), true;
        }

        if (enemyScript.PlayerSeen == false)
        {
            animator.SetBool("IsHeard"), false;
        }
    }

    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
