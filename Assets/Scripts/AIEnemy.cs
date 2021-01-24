using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{

    public int health = 80;
    //public GameObject deathEffect;

    public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        EnemyHasDied();
        //Instanciate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void EnemyHasDied()
    {
        print("Un enemy mort");
        Score1.score1 -= 1;
    }

}
