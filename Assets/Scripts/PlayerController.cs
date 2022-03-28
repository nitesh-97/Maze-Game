using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 moveDirection;
   
    void Update()
    {
        //Assign values everytime the keyboard keys(W,A,S,D) are pressed 
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        moveDirection = new Vector3(xDirection, 0f, zDirection);
        MovePlayer();
    }
   
    public void MovePlayer()
    {
        transform.position += moveDirection * 0.3f;
    }
}
