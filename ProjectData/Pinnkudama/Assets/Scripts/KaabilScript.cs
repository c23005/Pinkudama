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
        Seiti();
        life = DefaltLife;
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
        GameObject Box1 = Instantiate(colorBox[0], new Vector3(3.5f, 0.0f, 3.5f), Quaternion.identity);
        GameObject Box2 = Instantiate(colorBox[1], new Vector3(2.0f, 0.0f, 3.5f), Quaternion.identity);
        GameObject Box3 = Instantiate(colorBox[2], new Vector3(0.5f, 0.0f, 3.5f), Quaternion.identity);
        GameObject Box4 = Instantiate(colorBox[1], new Vector3(-1.0f, 0.0f, 3.5f), Quaternion.identity);
        GameObject Box5 = Instantiate(colorBox[0], new Vector3(-2.5f, 0.0f, 3.5f), Quaternion.identity);
        GameObject Box6 = Instantiate(colorBox[2], new Vector3(-4.0f, 0.0f, 3.5f), Quaternion.identity);
        GameObject Box7 = Instantiate(colorBox[0], new Vector3(3.5f, 0.0f, 2.0f), Quaternion.identity);
        GameObject Box8 = Instantiate(colorBox[1], new Vector3(2.0f, 0.0f, 2.0f), Quaternion.identity);
        GameObject Box9 = Instantiate(colorBox[2], new Vector3(0.5f, 0.0f, 2.0f), Quaternion.identity);
        GameObject Box10 = Instantiate(colorBox[1], new Vector3(-1.0f, 0.0f, 2.0f), Quaternion.identity);
        GameObject Box11 = Instantiate(colorBox[0], new Vector3(-2.5f, 0.0f, 2.0f), Quaternion.identity);
        GameObject Box12 = Instantiate(colorBox[2], new Vector3(-4.0f, 0.0f, 2.0f), Quaternion.identity);
        GameObject Box13 = Instantiate(colorBox[0], new Vector3(3.5f, 0.0f, 0.5f), Quaternion.identity);
        GameObject Box14 = Instantiate(colorBox[1], new Vector3(2.0f, 0.0f, 0.5f), Quaternion.identity);
        GameObject Box15 = Instantiate(colorBox[2], new Vector3(0.5f, 0.0f, 0.5f), Quaternion.identity);
        GameObject Box16 = Instantiate(colorBox[1], new Vector3(-1.0f, 0.0f, 0.5f), Quaternion.identity);
        GameObject Box17 = Instantiate(colorBox[0], new Vector3(-2.5f, 0.0f, 0.5f), Quaternion.identity);
        GameObject Box18 = Instantiate(colorBox[2], new Vector3(-4.0f, 0.0f, 0.5f), Quaternion.identity);
        GameObject Box19 = Instantiate(colorBox[0], new Vector3(3.5f, 0.0f, -1.0f), Quaternion.identity);
        GameObject Box20 = Instantiate(colorBox[1], new Vector3(2.0f, 0.0f, -1.0f), Quaternion.identity);
        GameObject Box21 = Instantiate(colorBox[2], new Vector3(0.5f, 0.0f, -1.0f), Quaternion.identity);
        GameObject Box22 = Instantiate(colorBox[1], new Vector3(-1.0f, 0.0f, -1.0f), Quaternion.identity);
        GameObject Box23 = Instantiate(colorBox[0], new Vector3(-2.5f, 0.0f, -1.0f), Quaternion.identity);
        GameObject Box24 = Instantiate(colorBox[2], new Vector3(-4.0f, 0.0f, -1.0f), Quaternion.identity);
        GameObject Box25 = Instantiate(colorBox[0], new Vector3(3.5f, 0.0f, -2.5f), Quaternion.identity);
        GameObject Box26 = Instantiate(colorBox[1], new Vector3(2.0f, 0.0f, -2.5f), Quaternion.identity);
        GameObject Box27 = Instantiate(colorBox[2], new Vector3(0.5f, 0.0f, -2.5f), Quaternion.identity);
        GameObject Box28 = Instantiate(colorBox[1], new Vector3(-1.0f, 0.0f, -2.5f), Quaternion.identity);
        GameObject Box29 = Instantiate(colorBox[0], new Vector3(-2.5f, 0.0f, -2.5f), Quaternion.identity);
        GameObject Box30 = Instantiate(colorBox[2], new Vector3(-4.0f, 0.0f, -2.5f), Quaternion.identity);
        
        Box1.transform.parent = boxs.transform;
        Box2.transform.parent = boxs.transform;
        Box3.transform.parent = boxs.transform;
        Box4.transform.parent = boxs.transform;
        Box5.transform.parent = boxs.transform;
        Box6.transform.parent = boxs.transform;
        Box7.transform.parent = boxs.transform;
        Box8.transform.parent = boxs.transform;
        Box9.transform.parent = boxs.transform;
        Box10.transform.parent = boxs.transform;
        Box11.transform.parent = boxs.transform;
        Box12.transform.parent = boxs.transform;
        Box13.transform.parent = boxs.transform;
        Box14.transform.parent = boxs.transform;
        Box15.transform.parent = boxs.transform;
        Box16.transform.parent = boxs.transform;
        Box17.transform.parent = boxs.transform;
        Box18.transform.parent = boxs.transform;
        Box19.transform.parent = boxs.transform;
        Box20.transform.parent = boxs.transform;
        Box21.transform.parent = boxs.transform;
        Box22.transform.parent = boxs.transform;
        Box23.transform.parent = boxs.transform;
        Box24.transform.parent = boxs.transform;
        Box25.transform.parent = boxs.transform;
        Box26.transform.parent = boxs.transform;
        Box27.transform.parent = boxs.transform;
        Box28.transform.parent = boxs.transform;
        Box29.transform.parent = boxs.transform;
        Box30.transform.parent = boxs.transform;

    }

}
