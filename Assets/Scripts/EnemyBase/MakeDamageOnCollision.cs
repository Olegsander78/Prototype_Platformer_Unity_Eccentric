using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageOnCollision : MonoBehaviour
{
    public EnemyHealth OwnHealth;
    public int DamageValue = 1;
    public bool DieOnMakeDamageYourself;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<PlayerHealth>())
            {
                collision.rigidbody.GetComponent<PlayerHealth>().TakeDamage(DamageValue);
            }
        }
        //Объект уничтожает себя при столкновении с другим объектом
        if (DieOnMakeDamageYourself == true)
        {
            OwnHealth.TakeDamage(100);
        }
    }
}
