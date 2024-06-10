using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KaabilScript : MonoBehaviour
{
    public GameObject kaabii;
    const int DefaltLife = 3;
    int life;
    public BoxsScript boxsScropt;
    public GameObject[] colorBox;
    private bool damage;
    public GameObject boxs;
    public AudioSource damegeBGM;

    // Start is called before the first frame update



    void Start()
    {
        life = DefaltLife;
        Seiti();
    }

    // Update is called once per frame
    void Update()
    {
        Clear();
        Damage();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bool")
        {
            damage = true;
            life--;
            Destroy(collision.gameObject);
        }
    }

    public void Clear()
    {
        if(life <= 0)
        {
            SceneManager.LoadScene("Clear");
            
        }
    
    }

    public void Damage()
    {
        if(damage == true)
        {
            //Destroy(boxs);
            damage = false;
            Invoke("Seiti2", 0.5f);
            boxsScropt.DestroyChildAll();
            damegeBGM.Play();
        }
    }





    void Seiti2()
    {
        Seiti();
    }


    public void Seiti()
    {
        for(int i = 0; i < 30;  i++)
        {
            int colorNum = UnityEngine.Random.Range(0, 3);
            float Xpos = 3.5f - ((i % 6) * 1.5f);
            float Zpos = 3.5f - (MathF.Floor(i / 6) * 1.5f);
            GameObject Box = Instantiate(colorBox[colorNum], new Vector3(Xpos, 0,Zpos), Quaternion.identity); 
            Box.transform.parent = boxs.transform;
        }
    }

}
