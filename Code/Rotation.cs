using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationZ;
    public float speed;
    public bool dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dir == false)
        {
            rotationZ += Time.deltaTime * speed;
        }
        else {
            rotationZ += Time.deltaTime * speed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }
}
