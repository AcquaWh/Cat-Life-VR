using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaScript : MonoBehaviour
{
    public GameObject Panel1;
    public AudioClip meow;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if(Panel1 != null)
            {
                bool isActive = Panel1.activeSelf;
                Panel1.SetActive(true);
                audioSource.PlayOneShot(meow, 0.7F);
                ScoreScript.scoreValue += 10;
                Destroy(gameObject);
            }
        }
    }
}
