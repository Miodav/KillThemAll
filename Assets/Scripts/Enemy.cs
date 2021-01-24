using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
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
        print("Un enemy est mort");

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Score1.score1 -= 1;
            print(Score1.score1);
        }

        else if ((SceneManager.GetActiveScene().buildIndex == 2))
        {
            Score2.score2 -= 1;
            print(Score2.score2);
        }

    }

}
