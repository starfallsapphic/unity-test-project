using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotY = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hi unity.");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("logging in the update loop era");
        transform.Rotate(0, rotY, 0);
    }
}
