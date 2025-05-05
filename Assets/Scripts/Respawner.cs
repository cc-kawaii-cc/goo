using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public Rigidbody2D player;
    public Transform[] spawnPoints;
    public int spawnPointIndex = 0;

    public void Respawn()
    {
        player.velocity = Vector2.zero;
        player.angularVelocity = 0f;
        
        player.position = spawnPoints[spawnPointIndex].position;
    }

    public void CheckPoint(int index)
    {
        spawnPointIndex = index;
    }
}
