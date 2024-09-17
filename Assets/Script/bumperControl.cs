using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumperControl : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;

    public audioManager audioManager;
    public VFXManager vfxManager;


    private Renderer renderer;
    private Animator animator;

    private void Start() {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        
        renderer.material.color = color;
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider == bola){
            Rigidbody bolarig = bola.GetComponent<Rigidbody>();
            bolarig.velocity *= multiplier;
        }

        //animasyon
        animator.SetTrigger("hit");

        //sfx
        audioManager.PlaySFX(collision.transform.position);

        //vfx
        vfxManager.PlayVFX(collision.transform.position);
    }
}
