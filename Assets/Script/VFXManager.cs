using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxaudiosource;
    public GameObject vfxaudiosource2;

    public void PlayVFX(Vector3 spawnPosition){
        GameObject.Instantiate(vfxaudiosource, spawnPosition, Quaternion.identity);
    }
    public void PlayVFX2(Vector3 spawnPosition){
        GameObject.Instantiate(vfxaudiosource2, spawnPosition, Quaternion.identity);
    }
}
