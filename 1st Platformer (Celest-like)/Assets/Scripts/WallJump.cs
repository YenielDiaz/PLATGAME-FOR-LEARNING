using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    private Rigidbody2D rb;
    private WallFloorCollision col;
    private WallSlide wSlide;
    private WallGrab wGrab;
//    [SerializeField] float delayTime = 0.5f;
    [SerializeField] float jumpvelocity = 7f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<WallFloorCollision>();
        wSlide = GetComponent<WallSlide>();
        wGrab = GetComponent<WallGrab>();

    }
    void FixedUpdate()
    {
        if (col.getOnWall() && Input.GetButtonDown("Jump"))
        {
            //Turn Off WallSlide pls :^);
            wSlide.enabled = false;

            wGrab.enabled = false;

            rb.velocity = new Vector2(rb.velocity.x, 0);

            rb.velocity += Vector2.up * jumpvelocity;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) && col.getOnWall())
        {
            wGrab.enabled = true;
        }


        if (rb.velocity.y < 0)
        {
            wSlide.enabled = true;
        }
    }
//    IEnumerator wSlideOn()
//    {
//        yield return new WaitForSeconds(delayTime);
//    }
}
