using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFIring : MonoBehaviour
{
    public void Firecannon(GameObject mybullet)
    {
        if (mybullet != null)
        {
            Instantiate(mybullet, this.transform.position, Quaternion.identity);
        }
    }


}
