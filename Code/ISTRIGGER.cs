using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISTRIGGER : MonoBehaviour
{
    // Start is called before the first frame update
    Animator press;
    const string trigger = "T";
    void Start()
    {
        press = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("a");
        if (collision.gameObject.name == "SLICE")
        {
            press.SetTrigger("isTRIGGER");
        }
    }
}
