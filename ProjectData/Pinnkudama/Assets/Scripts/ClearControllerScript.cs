using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearControllerScript : MonoBehaviour
{
    public AudioSource click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToTitle()
    {
        SceneManager.LoadScene("TitleScene");

    }

    public void ToTitle2()
    {
        Invoke("ToTitle", 1.5f);
        click.Play();
    }

}
