using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] player;
    public CharacterSelect selected;
    public GameObject SpawnPoint;
    public GameObject camera;
    int select = 1;
    // Start is called before the first frame update

    void Start()
    {
        select = PlayerPrefs.GetInt("player");
        Instantiate(player[select], SpawnPoint.transform.position, Quaternion.identity);
        camera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    

}
