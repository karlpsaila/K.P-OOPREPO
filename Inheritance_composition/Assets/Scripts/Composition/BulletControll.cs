using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControll : MonoBehaviour
{   
    Rigidbody2D rb;
    private FireUP gunFire;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gunFire = GetComponent<FireUP>();

        if (gunFire != null) gunFire.Fire(rb);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
