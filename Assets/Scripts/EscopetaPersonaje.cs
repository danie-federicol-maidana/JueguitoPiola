using UnityEngine;

public class EscopetaPersonaje : IArmas
{
    
   public void Disparo(GameObject tipoBala, GameObject apuntador) {
        Object.Instantiate(tipoBala, apuntador.transform.position, apuntador.transform.rotation * Quaternion.Euler(0, 0, 6f));
        Object.Instantiate(tipoBala, apuntador.transform.position, apuntador.transform.rotation);
       
    }   
}
                    