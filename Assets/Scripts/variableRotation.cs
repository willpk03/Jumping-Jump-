using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variableRotation : MonoBehaviour
{
    public float x;
    public Rigidbody2D rb;
    float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, x);
    }
}
