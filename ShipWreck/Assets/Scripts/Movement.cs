using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.right = direction;


        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*speed, Input.GetAxisRaw("Vertical")*speed);

        if (Input.GetMouseButton(0))
        {
            anim.SetFloat("x", 1f);
        }
        else
        {
            anim.SetFloat("x", 0f);
        }

   
    }

  
}
