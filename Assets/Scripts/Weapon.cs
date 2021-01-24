using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject Bullet;
    private Animator anime;

    private void Start()
    {
        anime = GetComponent<Animator>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anime.SetTrigger("cast");
            Shoot();
        }
    }
    private void Shoot()
    {
        Instantiate(Bullet, Firepoint.position, Firepoint.rotation);
    }
}
