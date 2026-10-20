using UnityEngine;
using UnityEngine.SceneManagement;      
public class Menu : MonoBehaviour
{
        
    public void StartGame() {
        SceneManager.LoadScene("Videogame");
    }

    public void Derrota()
    {
        SceneManager.LoadScene("Derrota");
        ScoreManager.Instance.AddScore(1);
    }
    public void Victoria()
    {
        SceneManager.LoadScene("Victoria");
        ScoreManager.Instance.AddScore(0);
    }
    public void Menus()
    {
        SceneManager.LoadScene("Menu");
    }
}

