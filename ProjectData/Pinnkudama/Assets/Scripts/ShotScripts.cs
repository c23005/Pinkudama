using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScripts : MonoBehaviour
{
    public GameObject[] BulletPrefub;
    public float baseWidht;
    public float playerS;
    public float coolTime;
    public AudioSource shot;
    void Start()
    {
        coolTime = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        coolTime += Time.deltaTime;
        Right();
        Left();
    }
    public  void Shot()
    {
        if (coolTime <= 1.0f)
        {
            return;
        }
        else
        {
            GameObject bullet = (GameObject)Instantiate(SampleBullet(), transform.position, transform.rotation);
            coolTime = 0.0f;
            shot.Play();
        }

    }



    GameObject SampleBullet()
    {
        int index = Random.Range(0, BulletPrefub.Length);
        return BulletPrefub[index];
    }

    void Shot2()
    {
        enabled = true;
    }

    public void Right()
    {
            transform.Rotate(new Vector3(0, 0, -playerS));
        
    }

    public void Left()
    {
            transform.Rotate(new Vector3(0, 0, playerS));
        
    }

}
