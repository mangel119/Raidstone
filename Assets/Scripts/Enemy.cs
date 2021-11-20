using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioSource playSound;
    public float health = 100;
    public void TakeDamage(float damage)
    {
        playSound.Play();
        health -= damage;
        if(health <= 0){
            Destroy(gameObject);
        }

    }
}