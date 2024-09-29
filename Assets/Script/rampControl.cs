using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rampControl : MonoBehaviour
{
    public float score;

    public Collider bola;
    public scoreManager scoreManager;

    private void OnTriggerEnter(Collider other) {
        if (other == bola) {
            scoreManager.AddScore(score);
        }
    }
}
