﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    public PlayerController playerController;
    // Start is called before the first frame update

    

    // Update is called once per frame
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            
            playerController.heartHandler(-1);
        }
    }
}
