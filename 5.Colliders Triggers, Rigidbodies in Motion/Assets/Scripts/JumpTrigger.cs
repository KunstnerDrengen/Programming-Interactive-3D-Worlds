using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    MoveCamera moveCamera;

    private void Awake()
    {
        moveCamera = GetComponent<MoveCamera>();

    }
    private void OnCollisionEnter()
    {
        moveCamera.came = true;
    }

}
