using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_bear : MonoBehaviour
{

    float Speed = 0.1f;
    bool Light_show = true;


    private void OnTriggerStay(Collider other)
    {
        Light_show = false;
        transform.position += new Vector3(-0.1f, 0, 0f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Light_show)
        {
            transform.position += new Vector3(Speed, 0, 0f) * Time.deltaTime;
        }
        
    }
}
