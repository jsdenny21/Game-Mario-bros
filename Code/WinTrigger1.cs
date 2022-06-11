using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinTrigger1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public PlayerProgress progress;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
                gameManager.CompleteLevel();
            if (SceneManager.GetActiveScene().buildIndex - 5 == SavePRogress.Ustage)
            {
                progress.UpdateStage();
                //progress.UpdateCharacter();
                progress.SavePlayer();
            }
            Debug.Log(SavePRogress.Ustage);
            //progress.LoadPlayer();
        }
    }
}
