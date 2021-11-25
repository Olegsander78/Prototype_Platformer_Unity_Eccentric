using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnTrigger : MonoBehaviour
{
    public EnemyHealth EnemyHealth;
    public bool DieOnCollision;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.attachedRigidbody)
        {           
            if (other.attachedRigidbody.GetComponent<Bullet>())
            {
                EnemyHealth.TakeDamage(1);
                Destroy(other.attachedRigidbody.GetComponent<Bullet>().gameObject);
            }
        }
        if (DieOnCollision == true)
        {
            EnemyHealth.TakeDamage(1000);
        }
    }
}
