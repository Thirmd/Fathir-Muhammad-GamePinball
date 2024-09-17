using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcherControl : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;
    public float maxforce;
    public float maxtimehold;

    private bool isHold = false;
    
    private void OnCollisionStay(Collision collision) {
        if(collision.collider == bola) {
            ReadInput(bola);
        }
    }

    private void ReadInput(Collider collider){
        if(Input.GetKey(input)){
            StartCoroutine(StartHold(collider));
    }
    }

    private IEnumerator StartHold(Collider collider){
        isHold=true;

        float force = 0.0f;
        float timehold = 0.0f;

        while(Input.GetKey(input)){
            force = Mathf.Lerp(0, maxforce, timehold/maxtimehold);

            yield return new WaitForEndOfFrame();
            timehold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
    }
}
