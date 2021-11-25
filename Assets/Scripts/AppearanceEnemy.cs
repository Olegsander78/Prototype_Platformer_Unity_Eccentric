using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceEnemy : MonoBehaviour
{
    public List<GameObject> EnemyList = new List<GameObject>();
    public float DistanceToEnemy = 20f;
    public Transform PlayerTransform;

    private void Start()
    {
        //Выключаем всех врагов на старте
        for (int i = 0; i < EnemyList.Count; i++)
        {
            EnemyList[i].SetActive(false);
        }
    }

    
    void Update()
    {
        for (int i = 0; i < EnemyList.Count; i++)
        {            
            if (EnemyList[i] !=null)
            {                
                float floatDistanceToEnemy = Vector3.Distance(PlayerTransform.position, EnemyList[i].transform.position);
                if (floatDistanceToEnemy <= DistanceToEnemy)
                {
                    EnemyList[i].SetActive(true);
                }else
                {
                    EnemyList[i].SetActive(false);
                }            
            }else
            {
                EnemyList.Remove(EnemyList[i]);
            }
            
        }          
    }
}
