using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.IMGUI.Controls;
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

    private SwitchState state;
    private Renderer renderer;

    private void Start() {
        renderer = GetComponent<Renderer>();

        Set(false);
        StartCoroutine(BlinkTimesStart(3));
    }
    private void OnTriggerEnter(Collider other) {
        if (other == bola){
            Toggle();
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
