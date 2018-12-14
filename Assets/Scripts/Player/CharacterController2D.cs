using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : CharacterStats
{
    private void Awake()
    {

    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Movement(MovementSpeed);
        FlipArt();
    }


    private void Movement(float speed)
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(x, y).normalized * speed;
    }

    private void FlipArt()
    {
        if (rb.velocity.x > 0 && artParent.localScale.x > 0 )
            artParent.localScale = new Vector3(-1, 1, 1);
        else if (rb.velocity.x < 0 && artParent.localScale.x < 0)
            artParent.localScale = Vector3.one;
    }
}
