using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxaudiosource;

    public void PlayVFX(Vector3 spawnPosition){
        GameObject.Instantiate(vfxaudiosource, spawnPosition, Quaternion.identity);
    }
}
