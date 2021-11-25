using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageOnTrigger : MonoBehaviour
{
    public EnemyHealth OwnHealth;
    public int DamageValue = 1;
    public bool DieOnMakeDamageYourself;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                other.attachedRigidbody.GetComponent<PlayerHealth>().TakeDamage(DamageValue);
            }
        }
        //������ ���������� ���� ��� ������������ � ������ ��������
        if (DieOnMakeDamageYourself == true)
        {
            OwnHealth.TakeDamage(100);
        }
    }
}
