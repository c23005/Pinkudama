using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text Timertext;
    public float timer;
    


    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        Timertxt();
        Timer();
    }

    public void Timer()
    {
        if (timer <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void Timer2()
    {
        Invoke("Timer", 2.0f);
    }

    public void Timertxt()
    {
        timer -= Time.deltaTime;
        int timeInt = (int)timer;
        int mi;
        int se;

        mi = timeInt / 60;
        se = timeInt - (mi * 60);
        string ses;
        if (se <= 9)
        {
            ses = "0" + se;
        }
        else
        {
            ses = "" + se;
        }
        Timertext.text = mi + ":" + ses;

        if(timer <= 0)
        {
            Timertext.text = "0:00";
        }

    }


    

    

}
