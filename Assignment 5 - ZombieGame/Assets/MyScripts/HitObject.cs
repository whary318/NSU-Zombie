using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObject : MonoBehaviour
{
    public int health = 10;

    public void damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            if (gameObject.tag == "Cube")
                FindObjectOfType<UpdateCollectedBoxes>().collectBox();
            Destroy(gameObject);
        }
            
    }
}
