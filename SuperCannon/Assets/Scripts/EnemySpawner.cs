using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public List<EnemySO> enemyList = new List<EnemySO>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int enemychoice = Random.Range(0, enemyList.Count);
            Vector3 enemypos = new Vector3(Random.Range(GameData.Xmin, GameData.Xmax), GameData.Ymax);
            GameObject enemyInstance = Instantiate(enemyList[enemychoice].enemyPrefab, enemypos, Quaternion.identity);
            enemyInstance.GetComponent<EnemyScript>().hitpoints = enemyList[enemychoice].hitpoints;  //push data from scriptable object to instance
            enemyInstance.GetComponent<EnemyScript>().start_strength = enemyList[enemychoice].strength;

            yield return new WaitForSeconds(1f);
        }

    }



}
