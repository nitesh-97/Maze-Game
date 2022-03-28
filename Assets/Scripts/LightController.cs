using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public int ID;
    
    // Add new Events every time the player enters or leaves the room
    void Start()
    {
        GameEvent.current.onRoomTriggerEnter += OnEnterRoom;
        GameEvent.current.onRoomTriggerExit += OnExitRoom;
    }

    //Turn On Lights when player enters the room
    public void OnEnterRoom(int ID)
    {
        if (ID == this.ID)
        {

            this.GetComponent<Light>().enabled = true;
        }

    }

    //Turn Off the Lights when player leaves the room
    public void OnExitRoom(int ID)
    {
        if (ID == this.ID)
        {

            this.GetComponent<Light>().enabled = false;
        }

    }
}
