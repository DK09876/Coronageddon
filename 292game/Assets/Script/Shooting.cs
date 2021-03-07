using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public AmmoBar ammoBar;

    public float bulletForce = 20f;
    public int maxAmmo = 10;
    public int currentAmmo;

    Vector3 shootDirection;

    void Start()
    {
      currentAmmo = maxAmmo;
      ammoBar.SetMaxAmmo(maxAmmo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && currentAmmo > 0)
        {
          Shoot();
          currentAmmo--;
          ammoBar.SetAmmo(currentAmmo);
        }
    }

    void Shoot()
    {
      shootDirection = Input.mousePosition;
      shootDirection.z = 0.0f;
      shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
      shootDirection = shootDirection-transform.position;
      //...instantiating the rocket
      GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.Euler(new Vector3(0,0,0)));
      Rigidbody2D bulletInstance = bullet.GetComponent<Rigidbody2D>();
      bulletInstance.velocity = new Vector2(shootDirection.x * bulletForce, shootDirection.y * bulletForce);
    }

    public void refreshammo(){
      currentAmmo = maxAmmo;
      ammoBar.SetAmmo(currentAmmo);
    }
}
