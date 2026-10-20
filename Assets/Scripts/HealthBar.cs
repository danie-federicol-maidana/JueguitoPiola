using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private HealthControlller healthControlller;
    [SerializeField] private Image healthBar;


    void Start()
    {
        healthControlller.OnDamage += UpdateBar;
        
    }



    public void UpdateBar(float health)
    {
        healthBar.fillAmount = health / 10f;
    }

    public void OnDestroy()
    {
        healthControlller.OnDamage -= UpdateBar;

    }
}
