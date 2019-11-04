using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGrab : MonoBehaviour
{
    [SerializeField] bool wallGrab = false;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] WallFloorCollision col;
    [SerializeField] float climbSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<WallFloorCollision>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");

        wallGrab = col.getOnWall() && Input.GetKey(KeyCode.LeftControl);

        if (wallGrab)
        {
            rb.velocity = new Vector2(0, y * climbSpeed);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 1;
        }
    }    
}
