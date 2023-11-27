using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CannonController : MonoBehaviour
{
  

    Quaternion clampRoationLow, clampRoationHigh;

    [SerializeField] GameObject bullet1Prefab;
    [SerializeField] GameObject bullet2Prefab;
    [SerializeField] float bulletFiringPeriod;

    Coroutine myFiringCoroutine1;
    Coroutine myFiringCoroutine2;   

    CannonFIring _firingInsatance;

    // Start is called before the first frame update
    void Start()
    {
        _firingInsatance = GetComponentInChildren<CannonFIring>();
        clampRoationLow = Quaternion.Euler(0f, 0f, -70f);
        clampRoationHigh = Quaternion.Euler(0f, 0f, +70f);
    }

    void Update()
    {
        PointAtMouse();
        
        if(Input.GetMouseButtonDown(0))
        {

            if (myFiringCoroutine1 ==null) myFiringCoroutine1 = StartCoroutine(Firecontinously(bullet1Prefab));
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopCoroutine(myFiringCoroutine1);
            myFiringCoroutine1 = null;
        }


        if (Input.GetMouseButtonDown(1))
        {
            if (myFiringCoroutine2 == null) myFiringCoroutine2= StartCoroutine(Firecontinously(bullet2Prefab));
        }
        if (Input.GetMouseButtonUp(1))
        {
            StopCoroutine(myFiringCoroutine2);
            myFiringCoroutine2 =null;
        }
    }

    IEnumerator Firecontinously(GameObject mybulletPrefab) 
    { 
        while (true)
        {
            _firingInsatance.Firecannon(mybulletPrefab);
            yield return new WaitForSeconds(bulletFiringPeriod);

        }
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

    
}
