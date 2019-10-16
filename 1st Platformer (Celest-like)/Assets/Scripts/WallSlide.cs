using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSlide : MonoBehaviour
{
    [SerializeField] WallFloorCollision col;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float slideSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<WallFloorCollision>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (((col.getOnRightWall() && rb.velocity.x > 0 ) || (col.getOnLeftWall() && rb.velocity.x < 0)) && !col.getOnGround())
        {
            wSlide();
        }
    }

    private void wSlide()
    {
        bool pushingWall = false;

        if ((rb.velocity.x > 0 && col.getOnRightWall()) || (rb.velocity.x < 0 && col.getOnLeftWall()))
        {
            pushingWall = true;
        }

        float push = pushingWall ? 0 : rb.velocity.x;
        // IF PUSHINGWALL TRUE, THEN PUSH = 0 ; ELSE PUSH = RB.VELOCITY.X
        

        rb.velocity = new Vector2(push, -slideSpeed);
        
    }
}
