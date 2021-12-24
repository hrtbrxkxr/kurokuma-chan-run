using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float leftRightSpeed;

    public float maxSpeed;

    void Update()
    {
        if (moveSpeed < maxSpeed)
        {
            moveSpeed +=  0.2f * Time.deltaTime;
            leftRightSpeed +=  0.2f * Time.deltaTime;
        }
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
    }
}
