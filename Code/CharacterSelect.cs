using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterSelect : MonoBehaviour
{
    public static int player;
    int but;
    public GameObject[] button;
    // Start is called before the first frame update
    public void character1() {
        player = 0;
        PlayerPrefs.SetInt("player", player);
    }
    public void character2()
    {
        player = 1;
        PlayerPrefs.SetInt("player", player);
    }
    public void character3()
    {
        player = 2;
        PlayerPrefs.SetInt("player", player);
    }
    public int SelectedCharacter() {
        return player;
    }
    void Start()
    {
        player = 1;
        but = button.Length;
        check();
    }
    public void back() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(SavePRogress.Ustage);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void check()
    {
        if (SavePRogress.Ustage <=3)
        {
            button[0].SetActive(true);
            button[1].SetActive(false);
            button[2].SetActive(false);
        }
        else if (SavePRogress.Ustage >= 4 && SavePRogress.Ustage <= 6)
        {
            button[0].SetActive(true);
            button[1].SetActive(true);
            button[2].SetActive(false);
        }
        else if(SavePRogress.Ustage>=7)
        {
            button[0].SetActive(true);
            button[1].SetActive(true);
            button[2].SetActive(true);
        }
       
    }
}
