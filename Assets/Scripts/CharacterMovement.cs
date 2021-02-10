using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public string hAxis;
    public string vAxis;

    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float h = Input.GetAxis(hAxis);
        float v = Input.GetAxis(vAxis);

        body.velocity = new Vector2(h,v) * 5;
    }
}
