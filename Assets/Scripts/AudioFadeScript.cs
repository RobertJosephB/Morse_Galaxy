using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class AudioFadeScript
{
    
    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;
 Debug.Log("Fading Out");
        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.Stop();
        audioSource.volume = startVolume;
    }
 
    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = 0.2f;
 
        audioSource.volume = 0;
        audioSource.Play();
        audioSource.loop = true;
        while (audioSource.volume < 1.0f)
        {
            
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.volume = 0.8f;
        
    }
}