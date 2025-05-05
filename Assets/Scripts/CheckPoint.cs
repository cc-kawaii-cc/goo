using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int checkPointIndex = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Respawner respawner = FindObjectOfType<Respawner>();
            if(respawner != null)
            {
                respawner.CheckPoint(checkPointIndex);
            }
            gameObject.SetActive(false);
        }
    }
}
