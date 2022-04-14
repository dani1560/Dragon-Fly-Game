using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonControl : MonoBehaviour
{
    Animator anim;
    float yVelocity = 0.1f;
    float verticalAxis;
    [SerializeField]
    float dampness = 1;
    Camera cam1, cam2, cam3;
    LookAtCam lookAt;
    AudioSource audi;
    public int audioStatus;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
        lookAt = GameObject.Find("MainCamera").GetComponent<LookAtCam>();
        anim = GetComponent<Animator>();
        cam1 = GameObject.Find("MainCamera").GetComponent<Camera>();
        audi = GetComponent<AudioSource>();

      

    }

    private void LateUpdate()
    {
        if (audioStatus == 0)
        {
            audi.clip = Resources.Load<AudioClip>("Sounds/wings2");
            audi.Play();
            audioStatus = 1;

        }
        if(audioStatus == 2)
        {
            audi.clip = Resources.Load<AudioClip>("Sounds/dragonFly");
            audi.Play();
            audioStatus = 3;
        }
        if (audioStatus == 4)
        {
            audi.clip = Resources.Load<AudioClip>("Sounds/runing");
            audi.Play();
            audioStatus = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        verticalAxis = Input.GetAxis("Vertical");

    


        //Bringing Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (audioStatus == 1)
            {

                audioStatus = 4;

            }
            this.transform.position = new Vector3(0.06f, Mathf.Lerp(transform.position.y, 0f, Time.deltaTime * dampness),-4.66f);
         
            anim.Play("Run");
           
        }
        //upward 
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            if (audioStatus == 1) {

                audioStatus = 2;
            
            }

            this.transform.position = new Vector3(0.06f, Mathf.Lerp(transform.position.y, 2f, Time.deltaTime * dampness), -4.66f);
            anim.Play("Fly Float");
            
            lookAt.enabled = true;
            cam1.transform.position = new Vector3(0f, Mathf.Lerp( 1.025f, 2.5f, Time.deltaTime * dampness), -8.4f);
            


        }
        //idol state flying
        else
        {
            if (audioStatus == 3 || audioStatus == 5)
            {

                audioStatus = 0;

            }

            this.transform.position = new Vector3(0.06f, Mathf.Lerp(transform.position.y, 0.5f, Time.deltaTime * dampness + 0.01f), -4.66f);
            anim.Play("Fly Forward");
           

            if (lookAt.enabled == true)
            {
                float rotX = 4f;
                cam1.transform.rotation = Quaternion.Euler(rotX, 0f, 0f);
                cam1.transform.position = new Vector3(0f, Mathf.Lerp(2.5f, 1.025f, Time.deltaTime * dampness ), -8.4f);
                lookAt.enabled = false;
            }

         




        }
    }
}
