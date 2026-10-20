using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using TMPro;
using UnityEngine.UI;
public class HealthControlller : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI thealth;
    [SerializeField] private float health = 10;
    public float Health => health;
    public event Action<float> OnDamage;
    public event Action OnDie;        
    void Start()
    {
                            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)){               
            health = health - 1;
            thealth.text = health.ToString();
            image.fillAmount = health / 10f;
            OnDamage.Invoke(health);
            if (health <= 4 ) {
                OnDie.Invoke(); 
            }
        }
    }
}
