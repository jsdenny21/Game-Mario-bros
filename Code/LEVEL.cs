using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LEVEL : MonoBehaviour
{
    public GameObject[] button;
    public GameObject[] button2;
    public GameObject[] button3;
    int but=0;
    int but2 = 0;
    int but3 = 0;


    private void Start()
    {
        
        but = button.Length;
        but2 = button2.Length;
        but3 = button3.Length;
        checkprogress();
    }
    public void Stage11()
    {
        
        SceneManager.LoadScene("Stage 1.1");
    }
    public void Stage12()
    {
        SceneManager.LoadScene("Stage 1.2");
    }
    public void Stage13()
    {
        SceneManager.LoadScene("Stage 1.3");
    }
    public void Stage21()
    {
        SceneManager.LoadScene("Stage 2.1");
    }
    public void Stage22()
    {
        SceneManager.LoadScene("Stage 2.2");
    }
    public void Stage23()
    {
        SceneManager.LoadScene("Stage 2.3");
    }
    public void Stage31()
    {
        SceneManager.LoadScene("Stage 3.1");
    }
    public void Stage32()
    {
        SceneManager.LoadScene("Stage 3.2");
    }
    public void Stage33()
    {
        SceneManager.LoadScene("Stage 3.3");
    }
    public void back()
    {
        SceneManager.LoadScene("StageSelect");
    }

    void checkprogress()
    {
      for(int i=0;i<but;i++)
      {
         if (i < SavePRogress.Ustage)
         {
            button[i].SetActive(true);
         }
         else
           button[i].SetActive(false);
      }
      for (int i = 3; i < but2+3; i++)
      {
        if (i < SavePRogress.Ustage)
        {
          button2[i-3].SetActive(true);
        }
        else
          button2[i-3].SetActive(false);
      }

      for (int i = 6; i < but3+6; i++)
      {
        if (i< SavePRogress.Ustage)
        {
          button3[i-6].SetActive(true);
        }
        else
          button3[i-6].SetActive(false);
      }

    }
}
