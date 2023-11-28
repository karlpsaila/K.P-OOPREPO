using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFIring : MonoBehaviour
{
    public void Firecannon(GameObject mybullet)
    {
        if (mybullet != null)


        {
           // Instantiate(mybullet, this.transform.position, this.transform.rotation);
           mybullet.transform.position = this.transform.position;
            mybullet.transform.rotation = this.transform.rotation;
            mybullet.SetActive(true);
        }
    }


}
