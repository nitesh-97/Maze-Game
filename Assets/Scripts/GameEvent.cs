using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvent : MonoBehaviour
{
    public static GameEvent current;
    private void Awake()
    {
        current = this;
    }

    public event Action<int> onDoorTriggerEnter;
    public void DoorTriggerEnter(int ID)
    {
        if (onDoorTriggerEnter!= null)
        {
            onDoorTriggerEnter(ID);
        }
    }
    public event Action<int> onDoorTriggerExit;
    public void DoorTriggerExit(int ID)
    {
        if(onDoorTriggerExit != null)
        {
            onDoorTriggerExit(ID);
        }
    }
}
