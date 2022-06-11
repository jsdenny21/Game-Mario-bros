using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathtrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          
            gameManager.EndGame();
        }
    }
}
