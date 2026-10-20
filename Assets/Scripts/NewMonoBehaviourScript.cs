using UnityEngine;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> fruit = new List<GameObject>();
    [SerializeField] private List<GameObject> spawnPoints = new List<GameObject>();

    int timeUntilNextFruit = 10;
    float timer = 0;

    void Start()
    {
        // No ponemos el temporizador acá porque Start()
        // solamente se ejecuta una vez.
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeUntilNextFruit)
        {
            SpawnNewFruit();
            timer = 0;

            // Espera aleatoriamente entre 10 y 20 segundos
            timeUntilNextFruit = Random.Range(10, 20);
        }
    }

    void SpawnNewFruit()
    {
        int random = Random.Range(0, fruit.Count);
        int random2 = Random.Range(0, spawnPoints.Count);

        Instantiate(
            fruit[random],
            spawnPoints[random2].transform.position,
            transform.rotation
        );
    }
}