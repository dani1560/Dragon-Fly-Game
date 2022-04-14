using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallDestroy : MonoBehaviour
{
    GameObject DRAGON;

    private void Start()
    {
        DRAGON = GameObject.Find("DragonSoulEaterPurpleHP");
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject == DRAGON) {

            Destroy(DRAGON);
            SceneManager.LoadScene("Start 1");

        }
        
    }
}
