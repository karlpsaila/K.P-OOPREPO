using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : DefaultBullet
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        base.HorizontalProjectile();
    }




}
