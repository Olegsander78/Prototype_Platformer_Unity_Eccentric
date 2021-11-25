using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatchPrefabCreator : MonoBehaviour
{
    public GameObject Prefab;
    public Transform[] Spawns;

    [ContextMenu("Create")]
    public void Creator()
    {
        for (int i = 0; i < Spawns.Length; i++)
        {
            //Фикс бага смещения префаба по оси Z
            Vector3 SpawnXY = new Vector3(Spawns[i].position.x, Spawns[i].position.y, 0f);
            Instantiate(Prefab, SpawnXY, Spawns[i].rotation);
        }
    }
}
