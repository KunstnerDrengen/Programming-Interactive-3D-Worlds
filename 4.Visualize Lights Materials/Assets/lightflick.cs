using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightflick : MonoBehaviour
{

    private Light Flicker;
    

    // Start is called before the first frame update
    void Start()
    {
        Flicker = GetComponent<Light>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float randomNumber = Random.Range(0.0f, 2.0f);


        Flicker.intensity = randomNumber;

    }
}
