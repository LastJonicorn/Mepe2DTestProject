using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject bullet;

    void Update()
    {
        PauseMenu pauseMenu = FindFirstObjectByType<PauseMenu>();
        if (pauseMenu != null && pauseMenu.GameIsPaused) return;

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
