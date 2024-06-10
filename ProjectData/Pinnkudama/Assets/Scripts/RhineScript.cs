using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhineScript : MonoBehaviour
{
    Vector3 startPos;
    public float maxPos;
    public float speed;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = maxPos * Mathf.Sin(Time.time * speed);
        transform.position = startPos + new Vector3(x, 0, 0f);
        transform.rotation = Quaternion.identity;
    }
}
