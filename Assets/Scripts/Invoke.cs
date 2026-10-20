/*using UnityEngine;

public class Invoke : PlayerController
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform spawnPoint;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 6f)
        {
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            timer = 0f;
        }
    }
}*/