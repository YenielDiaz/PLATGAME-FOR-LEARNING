using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D char_RB;


    [Range(1, 10)]
    [SerializeField] float jumpvelocity = 10;
    private void Start()
    {
        char_RB = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (Input.GetButtonDown ("Jump"))
        {
            char_RB.velocity = new Vector2(char_RB.velocity.x, 0);
            
            char_RB.velocity += Vector2.up * jumpvelocity;
        }
    }
}
