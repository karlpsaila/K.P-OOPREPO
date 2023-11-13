using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    Quaternion clampRoationLow, clampRoationHigh;
    // Start is called before the first frame update
    void Start()
    {
        clampRoationLow = Quaternion.Euler(0f, 0f, -70f);
        clampRoationHigh = Quaternion.Euler(0f, 0f, +70f);
    }

    void Update()
    {
        PointAtMouse();
        fire();
    }

    void PointAtMouse()
    {

        Quaternion newrotation = Quaternion.LookRotation(this.transform.position - GameData.MousePos, Vector3.forward);
        newrotation.x = 0f;
        newrotation.y = 0f;
        newrotation.z = Mathf.Clamp(newrotation.z,clampRoationLow.z,clampRoationHigh.z);
        newrotation.w = Mathf.Clamp(newrotation.w, clampRoationLow.w, clampRoationHigh.w);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 3f);
    }

    void fire()
    {
        if (Input.GetMouseButtonDown(0)) {

            Vector3 cannonPosition = this.transform.position;
            Quaternion cannonRotation = this.transform.rotation;

            Debug.Log("Boom");
            Instantiate(bullet,cannonPosition,cannonRotation);
        }
    }
}
