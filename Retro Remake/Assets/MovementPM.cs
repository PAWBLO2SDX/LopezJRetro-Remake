using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MovementPM : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }
        if (Input.GetKey(right))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right;
        }
      

    }
}
