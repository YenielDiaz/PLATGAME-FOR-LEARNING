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
        if (col.getOnWall() && !col.getOnGround())
        {
            wSlide();
        }
    }

    private void wSlide()
    {
        rb.velocity = new Vector2(rb.velocity.x, -slideSpeed);
    }
}
