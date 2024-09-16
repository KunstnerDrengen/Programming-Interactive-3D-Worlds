using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class boom : MonoBehaviour
{
    public bool starboom = false;

    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem ps = GameObject.Find("Particle System").GetComponent<ParticleSystem>();
        ps.Stop();
        //GameObject.FindGameObjectsWithTag("Sun");

    }
    public void BOOM()
    {
        starboom = true;
    }

    void Update()
    {
        ParticleSystem ps = GameObject.Find("Particle System").GetComponent<ParticleSystem>();


        if (starboom)
        {
            ps.Play();
            starboom = false;
            StartCoroutine("startTimer");

        }

    }
    IEnumerator startTimer()
    {
        yield return new WaitForSeconds(1);
        
    }
}
