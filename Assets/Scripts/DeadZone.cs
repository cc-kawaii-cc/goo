using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private PlayerController player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(player == null)
            {
                player = other.GetComponent<PlayerController>();
            }
            player.Die();
        }
    }
}
