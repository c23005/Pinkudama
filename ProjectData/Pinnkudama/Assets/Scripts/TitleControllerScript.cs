using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleControllerScript : MonoBehaviour
{
    public AudioSource start;
    public AudioSource main;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void ToMain()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void Tomain2()
    {
        Invoke("ToMain", 1.0f);
        start.Play();
        main.Stop();
    }

}
