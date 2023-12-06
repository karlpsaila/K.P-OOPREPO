using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public int hitpoints;
    public int strenght;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Floor"))
        {
            GameData.PlayerHealth--;
            Debug.Log("Player Health" + GameData.PlayerHealth.ToString());
            Destroy(this.gameObject);
            
        }
    }
}
