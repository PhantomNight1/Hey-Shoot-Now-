using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bulletprefab;
    public Transform Bulletfire;
    public float bulletforce = 50f;


    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetMouseButtonDown(0))
         {
             Instantiate(Bullet, Bulletfire.position, Bulletfire.rotation);

         }*/
        if (Input.GetKeyDown("o"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(Bulletprefab, Bulletfire.position, Bulletfire.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(Bulletfire.up * bulletforce, ForceMode2D.Impulse);
    }


}
