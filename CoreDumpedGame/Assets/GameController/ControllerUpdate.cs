using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerUpdate : MonoBehaviour
{
    public GameObject Player = GameObject.FindWithTag("Player");

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            GlobalVarsInit.pause = !GlobalVarsInit.pause;
            Player.GetComponent<Player>().enabled = !Player.GetComponent<Player>().enabled;           
        }
    }
}
