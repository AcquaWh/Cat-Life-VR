using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public AudioClip correct;
    public AudioSource audioSource;
    public void Correct()
    {
        ScoreScript.scoreValue += 50;
        audioSource.PlayOneShot(correct, 0.7F);
    }
}
