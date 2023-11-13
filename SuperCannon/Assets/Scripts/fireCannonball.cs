using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class fireCannonball : MonoBehaviour
{

    [SerializeField] protected float yspeed, xspeed;
    protected Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }



    // Start is called before the first frame update
    protected virtual void Start()
    {
        Vector2 myYfroce = new Vector2(0, yspeed);
        rb.AddForce(myYfroce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void horizontalProjrctile ()
    {
        rb.gravityScale = 0.98f;
        Vector2 myXforce = new Vector2(xspeed, 0);
        rb.AddForce(myXforce);
    }


    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
