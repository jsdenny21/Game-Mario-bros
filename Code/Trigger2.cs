using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public GameObject trigger;
    public GameObject obj;
    public Transform[] pos;
    int index;
    Transform next;
    private bool active;
    public float speed;
    Animator press;


    // Start is called before the first frame update
    void Start()
    {
        press = GetComponent<Animator>();
        next = pos[0];
        index = 0;
        active = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (active == true) {
            if (Input.GetKey(KeyCode.F)) {
                Move();
                press.SetTrigger("Push");
            }
        }
    }
    void Move()
    {
        if (obj.transform.position == pos[index].position )
        {
            index++;
            if (index == pos.Length)
            {
                index = 0;
            }
            Debug.Log(index);
            //Debug.Log(pos[index].position.x);
            //Debug.Log(pos[index].position.y);
            //Debug.Log(obj.transform.position.x);
            //Debug.Log(obj.transform.position.y);
        }
        else {
            obj.transform.position = Vector2.MoveTowards(obj.transform.position, pos[index].position, speed * Time.deltaTime);
        }
        //Debug.Log("pos index" + pos[index] +"\nindex " + index);
        //Debug.Log("index " + index);
        //Debug.Log("Post length " + pos.Length);
        //Debug.Log(pos[index].position.x);
        //Debug.Log(pos[index].position.y);
        //Debug.Log(obj.transform.position.x);
        //Debug.Log(obj.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.name == "Player")
        //{
        //    active = true;
        //    Debug.Log("active = true");
        //}
        //if (collision.gameObject.name == "Player(2)")
        //{
        //    active = true;
        //    Debug.Log("active = true");
        //}
        //if (collision.gameObject.name == "Player(3)")
        //{
        //    active = true;
        //    Debug.Log("active = true");
        //}
        if (collision.gameObject.tag == "Player")
        {
            active = true;
            Debug.Log("active = true");
        }
    }
}
