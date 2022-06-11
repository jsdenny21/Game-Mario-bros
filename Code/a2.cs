using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a2 : MonoBehaviour
{

    public float speed;
    public int startingPoint;
    public Transform[] points;
    bool up= true;
    bool down = true;
    bool up1 = true;
    public bool fire = false;

    public bool LR = true;
    public bool k = true;
    int rot = 0;
    float rota = -90f;

    float start;

    private int i;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startingPoint].position;
        start = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if(Vector2.Distance(transform.position,points[i].position)<0.02f
            )
        {
            i++;
            if (points.Length > 2 && fire)
                Flip(false, 1);
            if (i==points.Length)
            {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

        if (points.Length < 3 && fire)
        {
            if (start < transform.position.y)
            {
                Flip(up,0);
                start = transform.position.y;
            }
            else if (start > transform.position.y)
            {
                Flip(!up,0);
                start = transform.position.y;
            }
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }

    private void Flip(bool up,int a)
    {
        // Multiply the player's x local scale by -1.
        if (a == 0)
        {
            if (up)
            {
                if (up1)
                {
                    Vector3 theScale = transform.localScale;
                    theScale.y *= -1;
                    transform.localScale = theScale;
                    down = true;
                    up1 = false;
                    LR = false;
                }
            }
            else
            {
                if (down && LR == false)
                {
                    Vector3 theScale = transform.localScale;
                    theScale.y *= -1;
                    transform.localScale = theScale;
                    down = false;
                    up1 = true;
                }
            }
        }
        else
        {

                rota -= 90f;
                transform.rotation = Quaternion.Euler(0f, 0f, rota);
        
        }

    }

}
