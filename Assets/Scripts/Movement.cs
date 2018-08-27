using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D rigid;
    public Vector2 speed;

    // Use this for initialization
    void Start()
    {

        rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rigid.rotation = 90;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rigid.rotation = -90;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            rigid.rotation = 180;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigid.rotation = 0;
        }
        rigid.velocity = -transform.up * speed;
    }
}