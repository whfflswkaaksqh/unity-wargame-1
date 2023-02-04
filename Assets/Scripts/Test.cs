using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class Vector
{
    public float x, y;
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector test =  new Vector();

        test.x = 1.5f;
        test.y = 1.0f;

        Debug.Log(test.x + ", " + test.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
