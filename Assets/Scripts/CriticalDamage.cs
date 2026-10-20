using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CriticalDamage : MonoBehaviour
{

    [SerializeField] private Image image;    
    [SerializeField] private HealthControlller healthControlller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthControlller.OnDamage += ActivateImage;
    }

    // Update is called once per frame
    void Update()       
    {
        ActivateImage(3);
    }
    public void ActivateImage(float health)
    {
        if(health <= 4)
        {
            image.enabled = true;
        }
        else
        {
            image.enabled = false;
        }
    }
}
