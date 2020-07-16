using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongAnswer : MonoBehaviour
{
    public AudioClip wrong;
    public AudioSource audioSource;
    public void Wrong()
    {
        audioSource.PlayOneShot(wrong, 0.7F); 
    }
}
