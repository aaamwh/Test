using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontoller : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
