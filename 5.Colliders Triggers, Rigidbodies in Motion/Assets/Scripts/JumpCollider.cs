using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCollider : MonoBehaviour
{
    [SerializeField]
    float trust = 200f;
    private void OnCollisionEnter(Collision collision)
    {

        
        collision.transform.GetComponent<Rigidbody>().AddForce(transform.up * trust);
    }
}
