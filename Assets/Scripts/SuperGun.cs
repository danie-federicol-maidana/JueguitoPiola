using UnityEngine;

public class SuperGun : IWeapon
{
    public void Shoot(GameObject bulletToFire, GameObject spawnPoint)
    {
        Object.Instantiate(bulletToFire, spawnPoint.transform.position, spawnPoint.transform.rotation);
        Object.Instantiate(bulletToFire, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}       
    