using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PersonajeDisparo : MonoBehaviour
{
    [SerializeField] private GameObject balaPersonaje;
    [SerializeField] private GameObject apuntadorPersonaje;
    
    private IArmas armas;
    private PistolaPersonaje pistolaPersonaje;
    private EscopetaPersonaje escopetaPersonaje;

    // private EscopetaPersonaje escopetaPersonaje;

    void Start()    
    {
        pistolaPersonaje = new PistolaPersonaje();
        escopetaPersonaje = new EscopetaPersonaje();
            
    }

   

    void Update()
    {

       
        if (Input.GetKeyDown(KeyCode.Q)) {
            armas = pistolaPersonaje;
            armas.Disparo(balaPersonaje, apuntadorPersonaje);       
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            armas = escopetaPersonaje;
            armas.Disparo(balaPersonaje, apuntadorPersonaje);

        }
    }

}
