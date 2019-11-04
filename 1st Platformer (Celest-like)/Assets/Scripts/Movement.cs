using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    Rigidbody2D char_RB;

    // Start is called before the first frame update
    void Start()
    {
     char_RB = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(x, y);

        Walk(direction);
    }

    private void Walk(Vector2 direction)
    {
        char_RB.velocity = new Vector2(direction.x * speed, char_RB.velocity.y);
    }

    public float getSpeed()
    {
        return speed;
    }
}   



