using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int ID;
    
    public void OnTriggerEnter(Collider other)
    {
        GameEvent.current.DoorTriggerEnter(ID);
    }
    public void OnTriggerExit(Collider other)
    {
        GameEvent.current.DoorTriggerExit(ID);
    }
}
