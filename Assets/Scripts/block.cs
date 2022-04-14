using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField]
    GameObject[] obj;
    int a;
    GameObject movingObject;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("hello", 1f, 3f);
       

    }

    // Update is called once per frame
    void Update()
    {

       
    }

    void hello()
    {
        movingObject = obj[Random.Range(0, obj.Length)];
        Instantiate(movingObject, gameObject.transform.position, gameObject.transform.rotation);
       
    }
}
