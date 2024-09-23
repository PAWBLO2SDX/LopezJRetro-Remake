using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MovementPM : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S, jump = KeyCode.W;
    public float speed = 10, jumpHeight = 15;

    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetKey() is for HOLDING a key
        // Input.GetKeyDown() is for PRESSING a key
        // Input.GetKey() is for RELEASING a key


        if (Input.GetKey(left))     // Check for the player HOLDING DOWN THE LEFT BUTTON
        {
            //Get the GameObject's Rigdbody2D component and set its velocity to the left at the given speed
            _rb.velocity = Vector2.left * speed;
        }

        if (Input.GetKey(right))    // Check for the player HOLDING DOWN THE RIGHT BUTTON
        {
            //Get the GameObject's Rigdbody2D component and set its velocity to the right at the given speed
            _rb.velocity = Vector2.right * speed;
        }
        if (Input.GetKey(up))     // Check for the player HOLDING DOWN THE LEFT BUTTON
        {
            //Get the GameObject's Rigdbody2D component and set its velocity to the left at the given speed
            _rb.velocity = Vector2.up * speed;
        }

        if (Input.GetKey(down))    // Check for the player HOLDING DOWN THE RIGHT BUTTON
        {
            //Get the GameObject's Rigdbody2D component and set its velocity to the right at the given speed
            _rb.velocity = Vector2.down * speed;


        }
        if (Input.GetKeyDown(jump))
        {
            // Get the GameObject Rigidbody2D component and set its velocity to be the up at given jump height
            _rb.velocity = Vector2.up * jumpHeight;
        }

    }
}

