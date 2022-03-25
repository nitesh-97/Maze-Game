using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float speed = 2.5f;
    public int ID; 
    // Add new Events
    void Start()
    {
        GameEvent.current.onDoorTriggerEnter += OnDoorOpen;
        GameEvent.current.onDoorTriggerExit += OnDoorExit;
    }

    //Opens the door when player is near
    public void OnDoorOpen(int ID)
    {
        if(ID == this.ID)
        {
            
            transform.position = new Vector3(transform.position.x, transform.position.y + 3.5f, transform.position.z);
        }
         
    }

    //Closes the door when player exits
    public void OnDoorExit(int ID)
    {
        if (ID == this.ID)
        {
            
            transform.position = new Vector3(transform.position.x, transform.position.y - 3.5f, transform.position.z);
        }
            
    }

    
}
