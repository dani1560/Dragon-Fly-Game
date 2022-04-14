using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSkyBox : MonoBehaviour
{
    float duration = 2.0f;
    public Material skybox1;
    public Material skybox2;
    public Material skybox3;

    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject smoke;
    public GameObject storm;

    public int i;
    public float exposure;
    public float time;
    
    AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
       

        cloud1.SetActive(false);
        cloud2.SetActive(false);
        storm.SetActive(false);

        RenderSettings.skybox = skybox1;
        exposure = 1;
        
        InvokeRepeating("changeSky", 30f, 30f);

        audioSrc = GetComponent<AudioSource>();
        audioSrc.clip = Resources.Load<AudioClip>("Sounds/night");
        audioSrc.Play();
    }

    private void FixedUpdate()
    {
        RenderSettings.skybox.SetFloat("_Exposure", exposure);
        if (i==1) {

            if (exposure > 0)
            {
                exposure -= 0.0001f * Time.time;
                audioSrc.volume = Mathf.Lerp(audioSrc.volume, 0f, 0.5f * Time.deltaTime);
            }
            else {

                i = 2;
            
            }
           
        }
        if (i == 2) {

            StartCoroutine(changeBox());

        }
        if (i == 3) {

            if (exposure < 1)
            {
                exposure += 0.0001f * Time.time;
                audioSrc.volume = Mathf.Lerp(audioSrc.volume, 1f, 0.5f * Time.deltaTime);
            }    
        }

      
       

    }

    // Update is called once per frame
    void changeSky()
    {
        i = 1;
    }

    IEnumerator changeBox() {

        if (RenderSettings.skybox == skybox1)
        {
            RenderSettings.skybox = skybox2;
            audioSrc.clip = Resources.Load<AudioClip>("Sounds/Morning-sound-effects-nature");
            audioSrc.Play();
            cloud1.SetActive(false);
            cloud2.SetActive(false);
            smoke.SetActive(false);
            storm.SetActive(false);

        }
       else if (RenderSettings.skybox == skybox2)
        {
            RenderSettings.skybox = skybox3;
            audioSrc.clip = Resources.Load<AudioClip>("Sounds/rainbgbackground");
            audioSrc.Play();
            cloud1.SetActive(true);
            cloud2.SetActive(true);
            smoke.SetActive(true);
            storm.SetActive(true);
        }

       else if (RenderSettings.skybox == skybox3)
        {
            RenderSettings.skybox = skybox1;
            audioSrc.clip = Resources.Load<AudioClip>("Sounds/night");
            audioSrc.Play();
            cloud1.SetActive(false);
            cloud2.SetActive(false);
            smoke.SetActive(true);
            storm.SetActive(false);
        }
        yield return new WaitForSeconds(1.5f);
        i = 3;
        

    }
 


}
