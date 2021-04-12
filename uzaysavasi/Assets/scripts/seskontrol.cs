using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskontrol : MonoBehaviour
{
    [SerializeField]
    AudioClip astreoidpatlama = default;
    [SerializeField]
    AudioClip gemipatlama = default;
    [SerializeField]
    AudioClip ates = default;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void asteroidpatlama()
    {
        audioSource.PlayOneShot(astreoidpatlama);
    }
    public void atess()
    {
        audioSource.PlayOneShot(ates,0.1f);
    }
    public void gemipatlatma()
    {
        audioSource.PlayOneShot(gemipatlama);
    }
}
