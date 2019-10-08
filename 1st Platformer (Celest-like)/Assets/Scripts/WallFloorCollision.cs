using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFloorCollision : MonoBehaviour
{
    [SerializeField] LayerMask background;
    [SerializeField] bool onGround, onWall;
    [SerializeField] float collisionRadius = 0.25f;
    [SerializeField] Vector2 bottomOffset, rightOffset, leftOffset;

    private Color gizmoColor = Color.red;


    // Update is called once per frame
    void Update()
    {
        onGround = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, collisionRadius, background);
        onWall = Physics2D.OverlapCircle((Vector2)transform.position + rightOffset, collisionRadius, background)
            || Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collisionRadius, background);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;

        var position = new Vector2[] { bottomOffset, leftOffset, rightOffset };

        Gizmos.DrawWireSphere((Vector2)transform.position + bottomOffset, collisionRadius);
        Gizmos.DrawWireSphere((Vector2)transform.position + rightOffset, collisionRadius);
        Gizmos.DrawWireSphere((Vector2)transform.position + leftOffset, collisionRadius);
    }

    public bool getOnWall()
    {
        return onWall;
    }

    public bool getOnGround()
    {
        return onGround;
    }
}
