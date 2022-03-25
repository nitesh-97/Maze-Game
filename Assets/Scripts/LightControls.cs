using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightControls : MonoBehaviour
{
    public GameObject RoomLight;
    public TMP_Text RoomText;
    [SerializeField]
    private float RoomNo;
  
    private void OnTriggerEnter(Collider other)
    {
        RoomText.text = "Room No -" + RoomNo;
        if(RoomLight != null)
        {
            RoomLight.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        RoomText.text = "";
       
        if (RoomLight != null)
        {
            RoomLight.SetActive(false);
        }
    }
    
    
}
