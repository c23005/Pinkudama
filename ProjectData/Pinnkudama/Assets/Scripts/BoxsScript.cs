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
        //�����̎q����S�Ē��ׂ�
        foreach (Transform child in gameObject.transform)
        {
            //�����̎q����Destroy����
            Destroy(child.gameObject);
        }
    }
}
