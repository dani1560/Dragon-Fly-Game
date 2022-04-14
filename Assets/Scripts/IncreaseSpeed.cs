using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    public static int a;

    // Start is called before the first frame update
    void Start()
    {
        a = 30;
        InvokeRepeating("speed", 5f, 5f);
    }

    // Update is called once per frame
    void speed()
    {
        a = a + 5;
    }
}
