using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class CrashSound : MonoBehaviour
{
    public AudioClip[] crashSound;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (audioSource != null) {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
