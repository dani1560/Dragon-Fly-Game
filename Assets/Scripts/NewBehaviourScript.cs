using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("speed :" + IncreaseSpeed.a);
        transform.Translate(Vector3.back * IncreaseSpeed.a * Time.deltaTime);
        if(gameObject.transform.position.z < -40)
        {
            Destroy(gameObject);
        }
    }
 
}
