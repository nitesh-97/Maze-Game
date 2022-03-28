using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoomTriggerArea : MonoBehaviour
{
    public int ID;
    public TMP_Text RoomText;
    [SerializeField]
    private float RoomNo;
    //When player enters initiate entry event with ID
    public void OnTriggerEnter(Collider other)
    {
        GameEvent.current.RoomTriggerEnter(ID);
        RoomText.text = "Room No -" + RoomNo;
    }
    //When player leaves initiate exit event with ID
    public void OnTriggerExit(Collider other)
    {
        GameEvent.current.RoomTriggerExit(ID);
        RoomText.text = "";
    }
}
