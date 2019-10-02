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





        /*
         * 
         *            float dx = Input.GetAxisRaw("Horizontal");
                float dy = Input.GetAxisRaw("Horizontal");

                if (dx == 0 && Mathf.Abs(x) > 0)
                {
                    char_RB.velocity = new Vector2(0 , direction.y * speed);
                }
                    if (dy == 0 && Mathf.Abs(y) > 0)
                    {
                        char_RB.velocity = new Vector2(direction.x * speed, 0);
                    }

                        else
                        {
                            char_RB.velocity = new Vector2(direction.x * speed, direction.y * speed);
                        }


        */
        char_RB.velocity = new Vector2(direction.x * speed, direction.y * speed);

    }
}
