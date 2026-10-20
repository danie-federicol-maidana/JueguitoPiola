using UnityEngine;
using System.Collections.Generic;


public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    [SerializeField] private List<GameObject> enemy = new List<GameObject>();
    [SerializeField] private List<GameObject> spawnPoints = new List<GameObject>();
    int timeUntilNextEnemy = 5; 
    float timer = 0; 
    float speed = 8;
    void Start()    
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > timeUntilNextEnemy)
        {
            SpawnNewFruit();
            timer = 0;
        }

    }
    void SpawnNewFruit()
    {
        int random = Random.Range(0, enemy.Count);
        int random2 = Random.Range(0, spawnPoints.Count);
        GameObject newFruit = Instantiate(enemy[random], spawnPoints[random2].transform.position, transform.rotation);
        timeUntilNextEnemy = Random.Range(1, 2);

    }


}
