using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestroyChildAll()
    {
        //自分の子供を全て調べる
        foreach (Transform child in gameObject.transform)
        {
            //自分の子供をDestroyする
            Destroy(child.gameObject);
        }
    }
}
