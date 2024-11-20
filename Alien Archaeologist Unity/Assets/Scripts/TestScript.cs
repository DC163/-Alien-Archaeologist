using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("jorking mm");
        transform.Rotate(0, 0, 180);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update: still jorking!");
        transform.Translate(0.1f, 0, 0);
    }
}
