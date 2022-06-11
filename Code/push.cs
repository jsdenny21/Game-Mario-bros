using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    Animator press;
    void Start()
    {
        press = GetComponent<Animator>();
    }

    // Update is called once per frame
    void pres()
    {
        press.SetTrigger("isTRIGGER");
    }
}
