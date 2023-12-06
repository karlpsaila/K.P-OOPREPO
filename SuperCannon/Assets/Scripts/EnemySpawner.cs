using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public List<GameObject> enemyList = new List<GameObject>();

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
            Vector3 enemypos = new Vector3(Random.Range(GameData.Xmin,GameData.Xmax),GameData.Ymin);
            GameObject enemyInstance = Instantiate(enemyList[enemychoice], enemypos,Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
