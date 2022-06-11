using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    public int character = 0;
    public int stage = 0;
    public Data(PlayerProgress player)
    {
        character = player.character;
        stage = player.stage;
        SavePRogress.Ucharacter = character;
        SavePRogress.Ustage = stage;

    }

}
