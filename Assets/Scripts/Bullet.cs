using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rgb2;
    public int damage = 20;
    //public GameObject ImpactEffect;
    // Start is called before the first frame update
    void Start()
    {
        rgb2.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.Damage(damage);
            //Instantiate(ImpactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
        //Destroy(ImpactEffect);

    }
}
