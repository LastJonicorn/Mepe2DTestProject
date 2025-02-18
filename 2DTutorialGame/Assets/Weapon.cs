using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject bullet;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, bulletPoint.position, transform.rotation);
    }
}
