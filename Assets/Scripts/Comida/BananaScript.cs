using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaScript : MonoBehaviour
{
    public GameObject Panel;
    public AudioClip meow;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if(Panel != null)
            {
                bool isActive = Panel.activeSelf;
                Panel.SetActive(true);
                audioSource.PlayOneShot(meow, 0.7F);
                ScoreScript.scoreValue += 10;
                Destroy(gameObject);
            }
        }
    }
}
