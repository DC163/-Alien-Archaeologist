using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //the humble first line
        Debug.Log("heh heh heh heh");

        /* this is the second line
         * and this is the third */
        Debug.Log("You have my sword.");
        Debug.LogWarning("And my bow.");
        Debug.LogError("And no bitches.");
        transform.Rotate(0, 0, 180);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update: heh heh heh heh");
        transform.Translate(0.1f, 0, 0);
    }
}
