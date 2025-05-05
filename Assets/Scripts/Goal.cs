using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int scoreRequire;

    public GameManager gm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(other.GetComponent<PlayerController>().score < scoreRequire)
            {
                return;
            }

            Rigidbody2D player = other.GetComponent<Rigidbody2D>();
            player.velocity = Vector3.zero;
            player.gravityScale = 0f;
            player.position = transform.position;

            Debug.Log("You Win!!");
            gm.WinGame();
        }
    }

}
