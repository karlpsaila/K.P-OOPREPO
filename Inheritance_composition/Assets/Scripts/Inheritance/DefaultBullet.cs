using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class DefaultBullet : MonoBehaviour
{

    [SerializeField] protected float ySpeed, xSpeed;
    protected Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;

    }

    // Start is called before the first frame update
    protected virtual void Start()
    {   

  
        Vector2 myYforce = new Vector2(0,ySpeed);
        rb.AddForce(myYforce);

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    /* add a new method to:
     * 
     * 1. apply a force on the horizontal axis
     * 2. set gravity ot 0.98
     */

    protected void HorizontalProjectile()
    {
        rb.gravityScale = 0.98f;
        Vector2 myXforce = new Vector2(xSpeed, 0);
        rb.AddForce(myXforce);

    }
}
