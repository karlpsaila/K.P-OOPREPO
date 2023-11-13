using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBall : fireCannonball
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        base.horizontalProjrctile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
