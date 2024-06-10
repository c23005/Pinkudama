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
        //Ž©•ª‚ÌŽq‹Ÿ‚ð‘S‚Ä’²‚×‚é
        foreach (Transform child in gameObject.transform)
        {
            //Ž©•ª‚ÌŽq‹Ÿ‚ðDestroy‚·‚é
            Destroy(child.gameObject);
        }
    }
}
