using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosion;
    public AudioSource playSound;
    public AudioSource explode;
    public float health = 100;
    public bool alreadyPlayed = false;
    public void TakeDamage(float damage)
    {
        playSound.Play();
        health -= damage;
        if(health <= 0){
            if (!alreadyPlayed)
            {
                explode.Play();
                alreadyPlayed=true;
                FindObjectOfType<Score>().IncreaseScore();
            }
            
            Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(gameObject,2.0f);
        }

    }
}