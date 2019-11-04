using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D char_RB;
    private WallFloorCollision col;
    
    [SerializeField] float jumpvelocity = 7;

    private void Start()
    {
        char_RB = GetComponent<Rigidbody2D>();
        col = GetComponent<WallFloorCollision>();
    }
    void FixedUpdate()
    {
        if (col.getOnGround() && Input.GetButtonDown ("Jump"))
        {
            char_RB.velocity = new Vector2(char_RB.velocity.x, 0);
            
            char_RB.velocity += Vector2.up * jumpvelocity;
        }
    }
}
