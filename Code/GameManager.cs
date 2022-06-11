using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float restartDelay = 1f;
    public GameObject WinUi;
    public GameObject DeathUI;
    float fireElapsedTime = 0;
    float fireDelay = 3f;
    float fireDelayD = 2f;
    bool win = false;
    bool death = false;
    public void EndGame()
    {
        //Debug.Log("Game Over");
        Invoke("Restart", restartDelay);
        DeathUI.SetActive(true);
        death = true;
    }
    public void CompleteLevel()
    {
        WinUi.SetActive(true);
        win = true;
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (win == true)
        {
            fireElapsedTime += Time.deltaTime;
            if (fireElapsedTime >= fireDelay)
            {
                if (SceneManager.GetActiveScene().buildIndex + 1 != 15)
                {
                    fireElapsedTime = 0;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    //SceneManager.GetSceneByName("StageSelect");
                }
                else
                {
                    fireElapsedTime = 0;
                    SceneManager.LoadScene("MainMenu");
                }
            }
        }
        if (death == true)
        {
            fireElapsedTime += Time.deltaTime;
            if (fireElapsedTime >= fireDelayD)
            {
                fireElapsedTime = 0;
                //SceneManager.GetSceneByName("StageSelect");
            }
        }
    }
    public bool deathh()
    {
        return death;
    }
}
