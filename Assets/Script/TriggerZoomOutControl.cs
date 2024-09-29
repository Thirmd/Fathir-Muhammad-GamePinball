using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOutControl : MonoBehaviour
{
    public Collider bola;
    public cameraController cameraController;

    private void OnTriggerEnter(Collider other) {
        if(other == bola) {
            cameraController.GoBackToDefault();
            }
    }
}
