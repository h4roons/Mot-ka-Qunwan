using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour
{
    public Audio[] Soundlist;

    public static audioManager instance;
    private void Awake()
    {
        foreach(Audio sound in Soundlist)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;

        }
    }
    public void PlaySound(string name)
    {
        Audio sound = Array.Find(Soundlist, Audio => Audio.SoundName == name);
        sound.source.Play();
    }
    public void StopSound(string name)
    {
        Audio sound = Array.Find(Soundlist, Audio => Audio.SoundName == name);
        sound.source.Stop();
    }
    void Start()
    {
       
        instance = this;  
 }

    
    void Update()
    {
        
    }
}
