using UnityEngine;

public class PistolaPersonaje : IArmas
{
    
    public void Disparo(GameObject tipoBala, GameObject apuntador)
    {
        Object.Instantiate(tipoBala, apuntador.transform.position, apuntador.transform.rotation);
        
        
    }
}
        