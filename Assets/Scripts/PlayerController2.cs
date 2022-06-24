using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    public KeyCode moveRight, moveLeft;

    private Rigidbody player_rig;

    // Start is called before the first frame update
    void Start()
    {
        player_rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool pressedRight = Input.GetKey(this.moveRight);
        bool pressedLeft = Input.GetKey(this.moveLeft);

        if (pressedRight)
        {
            player_rig.velocity = Vector3.forward * speed;
        }

        if (pressedLeft)
        {
            player_rig.velocity = Vector3.back * speed;
        }

        if (!pressedRight && !pressedLeft)
        {
            player_rig.velocity = Vector3.zero;
        }
    }
}
