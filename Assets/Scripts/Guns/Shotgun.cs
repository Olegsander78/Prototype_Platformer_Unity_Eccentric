using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shotgun : Gun
{
    [Space(5)]
    [Header("Shotgun")]
    public int NumberOfBullets;
    public Text BulletsText;
    public PlayerArmory PlayerArmory;
    public Transform[] SpawnTransform;
    //public AudioSource ShotgunSound;
    public GameObject[] FlashShotgun;
    public ParticleSystem[] ShotgunEffect;

    public override void Shot()
    {
        for (int i = 0; i < SpawnTransform.Length; i++)
        {            
            GameObject newBullet = Instantiate(BulletPrefab, SpawnTransform[i].position, SpawnTransform[i].rotation);
            newBullet.GetComponent<Rigidbody>().velocity = SpawnTransform[i].forward * base.BulletSpeed;
            Physics.IgnoreCollision(newBullet.GetComponent<Collider>(), newBullet.GetComponent<Collider>());
            FlashShotgun[i].SetActive(true);
            Invoke("HideFlashShotgun", 0.15f);
            ShotgunEffect[i].Play();
            base.ShotSound.Play();
            //ShotgunSound.Play();
        }
        NumberOfBullets -= 1;
        UpdateText();
        if (NumberOfBullets == 0)
        {
            PlayerArmory.TakeGunByIndex(0);
        }

    }
    public void HideFlashShotgun()
    {
        for (int i = 0; i < FlashShotgun.Length; i++)
        {
            FlashShotgun[i].SetActive(false);
        }        
    }

    public override void Activate()
    {
        base.Activate();
        BulletsText.enabled = true;
        UpdateText();

    }
    public override void Deactivate()
    {
        base.Deactivate();
        BulletsText.enabled = false;
    }

    void UpdateText()
    {        
        BulletsText.text = "Дробовик Пули: " + NumberOfBullets.ToString();
    }

    public override void AddBullets(int numberBullets)
    {
        base.AddBullets(numberBullets);
        NumberOfBullets += numberBullets;
        UpdateText();
        PlayerArmory.TakeGunByIndex(2);
    }
}
