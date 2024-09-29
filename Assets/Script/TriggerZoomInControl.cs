using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInControl : MonoBehaviour
{
    public Collider bola;
    public cameraController cameraController;
    public float length;

    private void OnTriggerEnter(Collider other) {
        if(other == bola) {
            cameraController.FollowTarget(bola.transform, length);
        }
    }
}
