using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall_GameManager : MonoBehaviour
{
    public AudioClip _telephoneRing;
    public AudioClip _microphone;
    public AudioSource playerPhone;
    public List <AudioSource> _envTelephones;

    private const int FREQUENCY = 48000;
 
  public void Start () {
    
    foreach (AudioSource phone in _envTelephones)
    {
        phone.Stop();
    }

    playerPhone.Play();
  }

  /// Starts the Mic, and plays the audio back in (near) real-time.
  public void StartMicListener() {
    
    playerPhone.Stop();
    
    _microphone = Microphone.Start(Microphone.devices[1], true, 999, FREQUENCY);
    // HACK - Forces the function to wait until the microphone has started, before moving onto the play function.
    while (!(Microphone.GetPosition(Microphone.devices[1]) > 0)) {
    } foreach (AudioSource phone in _envTelephones)
    {
        phone.clip = _microphone;
        //phone.Play();

        StartCoroutine(PlayPhonesInSequence());
    }
  }

  IEnumerator PlayPhonesInSequence()
  {
      for(int i = 0; i < _envTelephones.Count; i++)
      {
          yield return new WaitForSeconds(1);
          _envTelephones[i].Play();
      }
  }
}
