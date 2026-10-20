using UnityEngine;
using System.Collections.Generic;


public class SpawnFruit : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    [SerializeField] private List<GameObject> fruit = new List<GameObject>();
    [SerializeField] private List<GameObject> spawnPoints = new List<GameObject>();
    float timeUntilNextFruit = 4f;
    float timer = 0;
    float speed = 5f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > timeUntilNextFruit)
        {
            SpawnNewFruit();
            timer = 0;
        }

    }
    void SpawnNewFruit()
    {
        int random = Random.Range(0, fruit.Count);
        int random2 = Random.Range(0, spawnPoints.Count);
        GameObject newFruit = Instantiate(fruit[random], spawnPoints[random2].transform.position, transform.rotation);
        timeUntilNextFruit = Random.Range(1, 5);
       
    }

   
}
