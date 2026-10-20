using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class meteoritoPadre : MonoBehaviour
{
    [SerializeField] private GameObject meteorito;
    [SerializeField] private GameObject meteorito2;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject spawnPoint2;
    void Start()    
    {
        meteoro();
    }

    // Update is called once per frame
    void Update()
    {
       


    }
    protected void meteoro() {
            Instantiate(meteorito, spawnPoint.transform.position, spawnPoint.transform.rotation);
            Instantiate(meteorito2, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
    }
}
