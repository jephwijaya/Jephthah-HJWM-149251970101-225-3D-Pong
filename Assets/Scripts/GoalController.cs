using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoalController : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    public int playernumber, duration;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Ball"))
        {
            BallController ball = collision.GetComponent<BallController>();
            switch(playernumber)
            {
                case 1:
                manager.AddpOneScore(1);
                break;

                case 2:
                manager.AddpTwoScore(1);
                break;

                case 3:
                manager.AddpThreeScore(1);
                break;

                case 4:
                manager.AddpFourScore(1);
                break;
            }
            ball.RemoveGoaledBall();
            onTriggerEnter.Invoke();
        }        
    }
}
