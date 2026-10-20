using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collisionFueg : MonoBehaviour
{
    int salud = 10;
    [SerializeField] private Image saludPJ;
    [SerializeField] private TextMeshProUGUI textoSalud;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D fuego) {
        if (fuego.gameObject.CompareTag("Player")) {
            salud--;
            textoSalud.text = salud.ToString();
            saludPJ.fillAmount = salud / 10f;
            //Destroy(gameObject);
            if(salud <= 0)
            {
                Derrota();
                
            }
        }
    }

    public void Derrota()
    {
        SceneManager.LoadScene("Derrota");
    }
}
