using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class AudioFadeScript
{
    
    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;
        float previous;

        while (audioSource.volume > 0)
        {
            previous =  audioSource.volume;
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
             if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) 
                {
                    Debug.Log("No Longer Fading Out");
                    break;
                    }

            yield return null;
        }
    }
 
    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = 0.2f;
        audioSource.loop = true;
        audioSource.volume = 0;
        float previous;
        
         
        while (audioSource.volume < 1.0f)
        {
            //Debug.Log(audioSource.volume);
            previous =  audioSource.volume;
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;
             if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) 
                {
                    Debug.Log("No Longer Fading In");
                    break;
                    }
                    
            yield return null;
        }
    }

    public static IEnumerator clickCheck(AudioSource audioSource)
    {
        audioSource.Play();
        audioSource.loop = true;
        
        while (true)
        {
             if(Input.GetMouseButtonUp(0)) 
                {
                    audioSource.Stop();
                    Debug.Log("No Longer Clicking");
                    break;
                    }
                    
            yield return null;
        }      
    }
}