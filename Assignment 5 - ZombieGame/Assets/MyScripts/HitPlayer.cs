using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
            FindObjectOfType<GameRestart>().GameOver();
    }
}
