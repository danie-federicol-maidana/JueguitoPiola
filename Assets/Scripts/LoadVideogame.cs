using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVideogame : MonoBehaviour
{
    public void CargarEscena(){
        SceneManager.LoadScene("Videogame");
    }
}
