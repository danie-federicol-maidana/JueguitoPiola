using UnityEngine;
using UnityEngine.SceneManagement;

public class portalDimentional : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player")){
            Easter();
        }
    }
            
    public void Easter()
    {
        SceneManager.LoadScene("EasterEgg");
    }
}
