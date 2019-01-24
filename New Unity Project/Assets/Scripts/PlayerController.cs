using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float force = 1000.0f;
    private Rigidbody2D rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, force));
        }
    }

    void FixedUpdate(){
        float horiz = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        rigidbody2D.velocity = new Vector2(horiz * speed, rigidbody2D.velocity.y);

        //GetComponent<Rigidbody>().velocity = new Vector2(horiz, verti);
    }
}
