using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBoolScript : MonoBehaviour
{
    public Rigidbody boolRG;
    public float boolSpeed;
    public GameObject colorbox;

    void Start()
    {
        boolRG.AddForce(transform.up * boolSpeed);
        Destroy(gameObject, 1.0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BlueBox")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
