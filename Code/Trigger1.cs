using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public GameObject trigger;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger active");
        if (collision.gameObject.name == "DoorTrigger")
        {
            Debug.Log("trigger door active");
            Destroy(door.gameObject);
        }

    }
}
