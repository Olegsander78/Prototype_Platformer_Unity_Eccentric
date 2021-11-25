using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Automat : Gun
{
    [Space(5)]
    [Header("Automat")]
    public int NumberOfBulletsAutomat;
    public Text AutomatBulletsText;
    public PlayerArmory PlayerArmory;

    public override void Shot()
    {
        base.Shot();
        NumberOfBulletsAutomat -= 1;
        UpdateTextAutomat();
        if (NumberOfBulletsAutomat == 0)
        {
            PlayerArmory.TakeGunByIndex(0);
        }
    }

    public override void Activate()
    {
        base.Activate();
        AutomatBulletsText.enabled = true;
        UpdateTextAutomat();

    }
    public override void Deactivate()
    {
        base.Deactivate();
        AutomatBulletsText.enabled = false;
    }

    void UpdateTextAutomat()
    {        
        AutomatBulletsText.text = "Автомат Пули: " + NumberOfBulletsAutomat.ToString();
    }

    public override void AddBullets(int numberBullets)
    {
        base.AddBullets(numberBullets);
        NumberOfBulletsAutomat += numberBullets;
        UpdateTextAutomat();
        PlayerArmory.TakeGunByIndex(1);
    }
}
