using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmory : MonoBehaviour
{
    public Gun[] Guns;
    public int CurrentGunIndex;

    // Start is called before the first frame update
    void Start()
    {
        TakeGunByIndex(CurrentGunIndex);
    }

    public void TakeGunByIndex(int gunIndex)
    {
        CurrentGunIndex = gunIndex;
        //if (gunIndex == 1 || gunIndex == 2)
        //{
        //    Guns[gunIndex].Activate();
        //}
        //else Guns[gunIndex].Deactivate();
        for (int i = 0; i < Guns.Length; i++)
        {
            if (i == gunIndex)
            {
                Guns[i].Activate();
            }
            else
            {
                Guns[i].Deactivate();
            }
        }

    }

    public void AddBullets(int gunIndex, int numberBullets)
    {
        Guns[gunIndex].AddBullets(numberBullets);
    }
}
