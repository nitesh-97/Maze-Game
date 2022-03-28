using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int ID;
    //When player enters initiate entry event with ID
    public void OnTriggerEnter(Collider other)
    {
        GameEvent.current.DoorTriggerEnter(ID);
    }
    //When player leaves initiate exit event with ID
    public void OnTriggerExit(Collider other)
    {
        GameEvent.current.DoorTriggerExit(ID);
    }
}
