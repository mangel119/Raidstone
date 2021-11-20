using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticle : MonoBehaviour
{
    public float damage = 20f;
    public ParticleSystem particleSystem;
    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();
    public GameObject spark;
    
    private void Update() {
        
    }
    private void OnParticleCollision(GameObject other) {
        int events = particleSystem.GetCollisionEvents(other, colEvents);

        for (int i = 0; i < events; i++)
        {
            Instantiate(spark, colEvents[i].intersection, Quaternion.LookRotation(colEvents[i].normal));
        }
        if (other.transform.root.TryGetComponent(out Enemy en))
        {
            en.TakeDamage(damage);
        }
    }
}
