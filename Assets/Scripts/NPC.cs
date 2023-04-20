using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    [SerializeField] float bulletForce = 10f;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Shoot", 1f, 1f);
    }

    void Shoot()
    {
        // Shoot Right side
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rbR = bullet.GetComponent<Rigidbody>();
        rbR.AddForce(firePoint.right * bulletForce, ForceMode.Impulse);
    }
}
