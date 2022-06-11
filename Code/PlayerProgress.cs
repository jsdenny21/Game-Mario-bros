using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public int character;
    public int stage;

    void Start()
    {
        character =SavePRogress.Ustage;
        stage = SavePRogress.Ustage;
    }
    public void SavePlayer()
    {
        character = SavePRogress.Ustage;
        stage = SavePRogress.Ustage;
        SaveScript.SaveData(this);
    }
    public void LoadPlayer()
    {
        SavePRogress data = SaveScript.LoadData();
        if (SavePRogress.Ustage > 1)
        {
            SavePRogress.Ucharacter = PlayerPrefs.GetInt("SaveCharacter");
            SavePRogress.Ustage = PlayerPrefs.GetInt("SaveStage");
        }
        else if(SavePRogress.Ustage<=1)
        {
            SavePRogress.Ustage = 1;
            SavePRogress.Ucharacter = 1;
        }
        Debug.Log(PlayerPrefs.GetInt("SaveStage"));
        //SavePRogress.Ustage = 1;
        //SavePRogress.Ucharacter = 1;
    }
    public int UpdateStage()
    {
        SavePRogress.Ustage++;
        PlayerPrefs.SetInt("SaveStage", SavePRogress.Ustage);
        Debug.Log(stage + " "+ SavePRogress.Ustage);
        return SavePRogress.Ustage;
    }

}
