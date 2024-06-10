using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBoolScript : MonoBehaviour
{
    public Rigidbody boolRG;
    public float boolSpeed;
    public GameObject colorbox;

    void Start()
    {
        boolRG.AddForce(transform.up * boolSpeed);
        Destroy(gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GreenBox")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
