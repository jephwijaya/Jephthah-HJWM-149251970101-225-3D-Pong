using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed, resetPosition;
    public float topSpeed1, topSpeed2 ;
    private Rigidbody rig;
    public BallSpawnerManager manager;

    private bool isPlayer1;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"  || collision.gameObject.tag == "Wall Corner" ||
            collision.gameObject.tag == "TFS Wall 1" || collision.gameObject.tag == "TFS Wall 2" ||
            collision.gameObject.tag == "TFS Wall 3" || collision.gameObject.tag == "TFS Wall 4")
        {
            if (rig.velocity.magnitude < topSpeed1)
            {
                rig.velocity = rig.velocity.normalized * topSpeed1;
            }
        }
        if (collision.gameObject.tag == "Ball")
        {
            rig.constraints = RigidbodyConstraints.FreezePositionY;

            if (rig.velocity.magnitude < topSpeed2)
            {
                rig.velocity = rig.velocity.normalized * topSpeed2;
            }
        }
        else if (collision.gameObject.tag == "Floor")
        {
            rig.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }

    public void RemoveGoaledBall()
    {
        manager.RemoveBall(gameObject);
    }
}
