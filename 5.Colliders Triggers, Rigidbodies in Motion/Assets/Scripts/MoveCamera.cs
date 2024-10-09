using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    GameObject objCamera;

    [SerializeField]
    GameObject objPlayer;
    public bool came = false;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector3 currPos = objCamera.transform.position;
        
        if (came)
        {
            currPos.y = objPlayer.transform.position.y + 10;
            currPos.x = objPlayer.transform.position.x + 10;
            objCamera.transform.position = currPos;
            Debug.Log("pik");
        }
        else
        {
            currPos.y = objPlayer.transform.position.y;
            currPos.x = objPlayer.transform.position.x;
            objCamera.transform.position = currPos;
        }
    }
}
