using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAreaAudio : MonoBehaviour
{
    public AudioSource fartAudio;

    private void OnTriggerEnter(Collider other)
    {
        fartAudio.Play();
    }
}
