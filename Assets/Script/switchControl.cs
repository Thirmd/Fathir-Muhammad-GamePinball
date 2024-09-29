using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class switchControl : MonoBehaviour
{
    private enum SwitchState{
        Off,
        On,
        Blink
    }
    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public float score;

    private SwitchState state;
    private Renderer renderer;

    
    public audioManager audioManager;
    public VFXManager vfxManager;

    public scoreManager scoreManager;

    private void Start() {
        renderer = GetComponent<Renderer>();

        Set(false);
        StartCoroutine(BlinkTimesStart(3));
    }
    private void OnTriggerEnter(Collider other) {
        if (other == bola){
            Toggle();
            //sfx
        audioManager.PlaySFX2(other.transform.position);

        //vfx
        vfxManager.PlayVFX2(other.transform.position);
    }
    }

    private void Set(bool active){
        if (active == true){
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else{
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimesStart(3));
        }
    }

    private void Toggle(){
        if(state == SwitchState.On){
            Set(false);
        }
        else{
            Set(true);
        }
        
        scoreManager.AddScore(score);
    }

    private IEnumerator Blink(int times){
        state = SwitchState.Blink;

        for (int i = 0;i < times; i++) {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.3f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.3f);

        }

        state = SwitchState.Off;
        StartCoroutine(BlinkTimesStart(3));
    }

    private IEnumerator BlinkTimesStart(float time){
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
