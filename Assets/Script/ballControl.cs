using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControl : MonoBehaviour
{
    public float maxspeed;
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
     rig = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
     if(rig.velocity.magnitude > maxspeed){
        rig.velocity = rig.velocity.normalized * maxspeed;
     }
    }
}
