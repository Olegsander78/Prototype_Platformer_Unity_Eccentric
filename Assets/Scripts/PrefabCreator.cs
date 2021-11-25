using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawn;
    
    public void Create()
    {
        //Фикс бага смещения префаба по оси Z
        Vector3 SpawnXY = new Vector3 (Spawn.position.x, Spawn.position.y, 0f);
        Instantiate(Prefab, SpawnXY, Spawn.rotation);
    }
}
