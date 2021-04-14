using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Goal")
        {
            Debug.Log("ゴール");
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ぶつかった");
    }
}
